using Microsoft.AspNetCore.Mvc;
using BlazorPWA.Shared;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SkillsController : Controller
    {
        [HttpGet]
        public IEnumerable<Skills> Get()
        {
            var values = new List<Skills>
            {
                new Skills
                { 
                    Title = "BackEnd", 
                    Values =  "C#, .Net Core, Python, Java"
                },
                new Skills
                { 
                    Title = "FrontEnd", 
                    Values = "Javascript, Vue.js, HTML5, CSS3, Blazor"  
                },
                new Skills
                { 
                    Title = "Unit Tests", 
                    Values ="XUnit, NUnit, PyTest", 
                },
                new Skills
                { 
                    Title = "Database", 
                    Values ="SQL Server, MongoDB, PostgreSQL" 
                },
                new Skills
                { 
                    Title = "Padrões Essenciais", 
                    Values ="Princípios SOLID, Padrões de Projeto, Programação Orientada a Objeto, Gerenciamento de Equipes/Projetos, Reuniões Diárias, Planejamento/Revisão do Sprint" 
                },
            };
            return values;
        }

    }
}

