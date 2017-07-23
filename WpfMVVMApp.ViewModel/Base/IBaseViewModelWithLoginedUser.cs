using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVVMApp.ViewModel
{
    public interface IBaseViewModelWithLoginedUser : IBaseViewModel
    {
        UserViewModel LoginedUser { get; set; }
    }
}
