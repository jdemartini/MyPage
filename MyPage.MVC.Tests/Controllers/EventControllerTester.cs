using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPage.MVC.Controllers;

namespace MyPage.MVC.Tests.Controllers
{
    [TestClass]
    public class EventControllerTester : BaseControllerTester
    {
        public EventControllerTester() : base(new EventController())
        {
        }

        [TestMethod]
        public void TestIndex()
        {
            var view = controller.Index();
        }
    }
}
