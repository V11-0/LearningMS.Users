using LearningMS.Users.Service;
using Microsoft.AspNetCore.Mvc;

namespace LearningMS.Users.Controller;

[ApiController]
[Route("[controller]")]
public class CounterController : ControllerBase {

    [HttpPost]
    public ActionResult<int> IncrementCounter([FromServices] ICounterService service) {
        return Ok(service.Increment());
    }
}