using System;
using System.Collections.Generic;
using SchedulerMeeting.Api.Data;
using SchedulerMeeting.Api.Services.Repositories.Contracts;

namespace SchedulerMeeting.Api.Services.Repositories.Concrete
{
    public class RepositoryBase<T> : IRepositoryBase<T>
        where T : class
    {
        protected readonly SchedulerMeetingContext Context;

        public RepositoryBase(SchedulerMeetingContext ctx)
        {
            Context = ctx;
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
        }

        public T Find(object id)
        {
            return Context.Set<T>().Find(id);
        }

        public IEnumerable<T> FindAll()
        {
            return Context.Set<T>();
        }

        public void Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
        }

        public void Update(T entity)
        {
            Context.Set<T>().Update(entity);
            Context.SaveChanges();
        }
    }
}
