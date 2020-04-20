using System;
namespace SchedulerMeeting.Api.Models
{
    public class MeetingRoom
    {
        public MeetingRoom()
        {
            MeetingRoomId = Guid.NewGuid();
        }

        public Guid MeetingRoomId { get; set; }
        public string Description { get; set; }
        public string Local { get; set; }
        public bool Active { get; set; }
    }
}
