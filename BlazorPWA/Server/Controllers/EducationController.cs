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
                  Institution = "Centro Universitário Celso Lisboa",
                  Course = "Análise e Desenvolvimento de Sistemas"
                },

                new Education
                {
                  Institution = "Digital House",
                  Course = "Desenvolvedor Full Stack C# .Net"
                },

                new Education
                {
                  Institution = "Udemy",
                  Course = "Api Robusta em .Net + Azure"
                },

                new Education
                {
                  Institution = "Alura",
                  Course ="HTML5 e CSS3"
                },
                new Education
                {
                  Institution = "Alura",
                  Course ="JavaScript e HTML"
                },
            };
            return values;
        }

    }
}