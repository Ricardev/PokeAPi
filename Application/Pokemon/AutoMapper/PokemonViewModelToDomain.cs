using AutoMapper;
using Pokemon.Command;
using Pokemon.Models;

namespace Pokemon.AutoMapper;

public class PokemonViewModelToDomain : Profile
{
    public PokemonViewModelToDomain()
    {
        CreateMap<PokemonModel, CapturePokemonCommand>()
            .ConstructUsing(ctor => new CapturePokemonCommand(ctor.Id,ctor.Name,ctor.FrontDefault,
                ctor.Height,ctor.Weight));
        CreateMap<AbilitiesModel, AbilityCommand>()
            .ConstructUsing(ctor => new AbilityCommand(ctor.Ability.Name));
        CreateMap<TypesModel, TypeCommand>()
            .ConstructUsing(ctor => new TypeCommand(ctor.Type.Name));
    }
}