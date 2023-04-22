using Microsoft.AspNetCore.Mvc;
using BlazorPWA.Shared;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EducationController : Controller
    {
        [HttpGet]
        public IEnumerable<Education> Get()
        {
            var values = new List<Education>
            {
                new Education
                {
                  University = "Centro Universitário Celso Lisboa",
                  Course = "Análise e Desenvolvimento de Sistemas"
                },

                new Education
                {
                  University = "Digital House",
                  Course = "Desenvolvedor Full Stack C# .Net"
                },

                new Education
                {
                  University = "Udemy",
                  Course = "Api Robusta + Deploy no Azure"
                },
            };
            return values;
        }

    }
}