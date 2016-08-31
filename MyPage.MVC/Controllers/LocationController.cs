using MyPage.Data.Repositories;
using MyPage.Domain.Entities;
using MyPage.MVC.ViewModels;
using System.Web.Mvc;

namespace MyPage.MVC.Controllers
{
    public class LocationController : BaseController<ViewModelLocation, Location>
    {
        public LocationController(RepositoryBase<Location> repo)
            : base(repo)
        {
        }
    }
}
