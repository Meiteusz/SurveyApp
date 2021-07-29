using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class SurveyAppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Occurrence> Occurrences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString.Connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //User
            modelBuilder.Entity<User>().Property(u => u.Name).HasMaxLength(70).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.UserType).HasMaxLength(70).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Cpf).HasMaxLength(14).IsRequired();
            modelBuilder.Entity<User>().HasIndex(u => u.Cpf).IsUnique();
            modelBuilder.Entity<User>().Property(u => u.Login).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<User>().HasIndex(u => u.Login).IsUnique();
            modelBuilder.Entity<User>().Property(u => u.Email).HasMaxLength(250).IsRequired();
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<User>().Property(u => u.Password).HasMaxLength(80).IsRequired();

            //Survey
            modelBuilder.Entity<Survey>().Property(s => s.Status).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Survey>().Property(s => s.OpeningDate).IsRequired();
            modelBuilder.Entity<Survey>().Property(s => s.Local).IsRequired();
            modelBuilder.Entity<Survey>().Property(s => s.Description).HasMaxLength(250);
            modelBuilder.Entity<Survey>().Property(s => s.Adress).HasMaxLength(250).IsRequired();

            //Occurrence
            modelBuilder.Entity<Occurrence>().Property(o => o.Type).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Occurrence>().Property(o => o.Date).IsRequired();
            modelBuilder.Entity<Occurrence>().Property(o => o.Description).HasMaxLength(250);
        }
    }
}
