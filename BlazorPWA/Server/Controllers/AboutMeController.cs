using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
                   phone = "(79) 9 88381834"
                },
                
            };
            return values;
        }
        
    }
}