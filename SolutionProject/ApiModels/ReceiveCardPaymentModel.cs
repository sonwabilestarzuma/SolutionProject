using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.ApiModels
{
    public class ReceiveCardPaymentModel
    {
        public string PaymentInfo { get; set; }

        public string PaymentInfoSignature { get; set; }

        public string PaymentProof { get; set; }

        public string PaymentProofSignature { get; set; }
    }
}