using System;
using DemoRestApi.Models;

namespace DemoRestApi.Services.Todos
{
	public interface ITodoRepository {
		public List<Todo> AllTodos();
	}
}

