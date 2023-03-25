using Trainer.Models;

namespace Trainer;

public interface ITrainerApplication
{
    public IEnumerable<GetTrainerModel> ObtemTreinadores();
    public Task<bool> InsertTrainer(InsertTrainerModel trainer);
}