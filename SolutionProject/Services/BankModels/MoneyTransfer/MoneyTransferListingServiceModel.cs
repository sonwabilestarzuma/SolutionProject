﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Services.BankModels.MoneyTransfer
{
    public class MoneyTransferListingServiceModel : MoneyTransferBaseServiceModel
    {
        public string Id { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }

        public string SenderName { get; set; }

        public string RecipientName { get; set; }

        public DateTime MadeOn { get; set; }

        public string Source { get; set; }

        public string Destination { get; set; }

        public string ReferenceNumber { get; set; }
    }
}