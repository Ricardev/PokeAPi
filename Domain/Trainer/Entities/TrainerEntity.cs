using FluentValidation;

namespace Trainer.Entities;

public class TrainerEntity
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public int Idade { get; private set; }
    public string Cpf { get; private set; }

    public void SetTrainerIdade(int idade) => Idade = idade;
    public void SetTrainerName(string name) => Name = name;
    public void SetTrainerCpf(string cpf) => Cpf = cpf;
}

public class TrainerValidator : AbstractValidator<TrainerEntity>
{
    public TrainerValidator()
    {
        RuleFor(x => x.Cpf)
            .Matches(@"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})");
    }
}
