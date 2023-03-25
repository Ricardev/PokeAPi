namespace Pokemon.Models;

public class EvolutionChainModel
{
    public int Id;
    public ChainModel Chain { get; set; }

        public class ChainModel
    {
        public SpeciesModel Species { get; set; }
        public List<EvolutionModel> EvolvesTo { get; set; }
    }

    public class EvolutionModel
    {
        public SpeciesModel Species { get; set; }
        public List<EvolutionModel> EvolvesTo { get; set; }
    }

    public class SpeciesModel
    {
        public string Name { get; set; }
    }
}