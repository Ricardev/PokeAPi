namespace Pokemon.Entities;

public class TypeEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<PokemonType> PokemonsTypes { get; set; }
    public List<PokemonEntity> PokemonEntities { get; set; }

    public void SetTypeName(string name) => Name = name;
}