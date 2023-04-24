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
                Name = "Api ShopBridge",
                Description="RESTAPI"
            },
            new Project
            {
                Name="Api Robusta + Deploy no Azure",
                Description="API Curso"
            },
            new Project
            {
                Name="Api Projeto Integrador",
                Description="Teste",
            },
            new Project
            {
                Name="Cadastro de Voluntários da Congregação",
                Description="...",
            },
        };
        return values;
    }

}
