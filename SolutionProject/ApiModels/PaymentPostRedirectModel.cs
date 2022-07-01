using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.ApiModels
{
    public class PaymentPostRedirectModel
    {
        public string Url { get; set; }

        public string PaymentDataFormKey { get; set; }

        public string PaymentData { get; set; }
    }
}