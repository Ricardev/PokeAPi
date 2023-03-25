using AutoMapper;
using Pokemon.Entities;
using Pokemon.Models;

namespace Pokemon.AutoMapper;

public class PokemonDomainToViewModel : Profile
{
    public PokemonDomainToViewModel()
    {
        CreateMap<PokemonEntityFromJson, PokemonModel>()
            .ForMember(dest => dest.FrontDefault, 
                src => src.MapFrom(x => x.Sprites.FrontDefault));
        CreateMap<PokemonEntityFromJson.StatsFromJson, StatsModel>();
        CreateMap<PokemonEntityFromJson.TypesFromJson, TypesModel>();
        CreateMap<PokemonEntityFromJson.AbilityFromJson, AbilityModel>();
        CreateMap<PokemonEntityFromJson.AbilitiesFromJson, AbilitiesModel>();
        CreateMap<PokemonEntityFromJson.StatFromJson, StatModel>();
        CreateMap<PokemonEntityFromJson.TypeFromJson, TypeModel>();
        CreateMap<EvolutionChainEntityFromJson, EvolutionChainModel>();
        CreateMap<EvolutionEntityFromJson, EvolutionChainModel.EvolutionModel>();
        CreateMap<EvolutionChainSpeciesEntityFromJson, EvolutionChainModel.SpeciesModel>();
        CreateMap<ChainEntityFromJson, EvolutionChainModel.ChainModel>();
        CreateMap<PokemonEntity, PokemonCapturadoModel>();
        CreateMap<AbilityEntity, AbilityModel>()
            .ForMember(dest => dest.Name,
                src => src.MapFrom(x => x.Name));
        CreateMap<TypeEntity, TypeModel>();
        
    }
}