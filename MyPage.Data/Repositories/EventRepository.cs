﻿using MyPage.Domain.Entities;
using MyPage.Domain.Interfaces;

namespace MyPage.Data.Repositories
{
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
    }
}
