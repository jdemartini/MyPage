﻿using MyPage.Data.Repositories;
using MyPage.Domain.Entities;
using MyPage.MVC.ViewModels;
using System.Web.Mvc;

namespace MyPage.MVC.Controllers
{
    public class EventController : BaseController<ViewModelEvent, Event>
    {
        public EventController(RepositoryBase<Event> repo) : base(repo)
        {
        }
    }
}
