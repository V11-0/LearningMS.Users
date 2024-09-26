using Microsoft.AspNetCore.Mvc;

namespace LearningMS.Users.Controller;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase {

    [HttpGet]
    public ActionResult<string> GetSomething() {
        return Ok("A____<3");
    }
}