using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfMVVMApp.ViewModel
{
    public class BaseViewModel<TPOCO> : DependencyObject, IBaseViewModel<TPOCO> where TPOCO : class
    {
        public IEnumerable<string> Errors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool HasError { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Initialized()
        {
            throw new NotImplementedException();
        }

        public void Query()
        {
            throw new NotImplementedException();
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public void SaveModel()
        {
            throw new NotImplementedException();
        }

        public void SetModel(dynamic entity)
        {
            throw new NotImplementedException();
        }
    }
}
