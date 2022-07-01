using Microsoft.AspNetCore.Mvc.Rendering;
using SolutionProject.Common.AutoMapping.Repository;
using SolutionProject.Services.BankModels.Card;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Areas.Cards.Models
{
    public class CardCreateViewModel : IMapWith<CardCreateServiceModel>
    {
        public IEnumerable<SelectListItem> BankAccounts { get; set; }

        [Required]
        [Display(Name = "Choose account")]
        public string AccountId { get; set; }
    }
}

