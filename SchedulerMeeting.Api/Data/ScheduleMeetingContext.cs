using System;
using Microsoft.EntityFrameworkCore;
using SchedulerMeeting.Api.Models;

namespace SchedulerMeeting.Api.Data
{
    public class SchedulerMeetingContext : DbContext 
    {
        public SchedulerMeetingContext(DbContextOptions opts)
            : base(opts)
        {

        }

        public DbSet<MeetingRoom> MeetingRooms { get; set; }
        public DbSet<Scheduling> Schedulings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MeetingRoom>()
               .HasData(
               new MeetingRoom
               {
                   Description = "Meeting Room 1",
                   Local = "Alameda dos Anjos",
                   Active = true
               }, new MeetingRoom
               {
                   Description = "Meeting Room 2",
                   Local = "Gotam City",
                   Active = true
               }, new MeetingRoom
               {
                   Description = "Meeting Room 1",
                   Local = "Konoha",
                   Active = true
               });
        }
    }
}
