using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Application.Interfaces.Services;
using Work_Flow.Application.Interfaces.Repositories;

namespace Work_Flow.Infrastructure.Implementation.Services
{
    public class UserServices : IUserServices
    {
        private IUserRepo _userRepo;
        public UserServices(IUserRepo userRepo)
        {
                _userRepo = userRepo;
        }
        public string GetUsersAsync()
        {
            var users = _userRepo.GetUsers();
            return users;
        }
    }
}
