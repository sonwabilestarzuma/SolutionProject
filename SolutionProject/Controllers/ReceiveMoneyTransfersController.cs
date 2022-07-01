using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SolutionProject.ApiModels;
using SolutionProject.Services.BankModels.BankAccount;
using SolutionProject.Services.BankModels.MoneyTransfer;
using SolutionProject.Services.BankRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   
    [IgnoreAntiforgeryToken]
    public class ReceiveMoneyTransfersController : ControllerBase
    {
        private readonly IBankAccountService bankAccountService;
        private readonly IMoneyTransferService moneyTransferService;

        public ReceiveMoneyTransfersController(
            IMoneyTransferService moneyTransferService,
            IBankAccountService bankAccountService)
        {
            this.moneyTransferService = moneyTransferService;
            this.bankAccountService = bankAccountService;
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string data)
        {
            var model = JsonConvert.DeserializeObject<ReceiveMoneyTransferModel>(data);
            if (!this.TryValidateModel(model))
            {
                return this.BadRequest();
            }

            var account =
                await this.bankAccountService.GetByUniqueIdAsync<BankAccountConciseServiceModel>(
                    model.DestinationBankAccountUniqueId);
            if (account == null || !string.Equals(account.UserFullName, model.RecipientName,
                StringComparison.InvariantCulture))
            {
                return this.BadRequest();
            }

            var serviceModel = new MoneyTransferCreateServiceModel
            {
                AccountId = account.Id,
                Amount = model.Amount,
                Description = model.Description,
                DestinationBankAccountUniqueId = model.DestinationBankAccountUniqueId,
                Source = model.SenderAccountUniqueId,
                SenderName = model.SenderName,
                RecipientName = model.RecipientName,
                ReferenceNumber = model.ReferenceNumber
            };

            var isSuccessful = await this.moneyTransferService.CreateMoneyTransferAsync(serviceModel);
            if (!isSuccessful)
            {
                return this.NoContent();
            }

            return this.Ok();
        }
    }
}