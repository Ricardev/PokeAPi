namespace Pokemon.Entities;

public class PokemonEntity
{
    public int Id { get;  private set; }
    public string Name { get;  private set; }
    public string FrontDefault { get;  private set; }
    public int Height { get;  private set; }
    public int Weight { get;  private set; }
    public ICollection<PokemonAbility> PokemonAbilities{ get;  private set; }
    public ICollection<PokemonType> PokemonTypes { get;  private set; }
    
    public ICollection<AbilityEntity> Abilities { get; private set; }
    public ICollection<TypeEntity> Types { get; private set; }

    public void SetPokemonName(string name) => Name = name;
    public void SetPokemonFrontSprite(string frontSprite) => FrontDefault = frontSprite;
    public void SetPokemonHeight(int height) => Height = height;
    public void SetPokemonWeight(int weight) => Weight = weight;

    public void SetPokemonAbilities(List<AbilityEntity> abilities) => Abilities = abilities;
    public void SetPokemonTypes(List<TypeEntity> types) => Types = types;

}



