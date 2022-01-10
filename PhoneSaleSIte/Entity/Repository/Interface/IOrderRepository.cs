using System.Threading.Tasks;
using Entity.Models;

namespace Entity.Repository.Interface
{
    public interface IOrderRepository
    {
        public Task AddOrderAsync(Order order);
    }
}
