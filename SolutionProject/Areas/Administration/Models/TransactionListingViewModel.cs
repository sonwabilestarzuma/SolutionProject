using SolutionProject.Areas.MoneyTransfers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Areas.Administration.Models
{
    public class TransactionListingViewModel
    {
        public IEnumerable<MoneyTransferListingDto> MoneyTransfers { get; set; }

        public string ReferenceNumber { get; set; }
    }
}