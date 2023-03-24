using AutoMapper;

namespace Trainer.AutoMapper;

public class TrainerViewModelToDomain : Profile
{
    public TrainerViewModelToDomain()
    {
        CreateMap<TrainerModel, TrainerDomain>();
    }
}