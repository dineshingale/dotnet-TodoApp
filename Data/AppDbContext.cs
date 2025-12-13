using Microsoft.EntityFrameworkCore;
using MyTodoApp.Models;

namespace MyTodoApp.Data
{
    // This class acts as the bridge between your C# code and the database
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // This represents the table in your database. 
        // Calling this matches the table name "TodoItems".
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}