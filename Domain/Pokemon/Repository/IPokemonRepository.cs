using Pokemon.Entities;

namespace Pokemon.Repository;

public interface IPokemonRepository
{
    public Task<IEnumerable<PokemonEntityFromJson>> ObtemListaDePokemons();
    public Task<PokemonEntityFromJson> ObterPokemonPorNomeOuId(string? name, int? id);
    public IEnumerable<PokemonEntity> ObtemPokemonsCapturados();
    public Task<PokemonEntity> CapturarPokemon(PokemonEntity pokemon);
}