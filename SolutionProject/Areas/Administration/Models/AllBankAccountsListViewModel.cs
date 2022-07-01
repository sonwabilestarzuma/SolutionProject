using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Areas.Administration.Models
{
    public class AllBankAccountsListViewModel
    {
        public PaginatedList<BankAccountListingViewModel> BankAccounts { get; set; }
    }
}