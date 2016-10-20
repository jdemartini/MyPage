using MyPage.Data.EntityConfig;
using MyPage.Domain.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MyPage.Data
{
    public class MyPageContext : DbContext
    {
        public MyPageContext()
            : base("MyPage")
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<EventLocation> EventsLocations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(1000));

            modelBuilder.Configurations.Add(new EventConfiguration());
            modelBuilder.Configurations.Add(new LocationConfiguration());
            modelBuilder.Configurations.Add(new EventLocationConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity.GetType().GetProperty("RegDate") != null)
                {
                    if (entry.State == EntityState.Added)
                        entry.Property("RegDate").CurrentValue = DateTime.UtcNow;

                    if (entry.State == EntityState.Modified)
                        entry.Property("RegDate").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
