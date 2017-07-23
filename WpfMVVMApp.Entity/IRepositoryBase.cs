using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{
    public partial interface IRepositoryBase<T>
    {
        object[] IdentifyPrimaryKey(T entity);
    }
}
