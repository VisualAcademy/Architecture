using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public DatabaseService(DbContextOptions<DatabaseService> options)
            : base(options) => Database.EnsureCreated();

        public DbSet<Todo> Todos { get; set; } = null!;

        public void Save() => this.SaveChanges();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Todo>().HasData(
                new Todo { Id = 1, Name = "Domain", IsComplete = true },
                new Todo { Id = 2, Name = "Application", IsComplete = true },
                new Todo { Id = 3, Name = "Persistence", IsComplete = true });
        }
    }
}
