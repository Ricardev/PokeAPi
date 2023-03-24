using AutoMapper;

namespace Trainer.AutoMapper;

public class TrainerDomainToViewModel : Profile
{
    public TrainerDomainToViewModel()
    {
        CreateMap<TrainerEntity, TrainerModel>();
    }
}