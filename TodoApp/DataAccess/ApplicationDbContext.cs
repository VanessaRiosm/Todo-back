using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<User>? Users { get; set; }
        public DbSet<Todo>? Todos { get; set; }

    }
}
