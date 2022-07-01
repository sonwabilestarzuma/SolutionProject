using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Services.BankModels.BankAccount
{
    public class BankAccountConciseServiceModel : BankAccountBaseServiceModel
    {
        public string Id { get; set; }

        public string UniqueId { get; set; }

        public decimal Balance { get; set; }

        public string UserFullName { get; set; }
    }
}