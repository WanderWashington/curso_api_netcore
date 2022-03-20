using Api.Domain.Interfaces;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCuting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>(); //cria uma nova instancia para cada operação    
            serviceCollection.AddTransient<ILoginService, LoginService>(); //cria uma nova instancia para cada operação

        }
    }
}
