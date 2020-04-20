using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SchedulerMeeting.Api.Models;
using SchedulerMeeting.Api.Services.Repositories.Contracts;

namespace SchedulerMeeting.Api.Controllers
{
    [ApiController]
    [Route("api/scheduling")]
    public class SchedulingController : ControllerBase
    {
        private readonly ISchedulingRepository SchedulingRepository;
        private readonly IMeetingRoomRepository MeetingRoomRepository;

        public SchedulingController(ISchedulingRepository repo, IMeetingRoomRepository meetingRepo)
        {
            SchedulingRepository = repo;
            MeetingRoomRepository = meetingRepo;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Scheduling> GetAll(string id)
        {
            return SchedulingRepository.FindAll();
        }

        [HttpGet]
        [Route("{id}")]
        public Scheduling Get(string id)
        {
            return SchedulingRepository.FindWithRoom(new Guid(id));
        }

        [HttpGet]
        [Route("available-in/{date}/{room}")]
        public IEnumerable<Scheduling> GetHourAvailableByDateAndRoom(DateTime date, string room)
        {
            var currentRoom = MeetingRoomRepository.Find(new Guid(room));
            return SchedulingRepository.GetAvailbleTimesByDayAndRoom(date, currentRoom);
        }

        [HttpPost]
        [Route("")]
        public Scheduling Save(Scheduling data)
        {
            data.Room = MeetingRoomRepository.Find(data.Room.MeetingRoomId);
            SchedulingRepository.Add(data);
            return data;
        }

        [HttpPut]
        [Route("{id}")]
        public Scheduling Update(Scheduling data, string id)
        {
            SchedulingRepository.Add(data);
            return data;
        }

        [HttpDelete]
        [Route("{id}")]
        public Scheduling Remove(string id)
        {
            var entity = SchedulingRepository.Find(new Guid(id));
            SchedulingRepository.Remove(entity);
            return entity;
        }
    }
}
