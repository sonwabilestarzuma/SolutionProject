using SolutionProject.Common.AutoMapping.Repository;
using SolutionProject.Services.BankModels.Card;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Areas.Cards.Models
{
    public class CardListingDto : IMapWith<CardDetailsServiceModel>
    {
        public string Id { get; set; }

        public string Number { get; set; }

        public string Name { get; set; }

        public string ExpiryDate { get; set; }

        public string SecurityCode { get; set; }

        public string AccountName { get; set; }
    }
}

