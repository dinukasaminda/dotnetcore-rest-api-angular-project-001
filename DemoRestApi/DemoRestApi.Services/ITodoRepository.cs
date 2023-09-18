using System;
using DemoRestApi.Models;

namespace DemoRestApi.Services
{
	public interface ITodoRepository {
		public List<Todo> AllTodos();
	}
}

