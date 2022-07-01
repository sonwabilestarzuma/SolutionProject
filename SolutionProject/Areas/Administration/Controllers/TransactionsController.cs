using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SolutionProject.Areas.Administration.Models;
using SolutionProject.Areas.MoneyTransfers.Models;
using SolutionProject.Services.BankModels.MoneyTransfer;
using SolutionProject.Services.BankRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Areas.Administration.Controllers
{
    public class TransactionsController : BaseAdministrationController
    {
        private readonly IMoneyTransferService moneyTransfer;
        private readonly IMapper mapper;

        public TransactionsController(IMoneyTransferService moneyTransfer, IMapper mapper)
        {
            this.moneyTransfer = moneyTransfer;
            this.mapper = mapper;
        }

        public IActionResult Search() => this.View();

        public async Task<IActionResult> Result(string referenceNumber)
        {
            if (referenceNumber == null)
            {
                return this.NotFound();
            }

            var moneyTransfers = (await this.moneyTransfer
                    .GetMoneyTransferAsync<MoneyTransferListingServiceModel>(referenceNumber))
                .Select(this.mapper.Map<MoneyTransferListingDto>);

            var viewModel = new TransactionListingViewModel
            {
                MoneyTransfers = moneyTransfers,
                ReferenceNumber = referenceNumber
            };

            return this.View(viewModel);
        }
    }
}