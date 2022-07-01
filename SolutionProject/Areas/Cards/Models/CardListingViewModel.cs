using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Areas.Cards.Models
{
    public class CardListingViewModel
    {
        public PaginatedList<CardListingDto> Cards { get; set; }
    }
}