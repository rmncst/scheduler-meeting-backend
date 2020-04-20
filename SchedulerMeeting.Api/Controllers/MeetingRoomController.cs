using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SchedulerMeeting.Api.Data;
using SchedulerMeeting.Api.Models;
using SchedulerMeeting.Api.Services.Repositories.Contracts;

namespace SchedulerMeeting.Api.Controllers
{
    [ApiController]
    [Route("api/meeting-room")]
    public class MeetingRoomController : ControllerBase
    {
        private readonly IMeetingRoomRepository Repository;

        public MeetingRoomController(IMeetingRoomRepository repo)
        {
            Repository = repo;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<MeetingRoom> GetAll()
        {
            return Repository.FindAll();
        }

        [HttpGet]
        [Route("{id}")]
        public MeetingRoom Get(string id)
        {
            return Repository.Find(new Guid(id));
        }

        [HttpPost]
        [Route("")]
        public MeetingRoom Save(MeetingRoom data)
        {
            Repository.Add(data);
            return data;
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(MeetingRoom data, string id)
        {
            var entity = Repository.Find(id);
            if (entity == null)
            {
                return NotFound();
            }
            entity.Description = data.Description;
            entity.Active = data.Active;
            entity.Local = data.Local;

            Repository.Update(entity);
            return new JsonResult(entity);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Remove(string id)
        {
            var entity = Repository.Find(id);
            if (entity == null)
            {
                return NotFound();
            }


            Repository.Remove(entity);
            return new JsonResult(entity);
        }
    }
}
