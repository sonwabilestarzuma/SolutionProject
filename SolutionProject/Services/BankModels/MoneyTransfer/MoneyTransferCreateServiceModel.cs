using AutoMapper;
using SolutionProject.Common;
using SolutionProject.Common.AutoMapping.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Services.BankModels.MoneyTransfer
{
    public class MoneyTransferCreateServiceModel : MoneyTransferBaseServiceModel, IHaveCustomMapping
    {
        [MaxLength(ModelConstants.MoneyTransfer.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string AccountId { get; set; }

        [Required]
        [MaxLength(ModelConstants.User.FullNameMaxLength)]
        public string SenderName { get; set; }

        [Required]
        [MaxLength(ModelConstants.User.FullNameMaxLength)]
        public string RecipientName { get; set; }

        [Required]
        public DateTime MadeOn { get; set; } = DateTime.UtcNow;

        [Required]
        [MaxLength(ModelConstants.BankAccount.UniqueIdMaxLength)]
        public string Source { get; set; }

        [Required]
        [MaxLength(ModelConstants.BankAccount.UniqueIdMaxLength)]
        public string DestinationBankAccountUniqueId { get; set; }

        [Required]
        public string ReferenceNumber { get; set; }

        public void ConfigureMapping(Profile mapper)
        {
            mapper.CreateMap<MoneyTransferCreateServiceModel, MoneyTransfer>()
                .ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.DestinationBankAccountUniqueId));
        }
    }
}