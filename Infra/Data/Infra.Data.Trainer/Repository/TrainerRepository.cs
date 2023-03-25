using Trainer.Entities;

namespace Trainer.Repository;

public class TrainerRepository : ITrainerRepository
{
    private readonly TrainerContext _trainerContext;

    public TrainerRepository(TrainerContext context)
    {
        _trainerContext = context;
    }
    
    public IEnumerable<TrainerEntity> ObtemListaDeTreinadores()
    {
        return _trainerContext.Set<TrainerEntity>().AsQueryable().ToList();
    }

    public async Task<TrainerEntity> InserirTreinador(TrainerEntity trainer)
    {
        var success = _trainerContext.Set<TrainerEntity>().Add(trainer);
        _trainerContext.SaveChanges();
        return success.Entity;
    }
}