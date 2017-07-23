using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfMVVMApp.ViewModel;

namespace WpfMVVMApp.ViewModel
{
    public class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public RelayCommand() : this((x) =>
        {
            try
            {
                if (x is RoutedViewResult)
                {
                    RoutedViewResult result = (RoutedViewResult)x;
                    Type modeltype = x.GetType();
                    var results = result.RoutedValues.Where(w => w.Value.GetType() == modeltype).Select(s => s.Key).ToList();
                    foreach (var item in results)
                    {
                        if (result.RoutedValues[item] is IBaseViewModel)
                        {
                            IBaseViewModel collection = ((IBaseViewModel)result.RoutedValues[item]);

                            if (collection != null)
                            {
                                collection.ReplyCommand.Execute(x);
                            }
                        }
                        else
                        {
                            var reply = result.RoutedValues[item].GetType().GetProperties().OfType<RelayCommand>();

                            if (reply.Any())
                            {
                                reply.Single().Execute(x);
                            }
                            else
                            {
                                result.RoutedValues[item] = x;
                            }

                        }
                    }
                }
            }
            catch
            {

            }

        })
        {

        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                try
                {
                    CommandManager.RequerySuggested += value;
                }
                catch
                {

                }

            }
            remove
            {
                try
                {
                    CommandManager.RequerySuggested -= value;
                }
                catch
                {
                }
            }
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
