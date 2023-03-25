using MediatR;

namespace Trainer.Command;

public class CreateTrainerCommand : IRequest<bool>
{
    public int Idade { get;  }
    public string Cpf { get;  }
    public string Nome { get; }

    public CreateTrainerCommand(int idade, string cpf, string nome)
    {
        Idade = idade;
        Cpf = cpf;
        Nome = nome;
    }
}