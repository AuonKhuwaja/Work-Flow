using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Application.Interfaces.Repositories;
using Work_Flow.Application.Interfaces.Services;
using Work_Flow.Domain.Domain;

namespace Work_Flow.Infrastructure.Implementation.Services
{
    public class AccountService : IAccountService
    {
        private IAccountRepo _accountRepo;

        public AccountService(  IAccountRepo accountRepo) {
            _accountRepo = accountRepo;
        }

        public async Task<Users> LoginAsync()
        {
            await Task.Delay(10);

            var user = new Users
            {
                User_ID = 1,
                username = "Auon Khuwaja",
                Email = "aoun.khuwaja@hrsgonine.com",
                PasswordHash = "1234",
                Role = "Admin"
            };

            return user;
        }
     
    }
}
