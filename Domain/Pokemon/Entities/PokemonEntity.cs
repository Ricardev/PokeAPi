namespace Pokemon.Entities;

public class PokemonEntity
{
    public int Id { get; private set; }
    public IEnumerable<EvolutionEntity> Evolutions { get; private set; }
    public IEnumerable<string> Sprites { get; private set; }
    public int Height { get; private set; }
    public int Weight { get; private set; }
    public IEnumerable<AbilityEntity> Abilities{ get; private set; }
    public IEnumerable<TypeEntity> Types { get; private set; }
}