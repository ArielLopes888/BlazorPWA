using BlazorPWA.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorPWA.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExperienceController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {""};

        private readonly ILogger<ExperienceController> _logger;

        public ExperienceController(ILogger<ExperienceController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Shared.Experience> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Experience
            {
                Company = "",
                Description = "",
                EndDate = DateTime.Today,
                Position = "",
                StartDate = DateTime.Today,
                
            })
            .ToArray();
        }
    }
}