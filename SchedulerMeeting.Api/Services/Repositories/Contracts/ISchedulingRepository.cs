using System;
using System.Collections.Generic;
using SchedulerMeeting.Api.Models;

namespace SchedulerMeeting.Api.Services.Repositories.Contracts
{
    public interface ISchedulingRepository : IRepositoryBase<Scheduling>
    {
        public IEnumerable<Scheduling> GetAvailbleTimesByDayAndRoom(DateTime day, MeetingRoom meetingRoom);
        public Scheduling FindWithRoom(Guid id);
    }
}
