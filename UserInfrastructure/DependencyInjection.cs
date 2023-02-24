using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserInfrastructure.Data;
using UserInfrastructure.Repositories;
using UserInfrastructure.Services;

namespace UserInfrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            #region entity
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserService, UserService>();

            #endregion
            return services;
        }
    }
}
