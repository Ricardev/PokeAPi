using AutoMapper;
using MediatR;
using Pokemon.Command;
using Pokemon.Models;
using Pokemon.Repository;

namespace Pokemon;

public class PokemonApplication : IPokemonApplication
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    private readonly IPokemonRepository _pokemonRepository;

    public PokemonApplication(IMediator mediator, IMapper mapper, IPokemonRepository pokemonRepository)
    {
        _mediator = mediator;
        _mapper = mapper;
        _pokemonRepository = pokemonRepository;
    }
    
    public async Task<IEnumerable<PokemonModel>> ObtemListaDePokemons()
    {
        var listaDePokemons = await _pokemonRepository.ObtemListaDePokemons();

        return _mapper.Map<IEnumerable<PokemonModel>>(listaDePokemons);
    }

    public async Task<PokemonModel> ObtemPokemonPorNomeOuId(string? name, int? id)
    {
        var pokemon = await _pokemonRepository.ObterPokemonPorNomeOuId(name, id);
        return _mapper.Map<PokemonModel>(pokemon);
    }

    public async Task<PokemonCapturadoModel> CapturaPokemon(CapturePokemonModel capturePokemonModel)
    {
        var pokemon = await ObtemPokemonPorNomeOuId(capturePokemonModel.Name, capturePokemonModel.Id);
        var capturePokemonCommand = _mapper.Map<CapturePokemonCommand>(pokemon);
        var capturedPokemon = await _mediator.Send(capturePokemonCommand);
        return _mapper.Map<PokemonCapturadoModel>(capturedPokemon);
    }

    public IEnumerable<PokemonCapturadoModel> ObterPokemonsCapturados()
    {
        var pokemonsCapturados = _pokemonRepository.ObtemPokemonsCapturados();
        return _mapper.Map<IEnumerable<PokemonCapturadoModel>>(pokemonsCapturados);
    }
}