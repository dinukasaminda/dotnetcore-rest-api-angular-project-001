using System;
using DemoRestApi.Models;

namespace DemoRestApi.Services.Authors
{
	public interface IAuthorRepository
	{
        public List<Author> GetAllAuthors();
        public Author GetAuthor(int id);
    }
}

