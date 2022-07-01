using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Services.CoreApi.Data.CoreApi.Services.Models.Banks
{
    public class BankPaymentServiceModel : BankBaseServiceModel
    {
        public string ApiKey { get; set; }

        public string PaymentUrl { get; set; }

        public string CardPaymentUrl { get; set; }
    }
}