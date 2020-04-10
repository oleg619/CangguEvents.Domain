﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CangguEvents.Domain.Models;

namespace CangguEvents.Domain.Repositories
{
    public interface IEventsRepository
    {
        Task<List<EventInfo>> GetAllEvents(CancellationToken cancellationToken = default);
        Task<List<EventInfo>> GetEvents(DayOfWeek dayOfWeek, CancellationToken cancellationToken = default);
        Task<EventInfo> GetEvent(int id, CancellationToken cancellationToken = default);
        Task AddEvent(EventInfo eventInfo, CancellationToken cancellationToken = default);
    }
}