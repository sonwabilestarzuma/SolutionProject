using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Services.CoreApi.Data.CoreApi.Services.Models.Banks
{
    public class BankServiceModel : BankBaseServiceModel
    {
        public string ApiAddress { get; set; }

        public string ApiKey { get; set; }
    }
}