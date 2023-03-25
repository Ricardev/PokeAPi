using Pokemon.Command;
using Pokemon.Entities;

namespace Pokemon.Builders;

public class PokemonBuilder
{
    private readonly PokemonEntity _pokemonEntity;

    public PokemonBuilder()
    {
        _pokemonEntity = new PokemonEntity();
    }


    public PokemonBuilder SetPokemonName(string name)
    {
        _pokemonEntity.SetPokemonName(name);
        return this;
    }
    
    public PokemonBuilder SetPokemonHeight(int height)
    {
        _pokemonEntity.SetPokemonHeight(height);
        return this;
    }
    
    public PokemonBuilder SetPokemonWeight(int weight)
    {
        _pokemonEntity.SetPokemonWeight(weight);
        return this;
    }
    
    public PokemonBuilder SetPokemonFrontDefault(string frontDefault)
    {
        _pokemonEntity.SetPokemonFrontSprite(frontDefault);
        return this;
    }
    
    public PokemonBuilder SetPokemonAbilities(List<AbilityCommand> abilitiesCommands)
    {
        var abilities = new List<AbilityEntity>();
        foreach (var ability in abilitiesCommands)
        {
            var abilityEntity = new AbilityEntity();
            abilityEntity.SetAbilityName(ability.Name);
            abilities.Add(abilityEntity);
        }
        _pokemonEntity.SetPokemonAbilities(abilities);
        return this;
    }
    
    public PokemonBuilder SetPokemonTypes(List<TypeCommand> typesCommand)
    {
        var types = new List<TypeEntity>();
        foreach (var type in typesCommand)
        {
            var typeEntity = new TypeEntity();
            typeEntity.SetTypeName(type.Name);
            types.Add(typeEntity);
        }
        _pokemonEntity.SetPokemonTypes(types);
        return this;
    }

    public PokemonEntity Build() => _pokemonEntity;
}