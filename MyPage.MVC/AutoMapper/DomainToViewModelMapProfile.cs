using AutoMapper;
using MyPage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPage.MVC.AutoMapper
{
    public class DomainToViewModelMapProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Event, ViewModels.ViewModelEvent>();
            CreateMap<Location, ViewModels.ViewModelLocation>();
            CreateMap<EventLocation, ViewModels.ViewModelEventLocation>();

        }
    }
}