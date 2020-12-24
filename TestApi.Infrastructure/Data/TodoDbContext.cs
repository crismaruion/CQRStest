using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using TestApi.Core.Domain;

namespace TestApi.Infrastructure.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext()
        {

        }

        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        public DbSet<TodoEntity> ToDos { get; set; }
    }
}
