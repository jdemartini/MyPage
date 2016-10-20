using MyPage.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MyPage.Data.EntityConfig
{
    public class EventLocationConfiguration : EntityTypeConfiguration<EventLocation>
    {
        public EventLocationConfiguration()
        {
            HasKey(el => el.EventLocationId);

            Property(el => el.ScheduleTime)
                .IsRequired();

            Property(el => el.Description)
                .IsOptional()
                .HasMaxLength(1000);

           /* HasRequired(el => el.Event)
                .WithRequiredPrincipal();
            HasRequired(el => el.Location)
                .WithRequiredPrincipal();*/
                
        }
    }
}
