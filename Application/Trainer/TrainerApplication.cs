using AutoMapper;
using MediatR;
using Trainer.Command;
using Trainer.Models;
using Trainer.Repository;

namespace Trainer;

public class TrainerApplication : ITrainerApplication
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    private readonly ITrainerRepository _trainerRepository;

    public TrainerApplication(IMediator mediator, IMapper mapper, ITrainerRepository trainerRepository)
    {
        _mediator = mediator;
        _mapper = mapper;
        _trainerRepository = trainerRepository;
    }
    
    public IEnumerable<GetTrainerModel> ObtemTreinadores()
    {
        var treinadores = _trainerRepository.ObtemListaDeTreinadores();
        return _mapper.Map<IEnumerable<GetTrainerModel>>(treinadores);
    }

    public async Task<bool> InsertTrainer(InsertTrainerModel trainer)
    {
        var createTrainerCommand = _mapper.Map<CreateTrainerCommand>(trainer);
        var success = await _mediator.Send(createTrainerCommand);
        return success;
    }
}