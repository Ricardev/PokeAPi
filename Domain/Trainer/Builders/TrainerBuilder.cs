using Trainer.Entities;

namespace Trainer.Builders;

public class TrainerBuilder
{
    private readonly TrainerEntity _trainer;

    public TrainerBuilder()
    {
        _trainer = new TrainerEntity();
    }

    public TrainerBuilder SetTrainerIdade(int idade)
    {
        _trainer.SetTrainerIdade(idade);
        return this;
    }

    public TrainerBuilder SetTrainerName(string name)
    {
        _trainer.SetTrainerName(name);
        return this;
    }
    
    public TrainerBuilder SetTrainerCpf(string cpf)
    {
        _trainer.SetTrainerCpf(cpf);
        return this;
    }

    public TrainerEntity Build() => _trainer;
}