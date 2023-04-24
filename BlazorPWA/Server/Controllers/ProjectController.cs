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
                Description="Api Curso",
            },
            new Project
            {
                Name="Cadastro de Voluntários da Congregação",
                Description="...",
            },
            new Project
            {
                Name="Est Portfólio",
                Description="Blazor",
            },
            new Project
            {
                Name="Python Bot Whatsapp",
                Description="...",
            },
            new Project
            {
                Name="Automação Análise de Dados ",
                Description="Python",
            },
        };
        return values;
    }

}
