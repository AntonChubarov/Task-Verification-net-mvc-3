using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Models;
using Entity.Models;

namespace Entity.Repository.Interface
{
    public interface IUserRepository
    {
        public Task<User> AddUserToDbAsync(RegisterModel model);
        public Task<User> FindUserInDbAsync(LoginModel model);
    }
}
