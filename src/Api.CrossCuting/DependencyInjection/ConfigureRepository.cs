using Api.Data;
using Api.Data.Context;
using Api.Data.Implementations;
using Api.Domain.Interfaces;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCuting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>)); //cria uma nova instancia para cada operação
            serviceCollection.AddScoped<IUserRepository, UserImplementation>(); //cria uma nova instancia para cada operação
            serviceCollection.AddDbContext<MyContext>(
                options => options.UseMySql("Server=localhost; Port=3306; Database=dbApi; Uid=root; Pwd=01101996")
            );
        }
    }
}
