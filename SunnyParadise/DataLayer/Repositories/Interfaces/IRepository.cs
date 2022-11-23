﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.Interfaces
{
    internal interface IRepository<TEntity>
        where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(int id);
        Task Add(TEntity entity);
        void Update(int id, TEntity entity);
        Task Delete(int id);
        Task Save();
    }
}
