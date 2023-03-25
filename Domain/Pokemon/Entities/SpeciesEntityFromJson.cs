using Newtonsoft.Json;

namespace Pokemon.Entities;

public class SpeciesEntityFromJson
{
    [JsonProperty("evolution_chain")]
    public SpeciesEvolutionChain EvolutionChain { get; set; }
}

public class SpeciesEvolutionChain
{
    public string Url { get; set; }
}