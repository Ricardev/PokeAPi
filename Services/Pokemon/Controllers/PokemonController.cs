using Microsoft.AspNetCore.Mvc;
using Pokemon.Models;

namespace Pokemon.Controllers;

[ApiController]
[Route("[controller]")]
public class PokemonController : ControllerBase
{

    private readonly IPokemonApplication _pokemonApplication;
    public PokemonController(IPokemonApplication pokemonApplication)
    {
        _pokemonApplication = pokemonApplication;
    }

    [HttpGet]
    public async Task<IActionResult> ObtemListaDePokemons()
    {
        return Ok(await _pokemonApplication.ObtemListaDePokemons());
    }
    
    [HttpGet("PokemonPorNomeOuId")]
    public async Task<IActionResult> ObtemListaDePokemonsPorNomeOuId(string? name,int? id)
    {
        return Ok(await _pokemonApplication.ObtemPokemonPorNomeOuId(name, id));
    }
    
    [HttpPost("CapturarPokemon")]
    public async Task<IActionResult> CapturaPokemon(CapturePokemonModel capturePokemonModel)
    {
        return Ok(await _pokemonApplication.CapturaPokemon(capturePokemonModel));
    }
    
    [HttpGet("PokemonsCapturados")]
    public IActionResult ObmteListaDePokemonCaputardos()
    {
        return Ok(_pokemonApplication.ObterPokemonsCapturados());
    }
}
