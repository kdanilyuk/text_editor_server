using Microsoft.EntityFrameworkCore;

namespace textedb.Models
{
    public class DocumentContext : DbContext
    {
        public DocumentContext()
        {
        }

        public DocumentContext(DbContextOptions<DocumentContext> options)
            : base(options)
        {
        }

        public DbSet<Document> Documents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=documentdb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Text).IsRequired();
            });
        }
    }
}
