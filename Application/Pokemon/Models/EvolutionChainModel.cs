namespace Pokemon.Models;

public class EvolutionChainModel
{
    public int Id;
    public ChainEntityFromJson Chain { get; set; }

        public class ChainEntityFromJson
    {
        public SpeciesEntityFromJson Species { get; set; }
        public List<EvolutionEntityFromJson> EvolvesTo { get; set; }
    }

    public class EvolutionEntityFromJson
    {
        public SpeciesEntityFromJson Species { get; set; }
        public List<EvolutionEntityFromJson> EvolvesTo { get; set; }
    }

    public class SpeciesEntityFromJson
    {
        public string Name { get; set; }
    }
}