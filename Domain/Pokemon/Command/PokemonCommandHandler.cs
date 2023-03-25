using MediatR;
using Pokemon.Builders;
using Pokemon.Entities;
using Pokemon.Repository;

namespace Pokemon.Command;

public class PokemonCommandHandler : IRequestHandler<CapturePokemonCommand, PokemonEntity>
{
    private readonly IPokemonRepository _pokemonRepository;

    public PokemonCommandHandler(IPokemonRepository pokemonRepository)
    {
        _pokemonRepository = pokemonRepository;
    }


    public async Task<PokemonEntity> Handle(CapturePokemonCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var pokemonCapturado = new PokemonBuilder()
                .SetPokemonHeight(request.Height)
                .SetPokemonName(request.Name)
                .SetPokemonWeight(request.Weight)
                .SetPokemonFrontDefault(request.FrontDefault)
                .SetPokemonAbilities(request.Abilities)
                .SetPokemonTypes(request.Types)
                .Build();
            return await _pokemonRepository.CapturarPokemon(pokemonCapturado);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }
}