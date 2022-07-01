using SolutionProject.Areas.MoneyTransfers.Models;
using SolutionProject.Common.AutoMapping.Repository;
using SolutionProject.Infrastructure.Collections;
using SolutionProject.Services.BankModels.BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Services.CoreApi.Data.ViewModels
{
    public class BankAccountDetailsViewModel : IMapWith<BankAccountDetailsServiceModel>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Balance { get; set; }

        public string UniqueId { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserFullName { get; set; }

        public PaginatedList<MoneyTransferListingDto> MoneyTransfers { get; set; }

        public int MoneyTransfersCount { get; set; }

        public string BankName { get; set; }

        public string BankCode { get; set; }

        public string BankCountry { get; set; }
    }
}