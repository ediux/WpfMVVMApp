using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVVMApp.ViewModel
{
    public class BaseViewModelCollection<TPOCO> : ObservableCollection<TPOCO>, IBaseViewModelCollection<TPOCO> where TPOCO : class
    {

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            base.OnCollectionChanged(e);
        }
    }
}
