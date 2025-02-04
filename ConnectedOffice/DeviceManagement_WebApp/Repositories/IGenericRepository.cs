﻿using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace DeviceManagement_WebApp.Repositories
{
    //This is a generic Repo to get code less 
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }

}
