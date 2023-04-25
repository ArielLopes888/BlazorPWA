using Microsoft.AspNetCore.Mvc;
using BlazorPWA.Shared;

namespace xx.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class ExperienceController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Experience> Get()
    {
        var experiences = new List<Experience>
        {
            new Experience
            {
                Position = "BackEnd C# .NET",
                Company = "Mercado Eletrônico",
                Description = "Criação de REST APIs para implementar funcionalidades em Aplicações Web de uso interno e externo; "+
                "Manutenções evolutivas e corretivas em API's; Identificação e correções de bugs; "+
                "Implementação de novos recursos e manutenção de Aplicações Web MVC; "+
                "Realização de testes unitários com Nunit. Manutenção em Microsserviços em Java, com RabbitMQ e Kafka; "+
                "Manutenção em Front com Vue.js, Html e Css.",
                StartDate= new DateTime(2022,06,01),
                EndDate = new DateTime(2023,03,16)
            },
            new Experience
            {
                Position = "Assistente de Informática",
                Company = "Microlins",
                Description = "Acompanhar e monitorar as turmas de informática básica/avançada, para crianças, adolescentes e adultos; "+
                "Avaliar os alunos, preparar materiais e planejar as  aulas; "+
                "Implementar e realizar a manutenção de software e hardware; "+
                 "Orientar e ensinar, em média 15 alunos por turma;"+
                 "Realizar a manutenção de rede.",
                 StartDate= new DateTime(2016,11,01),
                 EndDate= new DateTime(2017,05,31)
            },
            new Experience
            {
                Position = "Instrutor de Informática",
                Company = "Gomes Informática",
                Description = "Avaliar os alunos, preparar materiais e planejar as aulas; "+
                "Implementar e realizar a manutenção de software e hardware; "+
                "Ministrar aulas de informática básica/avançada, para crianças, adolescentes e adultos; "+
                "Realizar a manutenção de rede; "+
                "Orientar e ensinar, em média 20 alunos por turma.",
                StartDate= new DateTime(2011,07,01),
                EndDate= new DateTime(203,06,01)
                
            }
        };
       return experiences;
    }

}
