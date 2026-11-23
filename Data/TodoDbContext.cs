using Microsoft.EntityFrameworkCore;

namespace TodoMVC_CSharp.Data
{
    public class TodoDbContext(DbContextOptions<TodoDbContext>options): DbContext(options)
    {
        public DbSet<Models.Todo> Todos => Set<Models.Todo>();
    }
    
} 
