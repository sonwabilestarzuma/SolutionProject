using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Services.BankRepository.IRepository
{
    public interface IBankAccountUniqueIdHelper
    {
        string GenerateAccountUniqueId();

        bool IsUniqueIdValid(string id);
    }
}