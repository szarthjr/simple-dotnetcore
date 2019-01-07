using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace devops_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        

        [HttpGet]
        [Route("throw")]
        public IActionResult ThrowTest([FromQuery]bool force=true){
            try{
                if(force)
                    throw new Exception(message:"Erro esperado");
                return Ok();
            }catch (Exception e){
                return BadRequest(e);
            }
        }

        [HttpGet]
        [Route("error")]
        public IActionResult ErrorTest([FromQuery]int divided=0){
            try{
                return Ok(1/divided);
            }catch (Exception e){
                return BadRequest(e);
            }
        }



    }
}
