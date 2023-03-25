namespace Trainer.Models;

public class TrainerModel
{
    public int Id { get; private set; }
    public int Idade { get; private set; }
    public int Cpf { get; private set; }
    public IEnumerable<CapturedPokemonModel> Pokemons;
}