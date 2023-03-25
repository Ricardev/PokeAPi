namespace Pokemon.Entities;

public class PokemonAbility
{
    public int PokemonAbilityId { get; set; }
    public int PokemonId { get; set; }
    public int AbilityId { get; set; }
    public PokemonEntity Pokemon { get; set; }
    public AbilityEntity Ability { get; set; }
}