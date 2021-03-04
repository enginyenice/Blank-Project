//Created By Engin Yenice
//enginyenice2626@gmail.com

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        TEntity Get(Expression<Func<TEntity, bool>> filter = null);

        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
    }
}