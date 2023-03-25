using AutoMapper;

namespace Trainer.AutoMapper;

public static class TrainerAutoMapperConfig 
{
    public static MapperConfiguration RegisterTrainerMapping()
    {
        return new MapperConfiguration(configuration =>
        {
            configuration.AddProfile(new TrainerDomainToViewModel());
            configuration.AddProfile(new TrainerViewModelToDomain());
        });
    }
}