namespace Pokemon.Models;

public class PokemonCapturadoModel
{
    public int Id { get;  set; }
    public string Name { get; set; }
    public string FrontDefault { get;  set; }
    public int Height { get;  set; }
    public int Weight { get;  set; }
    public List<AbilityModel> Abilities{ get;  set; }
    public List<TypeModel> Types { get;  set; }
}