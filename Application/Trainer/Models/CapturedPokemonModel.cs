namespace Trainer.Models;

public class CapturedPokemonModel
{
    public int Id { get;  set; }
    public string SpriteDefault { get;  set; }
    public int Height { get;  set; }
    public int Weight { get;  set; }
    public IEnumerable<CapturedPokemonAbilityModel> Abilities{ get;  set; }
    public IEnumerable<CapturedPokemonTypeModel> Types { get;  set; }
}