using SolutionProject.Common.AutoMapping.Repository;
using SolutionProject.Services.BankModels.BankAccount;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Services.CoreApi.Data.ViewModels
{
    public class BankAccountCreateBindingModel : IMapWith<BankAccountCreateServiceModel>
    {
        [MaxLength(50)]
        public string Name { get; set; }
    }
}