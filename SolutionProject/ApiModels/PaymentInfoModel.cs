using SolutionProject.Common.AutoMapping.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.ApiModels
{
    public class PaymentInfoModel : IMapWith<GlobalTransferDto>
    {
        [Required]
        [Range(typeof(decimal), "0.1", "36985262514264337593541458963")]
        public decimal Amount { get; set; }

        public string Description { get; set; }

        [Required] public string Number { get; set; }

        [Required] public string Name { get; set; }

        [Required] public string RecipientName { get; set; }

        [Required] public string ExpiryDate { get; set; }

        [Required] public string SecurityCode { get; set; }

        [Required] public string DestinationBankName { get; set; }

        [Required] public string DestinationBankSwiftCode { get; set; }

        [Required] public string DestinationBankCountry { get; set; }

        [Required] public string DestinationBankAccountUniqueId { get; set; }
    }
}