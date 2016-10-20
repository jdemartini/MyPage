using MyPage.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MyPage.Data.EntityConfig
{
    public class EventConfiguration : EntityTypeConfiguration<Event>
    {
        public EventConfiguration()
        {
            HasKey(e => e.EventId);

            Property(e => e.EventPlace)
                .IsRequired()
                .HasMaxLength(150);
            
            Property(e => e.EventDate)
                .IsRequired();
            
            Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(150);
         }
    }
}
