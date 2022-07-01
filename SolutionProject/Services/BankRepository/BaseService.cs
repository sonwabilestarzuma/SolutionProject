using SolutionProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Services.BankRepository
{
    public abstract class BaseService
    {
        protected readonly BankSystemDbContext Context;

        protected BaseService(BankSystemDbContext context)
            => this.Context = context;

        protected bool IsEntityStateValid(object model)
            => ValidationUtil.IsObjectValid(model);
    }
}