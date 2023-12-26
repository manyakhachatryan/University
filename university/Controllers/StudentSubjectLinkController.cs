using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace university.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentSubjectLinkController : ControllerBase
    {
        // GET: api/<StudentSubjectLinkController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "ssl1", "ssl2" };
        }

        
    }
}
