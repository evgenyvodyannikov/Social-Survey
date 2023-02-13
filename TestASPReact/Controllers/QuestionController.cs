using Microsoft.AspNetCore.Mvc;
using TestASPReact.Models;

namespace TestASPReact.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionController : ControllerBase
    {

        private readonly ILogger<QuestionController> _logger;

        public QuestionController(ILogger<QuestionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Question> Get()
        {
            Variant[] Variants = new Variant[1];
            
            return Enumerable.Range(1, 5).Select(index => new Question
            {
                Id = "0",
                Title = "Test",
                Variants = Variants
            })
            .ToArray();
        }
    }
}