using Microsoft.AspNetCore.Mvc;
using Trainer.Models;

namespace Trainer.Controllers;

[ApiController]
[Route("[controller]")]
public class TrainerController : ControllerBase
{
    private readonly ITrainerApplication _trainerApplication;

    public TrainerController(ITrainerApplication trainerApplication)
    {
        _trainerApplication = trainerApplication;
    }

    [HttpGet]
    public IActionResult ObterTreinadores()
    {
        return Ok(_trainerApplication.ObtemTreinadores());
    }

    [HttpPost]
    public async Task<IActionResult> InserirTreinador(InsertTrainerModel trainerModel)
    {
        return Ok(await _trainerApplication.InsertTrainer(trainerModel));
    }
}
