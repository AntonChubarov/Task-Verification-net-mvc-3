using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Entity.Models;
using Entity.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Entity.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<User> AddUserToDbAsync(RegisterModel model)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
            if (user == null)
            {
                user = new User { Email = model.Email, Password = model.Password };
                var userRole = await _context.Roles.FirstOrDefaultAsync(r => r.Name == "user");
                if (userRole != null)
                    user.Role = userRole;

                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
            }
            return user;
        }

        public async Task<User> FindUserInDbAsync(LoginModel model)
        {
            var user = await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);
            return user;
        }
    }
}
