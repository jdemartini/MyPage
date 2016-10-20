using MyPage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPage.Domain.Interfaces
{
    public interface IEventLocationRepository : IRepositoryBase<EventLocation>
    {
        IEnumerable<EventLocation> FindByLocation(double lat, double lon);
    }
}
