using SolutionProject.Areas.MoneyTransfers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Services.CoreApi.Data.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<BankAccountIndexViewModel> UserBankAccounts { get; set; }

        public IEnumerable<MoneyTransferListingDto> MoneyTransfers { get; set; }
    }
}