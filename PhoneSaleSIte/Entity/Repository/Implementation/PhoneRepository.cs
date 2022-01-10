using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entity.Models;
using Entity.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Entity.Repository.Implementation
{
    public class PhoneRepository : IPhoneRepository
    {
        private ApplicationContext _context;

        public PhoneRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<Phone>> GetPhoneListAsync()
        {
            var phoneList = await _context.Phones.ToListAsync();
            return phoneList;
        }
    }
}
