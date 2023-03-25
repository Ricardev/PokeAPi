namespace Pokemon.Models;

public class PokemonModel
{
    public int Id { get;  set; }
    public string Name { get; set; }
    public string FrontDefault { get;  set; }
    public int Height { get;  set; }
    public int Weight { get;  set; }
    public List<AbilitiesModel> Abilities{ get;  set; }
    public List<TypesModel> Types { get;  set; }
    public List<StatsModel> Stats { get; set; }
    public EvolutionChainModel EvolutionChain { get; set; }
}