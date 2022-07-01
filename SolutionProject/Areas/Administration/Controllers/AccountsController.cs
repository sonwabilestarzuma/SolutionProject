using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SolutionProject.Areas.Administration.Models;
using SolutionProject.Services.BankModels.BankAccount;
using SolutionProject.Services.BankRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Areas.Administration.Controllers
{
    public class AccountsController : BaseAdministrationController
    {
        private const int AccountsPerPage = 20;

        private readonly IBankAccountService bankAccountService;
        private readonly IMapper mapper;

        public AccountsController(IBankAccountService bankAccountService, IMapper mapper)
        {
            this.bankAccountService = bankAccountService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index(int pageIndex = 1)
        {
            pageIndex = Math.Max(1, pageIndex);

            var allAccounts = (await this.bankAccountService.GetAccountsAsync<BankAccountDetailsServiceModel>(pageIndex, AccountsPerPage))
                .Select(this.mapper.Map<BankAccountListingViewModel>)
                .ToPaginatedList(await this.bankAccountService.GetCountOfAccountsAsync(), pageIndex, AccountsPerPage);

            var transfers = new AllBankAccountsListViewModel
            {
                BankAccounts = allAccounts
            };

            return this.View(transfers);
        }
    }
}
