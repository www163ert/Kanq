﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.IDAL
{
    public interface IBaseDal<T> where T : class, new()
    {
        IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda);

        IQueryable<T> LoadPageEntities<s>(int pageIndex, int pageSize, out int pageTotal, Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderbyLamdba, bool isAsc = true);

        bool EditEntity(T entity);

        bool DeleteEntity(T entity);

        T AddEntity(T entity);

        int GetMaxId(string fieldName, string tableName);
    }
}
