using MyPage.Data.Repositories;
using MyPage.Domain.Entities;
using MyPage.MVC.ViewModels;
using System.Web.Mvc;

namespace MyPage.MVC.Controllers
{
    public class EventLocationController : BaseController<ViewModelEventLocation, EventLocation>
    {
        public EventLocationController(RepositoryBase<EventLocation> repo)
            : base(repo)
        {
        }
    }
}
