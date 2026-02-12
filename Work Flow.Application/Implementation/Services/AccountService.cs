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
            var login = await _accountRepo.LoginAccountAsync();

            if (login == null)
            {
                return null;
            }

            return login;
        }
    }
}
