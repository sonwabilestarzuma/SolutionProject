using SolutionProject.Common;
using SolutionProject.Common.AutoMapping.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Areas.MoneyTransfers.Models.Global.Create
{
    public class GlobalMoneyTransferCreateBindingModel : IMapWith<GlobalTransferDto>
    {
        [Required]
        public GlobalMoneyTransferCreateDestinationBankDto DestinationBank { get; set; }

        [MaxLength(ModelConstants.MoneyTransfer.DescriptionMaxLength)]
        [Display(Name = "Details of Payment")]
        public string Description { get; set; }

        [Required]
        [Range(typeof(decimal), ModelConstants.MoneyTransfer.MinStartingPrice,
            ModelConstants.MoneyTransfer.MaxStartingPrice,
            ErrorMessage = "The Amount field cannot be lower than 0.01")]
        public decimal Amount { get; set; }

        [Display(Name = "Name")]
        [MaxLength(ModelConstants.User.FullNameMaxLength)]
        public string SenderName { get; set; }

        public IEnumerable<OwnBankAccountListingViewModel> OwnAccounts { get; set; }

        [Required]
        [Display(Name = "From Account")]
        public string AccountId { get; set; }
    }
}