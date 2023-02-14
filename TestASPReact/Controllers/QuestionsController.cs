using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestASPReact.Models;

namespace TestASPReact.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionsController : ControllerBase
    {

        private readonly ILogger<QuestionsController> _logger;

        public QuestionsController(ILogger<QuestionsController> logger)
        {
            _logger = logger;
        }

        [HttpGet, Route("getAll/")]
        public IActionResult GetAll()
        {
            var questions = "ssssssssssss";
            return Ok(questions);
        }
    }
}