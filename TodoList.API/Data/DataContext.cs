using TodoListAPI;
using Microsoft.EntityFrameworkCore;

namespace TodoListAPI
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}