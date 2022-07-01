﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.ApiModels
{
    public class PaymentSelectBankViewModel
    {
        public decimal Amount { get; set; }

        public string Description { get; set; }

        public IEnumerable<BankListingViewModel> Banks { get; set; }
    }
}