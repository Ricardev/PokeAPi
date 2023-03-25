using Microsoft.Extensions.DependencyInjection;
using Trainer.AutoMapper;
using Trainer.Command;
using Trainer.Repository;

namespace Trainer;

public static class DependencyInjector
{
    public static IServiceCollection AddTrainerServices(this IServiceCollection services)
    {
        services.AddScoped(x => new TrainerContext());
        services.AddScoped<ITrainerApplication, TrainerApplication>();
        services.AddScoped<ITrainerRepository, TrainerRepository>();
        services.AddAutoMapper(typeof(TrainerAutoMapperConfig));
        services.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(TrainerCommandHandler).Assembly));
        return services;
    }
}