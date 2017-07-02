using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WpfMVVMApp.Entity;

namespace WpfMVVMApp.Controllers
{
    public class BaseController<TPOCO> : IBaseController<TPOCO> where TPOCO : class
    {
        /// <summary>
        /// 統一資料庫連線物件。
        /// </summary>
        protected IUnitOfWork database;

        public BaseController()
        {
            try
            {
                database = RepositoryHelper.GetUnitOfWork();
            }
            catch
            {

            }
        }

        public ExecuteResultEntity Add(TPOCO entity, bool isLastRecord = true)
        {
            throw new NotImplementedException();
        }

        public ExecuteResultEntity<TPOCO> CreateOrUpdate(TPOCO entity)
        {
            throw new NotImplementedException();
        }

        public ExecuteResultEntity Delete(Expression<Func<TPOCO, bool>> condtion)
        {
            throw new NotImplementedException();
        }

        public bool IsExists(Expression<Func<TPOCO, bool>> filiter)
        {
            throw new NotImplementedException();
        }

        public ExecuteResultEntity<ICollection<TPOCO>> Query(Expression<Func<TPOCO, bool>> filiter)
        {
            throw new NotImplementedException();
        }

        public ExecuteResultEntity<TPOCO> Update(TPOCO fromModel, bool isLastRecord = true)
        {
            throw new NotImplementedException();
        }
    }
}
