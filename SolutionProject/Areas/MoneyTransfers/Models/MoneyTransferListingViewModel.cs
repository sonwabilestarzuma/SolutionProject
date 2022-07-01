using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Areas.MoneyTransfers.Models
{
    public class MoneyTransferListingViewModel
    {
        public PaginatedList<MoneyTransferListingDto> MoneyTransfers { get; set; }
    }
}