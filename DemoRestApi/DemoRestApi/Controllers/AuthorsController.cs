using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoRestApi.Services.Authors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoRestApi.Controllers
{
    [Route("api/authors")]
    public class AuthorsController : Controller
    {

        private readonly IAuthorRepository _authorRepository;

        public AuthorsController(IAuthorRepository repository) {
            _authorRepository = repository;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = _authorRepository.GetAllAuthors();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id) {
            var author = _authorRepository.GetAuthor(id);
            return Ok(author);
        }


    }
}

