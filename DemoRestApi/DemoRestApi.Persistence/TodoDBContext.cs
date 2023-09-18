using System;
using DemoRestApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoRestApi.Persistence
{
	public class TodoDBContext: DbContext
	{
		public DbSet<Todo> todo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost,1433; Database=MyTodoDb; User=sa; Password=tSDIN-TD_12556;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

}

