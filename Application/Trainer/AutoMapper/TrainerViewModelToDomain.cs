using AutoMapper;
using Trainer.Command;
using Trainer.Models;

namespace Trainer.AutoMapper;

public class TrainerViewModelToDomain : Profile
{
    public TrainerViewModelToDomain()
    {
        CreateMap<InsertTrainerModel, CreateTrainerCommand>()
            .ConstructUsing(x => new CreateTrainerCommand(x.Idade, x.Cpf, x.Nome));
    }
}