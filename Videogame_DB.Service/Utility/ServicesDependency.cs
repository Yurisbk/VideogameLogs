using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Videogame_DB.Domain.Entities;
using Videogame_DB.Domain.Interfaces;
using Videogame_DB.Infra.Context;
using Videogame_DB.Infra.Repository;
using Videogame_DB.Service.Services;

namespace Videogame_DB.Service.Utility
{
    public static class ServicesDependency
    {
        public static void AddServicesDependency(this IServiceCollection services)
        {
            services.AddScoped<IBaseService<PersonalGames>, BaseService<PersonalGames>>();
            services.AddScoped<IBaseRepository<PersonalGames>, BaseRepository<PersonalGames>>();
            services.AddMemoryCache();

        }
    }
}
