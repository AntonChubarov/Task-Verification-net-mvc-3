using Entity.Repository.Implementation;
using Entity.Repository.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace PhoneSaleSite.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddEFModule(this IServiceCollection service)
        {
            service.AddTransient<IUserRepository, UserRepository>();

            service.AddTransient<IPhoneRepository, PhoneRepository>();

            service.AddTransient<IOrderRepository, OrderRepository>();
        }
    }
}
