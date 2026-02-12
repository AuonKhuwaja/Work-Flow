using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Application.Interfaces.Repositories;
using Work_Flow.Application.Interfaces.Services;

namespace Work_Flow.Infrastructure.Implementation.Services
{
    public class AccountService : IAccountService
    {
        private IAccountRepo _accountRepo;

        public AccountService(  IAccountRepo accountRepo) {
            _accountRepo = accountRepo;
        } 

        public string Login()
        {
            var login = _accountRepo.Login();
            if (login == null)
            {
                return "login failed";

            }
            else { return login; }  
        }
    }
}
