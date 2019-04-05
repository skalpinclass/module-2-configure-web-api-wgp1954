using Microsoft.AspNetCore.Mvc;
using System;

namespace Blog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        /*
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<BlogPost>> Get()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        public void Post([FromBody] BlogPost value)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        public void Put(int id, [FromBody] BlogPost value)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        */
    }
}