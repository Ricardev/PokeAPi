using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pokemon.Repository;
using Microsoft.Extensions.Configuration;
namespace Pokemon;

public static class DependencyInjector
{
    public static IServiceCollection AddPokemonServices(this IServiceCollection services, ConfigurationManager configuration)
    {
        var connection = configuration["DatabaseConnection:SQLiteConnection"];

        services.AddDbContext<PokemonContext>(op => op.UseSqlite(connection));
        services.AddScoped<IPokemonApplication, PokemonApplication>();
        
        services.AddScoped(x => new PokemonContext());
        services.AddScoped<IPokemonRepository, PokemonRepository>();
        services.AddAutoMapper(typeof(OrderAutoMapperConfig));
        services.AddMediatR(typeof(OrderCommandHandler));
        return services;
    }
}