using SolutionProject.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Areas.MoneyTransfers.Models.Global.Create
{
    public class GlobalMoneyTransferCreateDestinationAccountDto
    {
        [Required]
        [MaxLength(ModelConstants.BankAccount.UniqueIdMaxLength)]
        [Display(Name = "Account/IBAN")]
        public string UniqueId { get; set; }

        [Required]
        [MaxLength(ModelConstants.User.FullNameMaxLength)]
        [Display(Name = "Beneficiary's name")]
        public string UserFullName { get; set; }
    }
}