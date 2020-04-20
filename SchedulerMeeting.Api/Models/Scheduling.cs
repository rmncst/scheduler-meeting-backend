using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SchedulerMeeting.Api.Models
{
    public class Scheduling
    {
        public Scheduling()
        {
            SchedulingId = Guid.NewGuid();
        }

        [Key]
        public Guid SchedulingId { get; set; }
        public DateTime SchedulingStart { get; set; }
        public DateTime SchedulingEnd { get; set; }
        [NotNull]
        public MeetingRoom Room { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Observation { get; set; }
    }
}
