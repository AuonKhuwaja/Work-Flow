using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Work_Flow.Application.Interfaces.Repositories;
using Work_Flow.Infrastructure.Data;

namespace Work_Flow.Infrastructure.Implementation.Repositories
{
    public class UserRepo: IUserRepo
    { 
        private readonly AppDbContext _dbcontext;
        public UserRepo(AppDbContext dbContext)
        {
          _dbcontext = dbContext;
        }
        public string GetUsers()
            {
            var users = _dbcontext.Users.ToList();
            return users.ToString();
        }
    }
}
