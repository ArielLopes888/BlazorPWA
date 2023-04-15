using Microsoft.AspNetCore.Mvc;
using BlazorPWA.Shared;

namespace xx.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class ExperienceController : ControllerBase
{
    private readonly ILogger<ExperienceController> _logger;

    public ExperienceController(ILogger<ExperienceController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Experience> Get()
{
    var experiences = new List<Experience>
    {
        new Experience 
        {
            Position = "BackEnd .NET C#",
            Company = "Mercado Eletrônico",
            Description = "Criação de REST APIs para implementar funcionalidades em Aplicações Web de uso interno e externo.-Manutenções evolutivas e corretivas em API's.-Identificação e correções de bugs-Implementação de novos recursos e manutenção de Aplicações Web MVC -Realização de testes unitários com Nunit.-Manutenção em Microsserviços em Java, com RabbitMQ e Kafka-Manutenção em Front com Vue.js, Html e Css"
        },
        new Experience 
        {
            Position = "FrontEnd",
            Company = "Empresa X",
            Description = "Desenvolvimento de interfaces web responsivas e dinâmicas utilizando ReactJS, HTML e CSS. Integração com API RESTful. Utilização de metodologias ágeis como SCRUM e KANBAN."
        },
        new Experience 
        {
            Position = "Analista de Sistemas",
            Company = "Empresa Y",
            Description = "Análise e desenvolvimento de sistemas web utilizando ASP.NET e C#. Desenvolvimento de rotinas de banco de dados em SQL Server. Elaboração de documentação técnica e suporte aos usuários."
        }
    };

    return experiences;
}

}
