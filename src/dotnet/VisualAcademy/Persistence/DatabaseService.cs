using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public DatabaseService(DbContextOptions<DatabaseService> options) 
            : base(options)
        { 
        
        }

        public DbSet<Todo> Todos { get; set; } = null!;

        public void Save()
        {
            this.SaveChanges(); 
        }
    }
}
