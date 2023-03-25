using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pokemon.Repository;
using Microsoft.Extensions.Configuration;
using Pokemon.AutoMapper;
using Pokemon.Command;

namespace Pokemon;

public static class DependencyInjector
{
    public static IServiceCollection AddPokemonServices(this IServiceCollection services)
    {
        services.AddScoped<IPokemonApplication, PokemonApplication>();
        
        services.AddScoped(x => new PokemonContext());
        services.AddScoped<IPokemonRepository, PokemonRepository>();
        services.AddAutoMapper(typeof(PokemonAutoMapperConfig));
        services.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(PokemonCommandHandler).Assembly));
        return services;
    }
}