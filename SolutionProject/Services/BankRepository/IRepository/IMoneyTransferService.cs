﻿using SolutionProject.Services.BankModels.MoneyTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Services.BankRepository.IRepository
{
    public interface IMoneyTransferService
    {
        Task<IEnumerable<T>> GetMoneyTransfersAsync<T>(string userId, int pageIndex = 1, int count = int.MaxValue)
            where T : MoneyTransferBaseServiceModel;

        Task<IEnumerable<T>> GetMoneyTransfersForAccountAsync<T>(string accountId, int pageIndex = 1, int count = int.MaxValue)
            where T : MoneyTransferBaseServiceModel;

        Task<IEnumerable<T>> GetLast10MoneyTransfersForUserAsync<T>(string userId)
            where T : MoneyTransferBaseServiceModel;

        Task<bool> CreateMoneyTransferAsync<T>(T model)
            where T : MoneyTransferBaseServiceModel;

        Task<IEnumerable<T>> GetMoneyTransferAsync<T>(string referenceNumber)
            where T : MoneyTransferBaseServiceModel;

        Task<int> GetCountOfAllMoneyTransfersForAccountAsync(string accountId);

        Task<int> GetCountOfAllMoneyTransfersForUserAsync(string userId);
    }
}