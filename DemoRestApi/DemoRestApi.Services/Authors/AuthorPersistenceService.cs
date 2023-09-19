using System;
using DemoRestApi.Models;
using DemoRestApi.Persistence;
using DemoRestApi.Services.Todos;

namespace DemoRestApi.Services.Authors {
    public class AuthorPersistenceService : IAuthorRepository {

        private readonly TodoDBContext _context = new TodoDBContext();
        public AuthorPersistenceService() {
        }

       public List<Author> GetAllAuthors() {
            return _context.Authors.ToList();
        }

        public Author GetAuthor(int id)
        {
            return _context.Authors.Find(id);
        }
    }
}

