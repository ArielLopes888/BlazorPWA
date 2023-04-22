using Microsoft.AspNetCore.Mvc;
using BlazorPWA.Shared;

namespace Server.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Project> Get()
    {
        var values = new List<Project>
        {
            new Project
            {
                Name = "API",
                Description="RESTAPI"
            },
            new Project
            {
                Name="Teste",
                Description="Teste"
            },
            new Project
            {
                Name="SGCPN",
                Description="Teste",
            }
        };
        return values;
    }

}
