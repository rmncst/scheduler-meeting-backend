using System;
using SchedulerMeeting.Api.Data;
using SchedulerMeeting.Api.Models;
using SchedulerMeeting.Api.Services.Repositories.Contracts;

namespace SchedulerMeeting.Api.Services.Repositories.Concrete
{
    public class MeetingRoomRepository : RepositoryBase<MeetingRoom>, IMeetingRoomRepository
    {
        public MeetingRoomRepository(SchedulerMeetingContext ctx)
            : base(ctx)
        {
        }
    }
}
