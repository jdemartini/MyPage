using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPage.MVC.Controllers;
using MyPage.Data.Repositories;
using MyPage.MVC.ViewModels;
using MyPage.Domain.Entities;

namespace MyPage.MVC.Tests.Controllers
{
    [TestClass]
    public class EventControllerTester : BaseControllerTester<ViewModelEvent, Event>
    {
        public EventControllerTester() : base(new EventController(new EventRepository()))
        {
        }

        [TestMethod]
        public void TestIndex()
        {
            var view = controller.Index();
        }
    }
}
