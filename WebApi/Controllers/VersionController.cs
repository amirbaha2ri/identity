using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class VersionController : ControllerBase
{
    [HttpGet(Name = "Version")]
    [Authorize]
    public string Get()
    {
        return "0.0.1";
    }
}