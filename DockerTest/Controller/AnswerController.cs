using Microsoft.AspNetCore.Mvc;

namespace DockerTest.Controller;

public class AnswerController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}