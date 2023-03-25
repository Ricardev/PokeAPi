using Trainer.Entities;

namespace Trainer.Repository;

public interface ITrainerRepository
{
    IEnumerable<TrainerEntity> ObtemListaDeTreinadores();
    Task<TrainerEntity> InserirTreinador(TrainerEntity trainer);
}