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
                Description="RESTAPI",
                Link="https://github.com/ArielLopes888/API_ShopBridge"
            },
            new Project
            {
                Name="Api Robusta + Deploy no Azure",
                Description="API Curso",
                Link="https://github.com/ArielLopes888/API_ROBUSTA"
            },
            new Project
            {
                Name="Api Projeto Integrador",
                Description="Api Curso",
                Link="https://github.com/ArielLopes888/API.NET-Projeto-Integrador"
            },
            new Project
            {
                Name="Cadastro de Voluntários da Congregação",
                Description="...",
                Link="https://github.com/ArielLopes888/Cadastro-de-Voluntarios-da-Congregacao"
            },
            new Project
            {
                Name="Este Portfólio",
                Description="Blazor",
                Link="https://github.com/ArielLopes888/BlazorPWA"
            },
            new Project
            {
                Name="Python Bot Whatsapp",
                Description="...",
                Link="https://github.com/ArielLopes888/Automacao_Whatsapp_Python"
            },
            new Project
            {
                Name="Automação Análise de Dados ",
                Description="Python",
                Link="https://github.com/ArielLopes888/AnaliseDados_Automacao_Python"
            },
        };
        return values;
    }

}
