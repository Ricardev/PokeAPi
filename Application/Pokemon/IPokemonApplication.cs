using Pokemon.Models;

namespace Pokemon;

public interface IPokemonApplication
{
    public Task<IEnumerable<PokemonModel>> ObtemListaDePokemons();
    public Task<PokemonModel> ObtemPokemonPorNomeOuId(string? name, int? id);
    public Task<PokemonCapturadoModel> CapturaPokemon(CapturePokemonModel capturePokemonModel);
    public IEnumerable<PokemonCapturadoModel> ObterPokemonsCapturados();
}