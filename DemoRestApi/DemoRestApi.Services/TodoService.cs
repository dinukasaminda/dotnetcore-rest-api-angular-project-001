using System;
using DemoRestApi.Models;

namespace DemoRestApi.Services
{
	public class TodoService : ITodoRepository
	{
		public TodoService()
		{
            System.Console.WriteLine("Starting new Instance of TodoService");
		}
        public List<Todo> AllTodos() {
            var todos = new List<Todo>();
            Todo todo1 = new Todo {
                Id = 1,
                Title = "Get books for school",
                Description = "Get some text books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };
            todos.Add(todo1);

            todos.Add(new Todo {
                Id = 2,
                Title = "Collect letters",
                Description = "sample 2",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.Inprogress
            });
            todos.Add(new Todo {
                Id = 3,
                Title = "Go to Supermarket",
                Description = "get some vegitables",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.New
            });
            return todos;
        }
    }
}

