using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfMVVMApp.Entity;

namespace WpfMVVMApp.ViewModel
{
    public class LoginViewModel : BaseViewModelWithPOCOClass<Users>
    {
        //private StartUpWindowController _controller = null;

        public LoginViewModel()
        {
            ////_controller = controller;
        }

        public static readonly DependencyProperty UserNameProperty = DependencyProperty.Register("UserName", typeof(string), typeof(LoginViewModel), new PropertyMetadata(string.Empty));

        /// <summary>
        /// 登入帳號
        /// </summary>
        public string UserName { get { return CopyofPOCOInstance.UserName; } set { CopyofPOCOInstance.UserName = value; RaisePropertyChanged("UserName"); } }

        public static readonly DependencyProperty PasswordProperty = DependencyProperty.Register("Password", typeof(string), typeof(LoginViewModel), new PropertyMetadata(string.Empty));

        private string _Password = string.Empty;
        /// <summary>
        /// 登入密碼
        /// </summary>
        public string Password { get { return _Password; } set { CopyofPOCOInstance.Membership.Password = value; RaisePropertyChanged("Password"); } }

        public UserViewModel Login()
        {
            var reult = QuerySingle<UserViewModel,Users>("StartUpWindow", "Login", UserName, Password);

            if (!reult.HasError)
            {
                            
                return reult;
            }
            else
            {
                return new UserViewModel()
                {
                    Errors = reult.Errors,
                    HasError = reult.HasError
                };
            }

        }
    }
}
