using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using DemoRestApi.Models;
using DemoRestApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoRestApi.Controllers
{
    [Route("api/[controller]")]
    public class TodosController : Controller
    {
        private TodoService _todoService;

        public TodosController() {
            _todoService = new TodoService();
        }
        
        // GET: api/values
        [HttpGet()]
        public IActionResult GetTodos([FromQuery(Name ="id")] int? id) {

            var myTodos = new List<Todo>();
            if (id is not null) {
                myTodos = _todoService.AllTodos().Where(t => t.Id == id).ToList();

            } else {
                myTodos = _todoService.AllTodos();
            }
            return Ok(myTodos);
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

