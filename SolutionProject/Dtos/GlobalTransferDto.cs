using SolutionProject.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Dtos
{
    public class GlobalTransferDto
    {
        [Required]
        public string SourceAccountId { get; set; }

        [Required]
        [Range(typeof(decimal), ModelConstants.MoneyTransfer.MinStartingPrice, ModelConstants.MoneyTransfer.MaxStartingPrice)]
        public decimal Amount { get; set; }

        [Required]
        [MaxLength(ModelConstants.User.FullNameMaxLength)]
        public string RecipientName { get; set; }

        [MaxLength(ModelConstants.MoneyTransfer.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        [MaxLength(ModelConstants.BankAccount.SwiftCodeMaxLength)]
        public string DestinationBankSwiftCode { get; set; }

        [Required]
        [MaxLength(ModelConstants.BankAccount.NameMaxLength)]
        public string DestinationBankName { get; set; }

        [Required]
        [MaxLength(ModelConstants.BankAccount.CountryMaxLength)]
        public string DestinationBankCountry { get; set; }

        [Required]
        [MaxLength(ModelConstants.BankAccount.UniqueIdMaxLength)]
        public string DestinationBankAccountUniqueId { get; set; }
    }
}