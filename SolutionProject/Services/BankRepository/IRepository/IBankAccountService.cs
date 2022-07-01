﻿using SolutionProject.Services.BankModels.BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Services.BankRepository.IRepository
{
    public interface IBankAccountService
    {
        Task<IEnumerable<T>> GetAllAccountsByUserIdAsync<T>(string userId)
            where T : BankAccountBaseServiceModel;

        Task<string> CreateAsync(BankAccountCreateServiceModel model);

        Task<T> GetByUniqueIdAsync<T>(string uniqueId)
            where T : BankAccountBaseServiceModel;

        Task<T> GetByIdAsync<T>(string id)
            where T : BankAccountBaseServiceModel;

        Task<bool> ChangeAccountNameAsync(string accountId, string newName);

        Task<IEnumerable<T>> GetAccountsAsync<T>(int pageIndex = 1, int count = int.MaxValue)
            where T : BankAccountBaseServiceModel;

        Task<int> GetCountOfAccountsAsync();
    }
}