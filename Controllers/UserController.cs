using DependencyInjectionExample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    //Parameterized constructor for dependency injection
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public IActionResult GetUserName()
    {
        string userName = _userService.GetUserName();
        return Ok(userName);
    }
}
