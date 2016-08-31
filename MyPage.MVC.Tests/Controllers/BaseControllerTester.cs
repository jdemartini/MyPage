using MyPage.Domain.Entities;
using MyPage.MVC.Controllers;
using MyPage.MVC.ViewModels;

namespace MyPage.MVC.Tests.Controllers
{
    public abstract class BaseControllerTester<ViewModel, EntityModel>
        where ViewModel : class, IViewModel
        where EntityModel : class, IEntity
    {
        internal BaseController<ViewModel, EntityModel> controller;

        public BaseControllerTester(BaseController<ViewModel, EntityModel> controller)
        {
            this.controller = controller;
        }
    }
}
