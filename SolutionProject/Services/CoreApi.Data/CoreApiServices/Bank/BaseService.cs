using SolutionProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Services.CoreApi.Data.CoreApiServices.Bank
{
    public abstract class BaseService
    {
        protected readonly ApiDbContext Context;

        protected BaseService(ApiDbContext context)
            => this.Context = context;
    }
}