using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SolutionProject.Services.BankModels.BankAccount;
using SolutionProject.Services.BankRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Areas.MoneyTransfers.Controllers
{
    [Area("MoneyTransfers")]
    public abstract class BaseMoneyTransferController : Controller
    {
        private readonly IBankAccountService bankAccountService;

        protected BaseMoneyTransferController(IBankAccountService bankAccountService, IMapper mapper)
        {
            this.bankAccountService = bankAccountService;
            this.Mapper = mapper;
        }

        protected IMapper Mapper { get; }

        protected async Task<OwnBankAccountListingViewModel[]> GetAllAccountsAsync(string userId)
            => (await this.bankAccountService
                    .GetAllAccountsByUserIdAsync<BankAccountIndexServiceModel>(userId))
                .Select(this.Mapper.Map<OwnBankAccountListingViewModel>)
                .ToArray();
    }
}