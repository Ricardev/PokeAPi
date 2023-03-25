using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pokemon.Entities;

namespace Pokemon.Repository;

public class PokemonRepository : IPokemonRepository
{
    private readonly PokemonContext _pokemonContext;
    private readonly HttpClient _httpClient;
    private readonly string BaseUrl = "https://pokeapi.co/api/v2/pokemon/";

    public PokemonRepository(PokemonContext context)
    {
        _pokemonContext = context;
        _httpClient = new HttpClient();
    }
    public async Task<IEnumerable<PokemonEntityFromJson>> ObtemListaDePokemons()
    {
        Random randomId = new Random();
        var listIds = new List<int>()
        {
            randomId.Next(1, 258),
            randomId.Next(1, 258),
            randomId.Next(1, 258),
            randomId.Next(1, 258),
            randomId.Next(1, 258),
            randomId.Next(1, 258),
            randomId.Next(1, 258),
            randomId.Next(1, 258),
            randomId.Next(1, 258),
            randomId.Next(1, 258),
        };
        var pokemonsList = await Task.WhenAll(listIds.Select(x => _httpClient.GetStringAsync(BaseUrl+x)));
        var pokemonsEntityList = new List<PokemonEntityFromJson>();
        foreach (var pokemon in pokemonsList)
        {
            pokemonsEntityList.Add(JsonConvert.DeserializeObject<PokemonEntityFromJson>(pokemon));
        }

        await Task
            .WhenAll(pokemonsEntityList.Select(ObterEspecieEEvolucoes));

        return pokemonsEntityList;
    }

    public async Task<PokemonEntityFromJson> ObterPokemonPorNomeOuId(string? name, int? id)
    {
        var queryKey = id != null ? id.ToString() : name;
        var pokemonPorIdResponse = await _httpClient.GetStringAsync(BaseUrl+queryKey);
        var pokemon = JsonConvert.DeserializeObject<PokemonEntityFromJson>(pokemonPorIdResponse);
        await ObterEspecieEEvolucoes(pokemon);
        return pokemon;

    }

    public IEnumerable<PokemonEntity> ObtemPokemonsCapturados()
    {
        return _pokemonContext.Set<PokemonEntity>().AsQueryable()
            .Include(x => x.Types)
            .Include(x => x.Abilities)
            .ToList();
    }

    public async Task<PokemonEntity> CapturarPokemon(PokemonEntity pokemon)
    {
        var pokemonResponse = await _pokemonContext.Pokemon.AddAsync(pokemon);
        await _pokemonContext.SaveChangesAsync();
        return pokemonResponse.Entity;
    }

    private async Task<PokemonEntityFromJson> ObterEspecieEEvolucoes(PokemonEntityFromJson pokemonEntity)
    {
        try
        {
            var speciesResponse = await _httpClient.GetStringAsync(pokemonEntity.Species.Url);
            var species = JsonConvert.DeserializeObject<SpeciesEntityFromJson>(speciesResponse);
            var cadeiaDeEvolucoes = await ObterCadeiaDeEvolucoes(species.EvolutionChain.Url);
            pokemonEntity.EvolutionChain = cadeiaDeEvolucoes;
            return pokemonEntity;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return new PokemonEntityFromJson();
        }
    }
    
    private async Task<EvolutionChainEntityFromJson> ObterCadeiaDeEvolucoes(string url)
    {
        try
        {
            var cadeiaDeEvolucoes = await _httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<EvolutionChainEntityFromJson>(cadeiaDeEvolucoes);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return new EvolutionChainEntityFromJson();
        }

    }
}