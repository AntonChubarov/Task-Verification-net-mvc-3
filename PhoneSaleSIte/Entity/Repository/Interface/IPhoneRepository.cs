using System.Collections.Generic;
using System.Threading.Tasks;
using Entity.Models;

namespace Entity.Repository.Interface
{
    public interface IPhoneRepository
    {
        public Task<List<Phone>> GetPhoneListAsync();
    }
}
