using AutoMapper;
using MyPage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPage.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Models.Event, Event>();
            CreateMap<Models.Location, Location>();
            CreateMap<Models.EventLocation, EventLocation>();
        }
    }
}