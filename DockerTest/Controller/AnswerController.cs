using Microsoft.AspNetCore.Mvc;

namespace DockerTest.Controller;

public class AnswerController : ControllerBase
{
    private readonly ApplicationDbContext _applicationDbContext;

    public AnswerController(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    [HttpPost("submit-answer")]
    public async Task Register([FromBody] string answer)
    {
         _applicationDbContext.Answers.Add(new Answer { UserAnswer = answer });
        await _applicationDbContext.SaveChangesAsync();
    }
}