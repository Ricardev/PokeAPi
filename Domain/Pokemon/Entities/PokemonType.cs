namespace Pokemon.Entities;

public class PokemonType
{
    public int PokemonTypeId { get; set; }
    public int PokemonId { get; set; }
    public int TypeId { get; set; }
    public PokemonEntity Pokemon { get; set; }
    public TypeEntity Type { get; set; }
}