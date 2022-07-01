using SolutionProject.Common.AutoMapping.Repository;
using SolutionProject.Services.BankModels.BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Services.CoreApi.Data.ViewModels
{
    public class BankAccountIndexViewModel : IMapWith<BankAccountIndexServiceModel>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Balance { get; set; }

        public string UniqueId { get; set; }
    }
}