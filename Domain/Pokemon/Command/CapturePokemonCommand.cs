using MediatR;
using Pokemon.Entities;

namespace Pokemon.Command;

public class CapturePokemonCommand : IRequest<PokemonEntity>
{

    public int Id { get; }
    public string Name { get;}
    public string FrontDefault { get;}
    public int Height { get; }
    public int Weight { get;}
    public List<AbilityCommand> Abilities{ get; set; }
    public List<TypeCommand> Types { get; set; }

    public CapturePokemonCommand(int id, string name, string frontDefault, int height, int weight)
    {
        Id = id;
        Name = name;
        FrontDefault = frontDefault;
        Height = height;
        Weight = weight;
        Abilities = new List<AbilityCommand>();
        Types = new List<TypeCommand>();
    }
}