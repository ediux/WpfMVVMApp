using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WpfMVVMApp.Entity;

namespace WpfMVVMApp.Controllers
{
    public interface IBaseController<TPOCO> where TPOCO : class
    {
        bool IsExists(Expression<Func<TPOCO, bool>> filiter);
        ExecuteResultEntity Add(TPOCO entity, bool isLastRecord = true);
        ExecuteResultEntity<ICollection<TPOCO>> Query(Expression<Func<TPOCO, bool>> filiter);
        ExecuteResultEntity<TPOCO> Update(TPOCO fromModel, bool isLastRecord = true);
        ExecuteResultEntity Delete(Expression<Func<TPOCO, bool>> condtion);
        ExecuteResultEntity<TPOCO> CreateOrUpdate(TPOCO entity);
    }
}
