using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Application.Interfaces.Repositories;

namespace Work_Flow.Infrastructure.Implementation.Repositories
{
    public class AccountRepo : IAccountRepo
    {
        public async Task<Users> LoginAccountAsync()
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
