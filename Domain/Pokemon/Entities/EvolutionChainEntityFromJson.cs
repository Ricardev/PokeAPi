using Newtonsoft.Json;

namespace Pokemon.Entities;

public class EvolutionChainEntityFromJson
{
    public int Id;
    public ChainEntityFromJson Chain { get; set; }
}

public class ChainEntityFromJson
{
    public EvolutionChainSpeciesEntityFromJson Species { get; set; }
    [JsonProperty("evolves_to")]
    public List<EvolutionEntityFromJson> EvolvesTo { get; set; }
}

public class EvolutionEntityFromJson
{
    public EvolutionChainSpeciesEntityFromJson Species { get; set; }
    [JsonProperty("evolves_to")]
    public List<EvolutionEntityFromJson> EvolvesTo { get; set; }
}

public class EvolutionChainSpeciesEntityFromJson
{
    public string Name { get; set; }
    public string Url { get; set; }
}