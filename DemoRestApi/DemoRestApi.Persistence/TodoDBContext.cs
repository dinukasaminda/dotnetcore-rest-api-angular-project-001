using System;
using DemoRestApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoRestApi.Persistence {
    public class TodoDBContext : DbContext {
        public DbSet<Todo> todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            var connectionString = "Server=localhost,1433; Database=MyTodoDb; User=sa; Password=tSDIN-TD_12556;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Author>().HasData(new Author[]{
                new Author{
                    Id = 1,
                    FullName = "Dinuka Bandara",
                },
                 new Author{
                    Id = 2,
                    FullName = "Isanka",
                },
                 new Author{
                    Id = 3,
                    FullName = "Dilshan",
                },
                  new Author{
                    Id = 4,
                    FullName = "M Rajapaksha",
                }
            });

            modelBuilder.Entity<Todo>().HasData(new Todo []{
                new Todo{
                    Id = 1,
                    Title = "Collect letters",
                    Description = "sample 2",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(2),
                    Status = TodoStatus.Inprogress,
                    AuthorId = 1
                },
                new Todo{
                    Id = 2,
                    Title = "Need some vegitables",
                    Description = "Go to suppermarket and get some vegitables",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(1),
                    Status = TodoStatus.New,
                    AuthorId = 1
                },
                new Todo{
                    Id = 3,
                    Title = "Go to GYM",
                    Description = "Weekly Gym",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(3),
                    Status = TodoStatus.New,
                    AuthorId = 2
                },
                new Todo{
                    Id = 4,
                    Title = "Upwork Profile update",
                    Description = "Profile photo update",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.Inprogress,
                    AuthorId = 3
                },
            });
        }
    }
}

