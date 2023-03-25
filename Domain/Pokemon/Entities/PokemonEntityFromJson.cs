using Newtonsoft.Json;
using Pokemon.Entities;

public class PokemonEntityFromJson
{
    public int Id { get;  set; }
    public string Name { get;  set; }
    public SpritesFromJson Sprites { get;  set; }
    public int Height { get;  set; }
    public int Weight { get;  set; }
    public ICollection<AbilitiesFromJson> Abilities { get; set; }
    public ICollection<TypesFromJson> Types { get; set; }
    public ICollection<StatsFromJson> Stats { get; set; }
    public EvolutionChainSpeciesEntityFromJson Species { get; set; }
    public EvolutionChainEntityFromJson EvolutionChain { get; set; } 
    public string EvolutionChainUrl { get; set; }

    public class StatsFromJson
    {
        public StatFromJson Stat { get; set; }
    }

    public class StatFromJson
    {
        public string Name { get; set; }
    }
    public class SpritesFromJson
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }
    }

    public class AbilitiesFromJson
    {
        public AbilityFromJson Ability { get; set; }
    }

    public class AbilityFromJson
    {
        public string Name { get; set; }
    }

    public class TypesFromJson
    {
        public TypeFromJson Type { get; set; }
    }
    
    public class TypeFromJson
    {
        public string Name { get; set; }
    }
}