using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controller;

[Route("/")]
public class Controller : ControllerBase
{
    [HttpGet]
    public ActionResult HelloWorld()
    {
        return Ok("Hello, World!");
    }
}
