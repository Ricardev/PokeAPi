namespace Pokemon.Command;

public class TypeCommand
{
    public string Name { get; private set; }

    public TypeCommand(string name)
    {
        Name = name;
    }
}