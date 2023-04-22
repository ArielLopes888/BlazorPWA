using Microsoft.AspNetCore.Mvc;
using BlazorPWA.Shared;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AboutMeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<AboutMe> Get()
        {
            var values = new List<AboutMe>
            {
                new AboutMe
                {
                   address = "Aracaju - Sergipe",
                   email = "ariellopes888@gmail.com",
                   phone = "(79) 9 88381834",
                   personalResume="Sou um desenvolvedor Full Stack focado em Web. Curioso, com sede de aprender e autodidata para adquirir conhecimento. Nas horas vagas, costumo trabalhar em projetos voluntários e projetos pessoais." ,
                   professionalResume= "Minhas melhores habilidades estão relacionadas com a plataforma .Net. Também tenho conhecimento e habilidades para trabalhar com Python, Vue.js, JS, Html, CSS e outras linguagens e tecnologias"
                },
                
            };
            return values;
        }
        
    }
}