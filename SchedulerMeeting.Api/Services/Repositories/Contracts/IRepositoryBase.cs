using System;
using System.Collections;
using System.Collections.Generic;

namespace SchedulerMeeting.Api.Services.Repositories.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        public void Add(T entity);
        public void Remove(T entity);
        public void Update(T entity);

        public IEnumerable<T> FindAll();
        public T Find(object id);
    }
}
