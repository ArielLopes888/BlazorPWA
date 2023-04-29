using Microsoft.AspNetCore.Mvc;
using BlazorPWA.Shared;

namespace Server.Controllers;

[ApiController]
[Route("[controller]")]
public class SkillController : Controller
{
    [HttpGet]
    public IEnumerable<Skill> Get()
    {
        var values = new List<Skill>
            {
                new Skill
                {
                    Title = "BackEnd",
                    Values =  "C#, .Net Core, Python, Java"
                },
                new Skill
                {
                    Title = "FrontEnd",
                    Values = "Javascript, Vue.js, HTML5, CSS3, Blazor"
                },
                new Skill
                {
                    Title = "Unit Tests",
                    Values ="XUnit, NUnit, PyTest",
                },
                new Skill
                {
                    Title = "Database",
                    Values ="SQL Server, MongoDB, PostgreSQL"
                }
            };
        return values;
    }

}


