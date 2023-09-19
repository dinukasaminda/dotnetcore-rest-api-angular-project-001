using System;
using DemoRestApi.Models;
using DemoRestApi.Persistence;

namespace DemoRestApi.Services.Todos
{
	public class TodoPersistenceService: ITodoRepository
	{
        private readonly TodoDBContext _context = new TodoDBContext();
		public TodoPersistenceService()
		{
		}

       public List<Todo> AllTodos()
        {
            return _context.todos.ToList();
        }
    }
}

