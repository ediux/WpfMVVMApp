﻿using System.ComponentModel;
using System.Windows;

namespace WpfMVVMApp.ViewModel
{
    public class DocumentStatusViewModel : DependencyObject, INotifyPropertyChanged
    {
        /// <summary>
        /// 指出目前是否處於初始化狀態
        /// </summary>
        public bool IsNewInstance
        {
            get { return (bool)GetValue(IsNewInstanceProperty); }
            set { SetValue(IsNewInstanceProperty, value); RaisePropertyChanged("IsNewInstance"); }
        }

        // Using a DependencyProperty as the backing store for IsNewInstance.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsNewInstanceProperty =
            DependencyProperty.Register("IsNewInstance", typeof(bool), typeof(DocumentStatusViewModel));


        public static readonly DependencyProperty IsModifyProperty = DependencyProperty.Register("IsModify", typeof(bool), typeof(DocumentStatusViewModel));
        /// <summary>
        /// 指出是否已經修改
        /// </summary>
        public bool IsModify
        {
            get { return (bool)GetValue(IsModifyProperty); }
            set { SetValue(IsModifyProperty, value); RaisePropertyChanged("IsModify"); }
        }

        public static readonly DependencyProperty IsSavedProperty = DependencyProperty.Register("IsSaved", typeof(bool), typeof(DocumentStatusViewModel));

        /// <summary>
        /// 是否已存檔?
        /// </summary>
        public bool IsSaved
        {
            get { return (bool)GetValue(IsSavedProperty); }
            set
            {
                SetValue(IsSavedProperty, value);
                RaisePropertyChanged("IsSaved");
            }
        }

        #region PropertyChanged 事件
        /// <summary>
        /// 屬性變更事件。
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 引發屬性變更事件。
        /// </summary>
        /// <param name="PropertyName">發生變更的屬性名稱。</param>
        protected void RaisePropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        #endregion
    }
}
