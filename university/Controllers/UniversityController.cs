using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace university.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UniversityController : ControllerBase
    {
        // GET: api/<UniversityController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "u1", "u2" };
        }

        
    }
}
