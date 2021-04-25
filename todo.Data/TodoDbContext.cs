using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using todo.Data.Models;

namespace todo.Data
{
    public class TodoDbContext : IdentityDbContext
    {
        public TodoDbContext()
        {

        }

        public TodoDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Project>  Projects { get; set; }
    }
}

