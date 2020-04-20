using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SchedulerMeeting.Api.Data;
using SchedulerMeeting.Api.Models;
using SchedulerMeeting.Api.Services.Repositories.Contracts;

namespace SchedulerMeeting.Api.Services.Repositories.Concrete
{
    public class SchedulingRepository : RepositoryBase<Scheduling>, ISchedulingRepository
    {
        /// <summary>
        /// Valor que define o tempo de uma reunião.
        /// O ideal, seria um local de parametrização da soluçao, porém, resolvi deixá-lo aqui
        /// </summary>
        private int intervalMeetingInMinutes = 60;

        public SchedulingRepository(SchedulerMeetingContext ctx)
            : base(ctx)
        {
        }

        public Scheduling FindWithRoom(Guid id)
        {
            return Context.Set<Scheduling>()
                .Include(entity => entity.Room)
                .Where(wr => wr.SchedulingId.Equals(id))
                .FirstOrDefault();
                
        }

        /// <summary>
        /// Obtem uma lista de horários de um determinado dia ( ocupado e nao ocupado ) para uma room específica
        /// </summary>
        /// <param name="day"></param>
        /// <param name="meetingRoom"></param>
        /// <returns></returns>
        public IEnumerable<Scheduling> GetAvailbleTimesByDayAndRoom(DateTime day, MeetingRoom meetingRoom)
        {
            // Nessa momento eu assumo que o horario útil varia de 8 as 18;
            var initialDate = new DateTime(day.Year, day.Month, day.Day, 8, 0, 0);
            var finalDate = new DateTime(day.Year, day.Month, day.Day, 18, 0, 0);

            var hoursUnavailbe = Context.Schedulings.Include(l => l.Room)
                .Where(wr => (wr.SchedulingStart > initialDate || wr.SchedulingEnd < finalDate) && wr.Room.MeetingRoomId == meetingRoom.MeetingRoomId)
                .ToList();

            var result = new List<Scheduling>();
            while(initialDate < finalDate)
            {
                var test = hoursUnavailbe.Find(w => w.SchedulingStart <= initialDate && w.SchedulingEnd > initialDate);
                if(test == null)
                {
                    result.Add(new Scheduling
                    {
                        SchedulingStart = initialDate,
                        SchedulingEnd = initialDate.AddMinutes(intervalMeetingInMinutes)
                    });
                }
                else
                {
                    result.Add(test);
                }
                initialDate = initialDate.AddMinutes(intervalMeetingInMinutes);
            }

            return result;
            
        }
    }
}
