﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfMVVMApp.ViewModel
{
    public class CreateNewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged.Invoke(parameter, new EventArgs());
            }

            return true;
        }

        public void Execute(object parameter)
        {
            try
            {
                //        if (SelectedProject.Status.IsNewInstance == false)
                //        {
                //            RoutedUICommand command = (RoutedUICommand)TryFindResource("OpenNewTabItem");
                //            RoutedViewResult viewparam = (RoutedViewResult)TryFindResource("OpenNewProjectView");
                //            if (command != null)
                //            {
                //                command.Execute(viewparam, this);
                //            }
                //            //RaiseEvent(new RoutedEventArgs(NewDocumentPageEvent, this));
                //            break;
                //        }

                //        SelectedProject = new ProjectsViewModel();

                //        SelectedProject.Initialized();
                //        SelectedProject.CreateUserId = LoginedUser.UserId;

                //        SelectedProject.Status.IsModify = false;
                //        SelectedProject.Status.IsSaved = false;
                //        SelectedProject.Status.IsNewInstance = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "錯誤", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly);

            }

        }
    }
}
