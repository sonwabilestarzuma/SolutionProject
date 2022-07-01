using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SolutionProject.ApiModels;
using SolutionProject.Common;
using SolutionProject.Dtos;
using SolutionProject.Helpers;
using SolutionProject.Services.BankModels.Card;
using SolutionProject.Services.BankRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Controllers
{
    [Route("api/[controller]")]
    [IgnoreAntiforgeryToken]
    //[DecryptAndVerifyRequest]
    [ApiController]
    public class CardPaymentsController : ControllerBase
    {
        private readonly ICardService cardService;
        private readonly IGlobalTransferHelper globalTransferHelper;
        private readonly IMapper mapper;

        public CardPaymentsController(IGlobalTransferHelper globalTransferHelper, ICardService cardService, IMapper mapper)
        {
            this.globalTransferHelper = globalTransferHelper;
            this.cardService = cardService;
            this.mapper = mapper;
        }

        // POST: api/CardPayments
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string data)
        {
            var model = JsonConvert.DeserializeObject<PaymentInfoModel>(data);
            if (this.TryValidateModel(model))
            {
                return this.BadRequest();
            }

            var card = await this.cardService.GetAsync<CardDetailsServiceModel>(
                model.Number,
                model.ExpiryDate,
                model.SecurityCode,
                model.Name);

            if (card == null)
            {
                return this.BadRequest();
            }

            bool expirationDateValid = DateTime.TryParseExact(
                card.ExpiryDate,
                GlobalConstants.CardExpirationDateFormat,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out var expirationDate);

            if (!expirationDateValid || expirationDate.AddMonths(1) < DateTime.UtcNow)
            {
                return this.BadRequest();
            }

            var serviceModel = this.mapper.Map<GlobalTransferDto>(model);
            serviceModel.SourceAccountId = card.AccountId;

            var result = await this.globalTransferHelper.TransferMoneyAsync(serviceModel);

            if (result != GlobalTransferResult.Succeeded)
            {
                return this.BadRequest();
            }

            return this.Ok();
        }
    }
}