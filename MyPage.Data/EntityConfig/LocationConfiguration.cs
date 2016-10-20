
using MyPage.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace MyPage.Data.EntityConfig
{
    public class LocationConfiguration : EntityTypeConfiguration<Location>
    {
        public LocationConfiguration()
        {
            HasKey(l => l.LocationId);

            Property(l => l.Lat)
                .IsRequired();
            Property(l => l.Lon)
                .IsRequired();
            Property(l => l.Name)
                .IsRequired()
                .HasMaxLength(150);
            
        }
    }
}
