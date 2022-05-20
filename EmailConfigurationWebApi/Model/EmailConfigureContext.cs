using Microsoft.EntityFrameworkCore;

namespace EmailConfigurationWebApi.Model
{
    public class EmailConfigureContext : DbContext
    {
        public EmailConfigureContext(DbContextOptions<EmailConfigureContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<EmailConfigure> EmailConfigures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder
                .Entity<EmailConfigure>()
                .Property(p => p.ProviderType)
                .HasConversion(
                    v => v.ToString(),
                    v => (ProviderType)Enum.Parse(typeof(ProviderType), v));

            // modelBuilder.Entity<EmailConfigure>()
            //.Property(u => u.ProviderType)
            //.HasConversion<string>()
            //.HasMaxLength(10);

        }
    }
}
