using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems{get; set;} = null!;
}

// todo context used connection between model and the database server
// db context have a role as a bridge between the model and server db