using BlogSharpDataAccessLayer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogSharpWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {

        IBlogPostDao _blogPostDao;

        public BlogPostController(IBlogPostDao blogPostDao) => _blogPostDao = blogPostDao;



        // GET: api/<BlogPostController>
        [HttpGet]
        //TODO: we need to convert from model to DTO 😊
        public IEnumerable<BlogPostDto> Get() => _blogPostDao.GetAll();

        // GET api/<BlogPostController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BlogPostController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BlogPostController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BlogPostController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
