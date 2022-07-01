using Microsoft.EntityFrameworkCore;
using SolutionProject.Data;
using SolutionProject.Services.BankRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Services.BankRepository.Repository
{
    public class UserService : BaseService, IUserService
    {
        public UserService(BankSystemDbContext context)
            : base(context)
        {
        }

        public async Task<string> GetUserIdByUsernameAsync(string username)
        {
            var user = await this.Context
                .Users
                .AsNoTracking()
                .SingleOrDefaultAsync(u => u.UserName == username);

            return user?.Id;
        }

        public async Task<string> GetAccountOwnerFullnameAsync(string userId)
        {
            var user = await this.Context
                .Users
                .AsNoTracking()
                .SingleOrDefaultAsync(u => u.Id == userId);

            return user?.FullName;
        }
    }
}