using MediatR;
using Trainer.Builders;
using Trainer.Entities;
using Trainer.Repository;

namespace Trainer.Command;

public class TrainerCommandHandler : IRequestHandler<CreateTrainerCommand, bool>
{
    private readonly ITrainerRepository _trainerRepository;

    public TrainerCommandHandler(ITrainerRepository trainerRepository)
    {
        _trainerRepository = trainerRepository;
    }
    
    public async Task<bool> Handle(CreateTrainerCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var treinador = new TrainerBuilder()
                .SetTrainerCpf(request.Cpf)
                .SetTrainerIdade(request.Idade)
                .SetTrainerName(request.Nome)
                .Build();
        
            var success = await _trainerRepository.InserirTreinador(treinador);
            return success != null;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
      
    }
}