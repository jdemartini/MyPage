using MyPage.MVC.Controllers;

namespace MyPage.MVC.Tests.Controllers
{
    public abstract class BaseControllerTester
    {
        internal BaseController controller;

        public BaseControllerTester(BaseController controller)
        {
            this.controller = controller;
        }
    }
}
