﻿using SolutionProject.Common.AutoMapping.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Dtos
{
    public class CentralApiSubmitTransferDto : IMapWith<GlobalTransferDto>
    {
        public string Description { get; set; }

        public decimal Amount { get; set; }

        public string SenderName { get; set; }

        public string RecipientName { get; set; }

        public string SenderAccountUniqueId { get; set; }

        public string DestinationBankSwiftCode { get; set; }

        public string DestinationBankName { get; set; }

        public string DestinationBankCountry { get; set; }

        public string DestinationBankAccountUniqueId { get; set; }

        public string ReferenceNumber { get; set; } = ReferenceNumberGenerator.GenerateReferenceNumber();
    }
}
