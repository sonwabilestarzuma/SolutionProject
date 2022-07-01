using SolutionProject.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Areas.MoneyTransfers.Models.Global.Create
{
    public class GlobalMoneyTransferCreateDestinationBankDto
    {
        [Required]
        [MaxLength(ModelConstants.BankAccount.SwiftCodeMaxLength)]
        [Display(Name = "Swift/Bank code")]
        public string SwiftCode { get; set; }

        [Required]
        [MaxLength(ModelConstants.BankAccount.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(ModelConstants.BankAccount.CountryMaxLength)]
        public string Country { get; set; }

        [Required]
        public GlobalMoneyTransferCreateDestinationAccountDto Account { get; set; }
    }
}