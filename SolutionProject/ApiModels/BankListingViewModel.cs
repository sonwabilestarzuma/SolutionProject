using SolutionProject.Common.AutoMapping.Repository;
using SolutionProject.Services.CoreApi.Data.CoreApi.Services.Models.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.ApiModels
{
    public class BankListingViewModel : IMapWith<BankListingServiceModel>
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public string SwiftCode { get; set; }

        public string Id { get; set; }
    }
}