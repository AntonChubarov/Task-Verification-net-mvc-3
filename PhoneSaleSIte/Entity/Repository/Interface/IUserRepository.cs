using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Entity.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace Entity.Repository.Interface
{
    public interface IUserRepository
    {
        public Task<User> AddUserToDbAsync(RegisterModel model);
        public Task<User> FindUserInDbAsync(LoginModel model);
    }
}
