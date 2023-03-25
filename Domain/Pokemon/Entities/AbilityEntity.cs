
namespace Pokemon.Entities;

public class AbilityEntity
{
    public int AbilityId { get; private set; }
    public string Name { get; private set; }
    public List<PokemonAbility> PokemonsAbility { get; set; }
    public List<PokemonEntity> PokemonsEntity { get; set; }

    public void SetAbilityName(string name) => Name = name;
}