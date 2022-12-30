using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Todos
{
    public class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name).IsRequired().HasMaxLength(25);

            builder.HasData(
                new Todo { Id = 1, Name = "Domain", IsComplete = true },
                new Todo { Id = 2, Name = "Application", IsComplete = true },
                new Todo { Id = 3, Name = "Persistence", IsComplete = true });
        }
    }
}
