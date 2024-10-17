using Microsoft.EntityFrameworkCore;
using TwTodoLis.EntityConfigs;
using TwTodoLis.Models;

namespace TwTodoLis.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos => Set<Todo>();
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("SUA STRING AQUI");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TodoEntityConfig());
        }
    }
}
