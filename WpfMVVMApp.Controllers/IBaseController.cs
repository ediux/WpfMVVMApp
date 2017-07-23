using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WpfMVVMApp.Entity;

namespace WpfMVVMApp.Controllers
{
    public interface IBaseController : IDisposable
    {
        ExecuteResultEntity<Users> GetCurrentLoginUser();
        ExecuteResultEntity<Users> GetUser(string UserName);
        ExecuteResultEntity<Users> Login(string UserName, string pwd);
    }

    public interface IBaseController<T> : IBaseController where T : class
    {
        bool IsExists(Expression<Func<T, bool>> filiter);
        ExecuteResultEntity<T> CreateNew();
        ExecuteResultEntity Add(T entity, bool isLastRecord = true);
        ExecuteResultEntity<ICollection<T>> Query(Expression<Func<T, bool>> filiter);
        ExecuteResultEntity<T> Update(T fromModel, bool isLastRecord = true);
        ExecuteResultEntity<T> Delete(T entity, bool isDeleteRightNow = false);
        ExecuteResultEntity<T> CreateOrUpdate(T entity,bool isLastRecord = true);
    }
}