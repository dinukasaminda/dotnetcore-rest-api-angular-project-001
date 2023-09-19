using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using DemoRestApi.Services.Todos;
using Microsoft.AspNetCore.Mvc;


namespace DemoRestApi.Controllers
{
    [Route("api/todos")]
    public class TodosController : Controller
    {
        private readonly ITodoRepository _todoRepository;

        public TodosController(ITodoRepository repository) {
            _todoRepository = repository;
        }
        
        // GET: api/values
        [HttpGet()]
        public IActionResult GetTodos([FromQuery(Name ="id")] int? id) {

            var myTodos = _todoRepository.AllTodos();
            var myTodos2 = _todoRepository.AllTodos();

            if (id is not null) {
               return Ok(myTodos.Where(t => t.Id == id).ToList());
            } else {
                return Ok(myTodos);
            }
           
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        
    }
}

