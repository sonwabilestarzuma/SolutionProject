using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Services.BankModels.Card
{
    public class CardDetailsServiceModel : CardBaseServiceModel
    {
        public string Id { get; set; }

        public string Number { get; set; }

        public string Name { get; set; }

        public string ExpiryDate { get; set; }

        public string SecurityCode { get; set; }

        public string AccountId { get; set; }

        public string AccountName { get; set; }

        public string UserId { get; set; }
    }
}

