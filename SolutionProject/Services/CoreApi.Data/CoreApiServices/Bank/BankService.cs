using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SolutionProject.Data;
using SolutionProject.Services.BankRepository;
using SolutionProject.Services.CoreApi.Data.CoreApi.Services.Models.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Services.CoreApi.Data.CoreApiServices.Bank
{
    public class BanksService : BaseService, IBanksService
    {
        private readonly IMapper mapper;

        public BanksService(ApiDbContext context, IMapper mapper)
            : base(context)
            => this.mapper = mapper;

        public async Task<T> GetBankAsync<T>(string bankName, string swiftCode, string bankCountry)
            where T : BankBaseServiceModel
        {
            const string likeExpression = "%{0}%";
            var bank = await this.Context
                .Banks
                .Where(b =>
                    EF.Functions.Like(b.Name, string.Format(likeExpression, bankName)) &&
                    EF.Functions.Like(b.SwiftCode, string.Format(likeExpression, swiftCode)) &&
                    EF.Functions.Like(b.Location, string.Format(likeExpression, bankCountry)))
                .ProjectTo<T>(this.mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();

            return bank;
        }

        public async Task<IEnumerable<T>> GetAllBanksSupportingPaymentsAsync<T>()
            where T : BankBaseServiceModel
        {
            var banks = await this.Context
                .Banks
                .AsNoTracking()
                .Where(b => b.PaymentUrl != null)
                .OrderBy(b => b.Location)
                .ThenBy(b => b.Name)
                .ProjectTo<T>(this.mapper.ConfigurationProvider)
                .ToArrayAsync();

            return banks;
        }

        public async Task<T> GetBankByIdAsync<T>(string id)
            where T : BankBaseServiceModel
        {
            return await this.Context
                .Banks
                .AsNoTracking()
                .Where(b => b.Id == id)
                .ProjectTo<T>(this.mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();
        }

        public async Task<T> GetBankByBankIdentificationCardNumbersAsync<T>(string identificationCardNumbers)
            where T : BankBaseServiceModel
            => await this.Context
                .Banks
                .AsNoTracking()
                .Where(b => b.BankIdentificationCardNumbers == identificationCardNumbers)
                .ProjectTo<T>(this.mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();
    }
}