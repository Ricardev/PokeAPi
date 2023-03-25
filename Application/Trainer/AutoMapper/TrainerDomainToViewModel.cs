using AutoMapper;
using Trainer.Entities;
using Trainer.Models;

namespace Trainer.AutoMapper;

public class TrainerDomainToViewModel : Profile
{
    public TrainerDomainToViewModel()
    {
        CreateMap<TrainerEntity, GetTrainerModel>();
    }
}