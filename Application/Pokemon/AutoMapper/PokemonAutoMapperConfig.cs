using AutoMapper;

namespace Pokemon.AutoMapper;

public static class PokemonAutoMapperConfig
{
    public static MapperConfiguration RegisterPokemonMapping()
    {
        return new MapperConfiguration(configuration =>
        {
            configuration.AddProfile(new PokemonDomainToViewModel());
            configuration.AddProfile(new PokemonViewModelToDomain());
        });
    }
}