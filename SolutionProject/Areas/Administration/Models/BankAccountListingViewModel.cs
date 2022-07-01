using SolutionProject.Common.AutoMapping.Repository;
using SolutionProject.Services.BankModels.BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Areas.Administration.Models
{
    public class BankAccountListingViewModel : IMapWith<BankAccountDetailsServiceModel>
    {
        public string Name { get; set; }

        public decimal Balance { get; set; }

        public string UniqueId { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserUserName { get; set; }

        public string UserFullName { get; set; }
    }
}