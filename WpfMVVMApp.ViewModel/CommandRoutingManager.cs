using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfMVVMApp.ViewModel
{
    /// <summary>
    /// Mvvm路由管理器
    /// </summary>
    public class CommandRoutingManager : DependencyObject, ICommandSource
    {
        public static void Redirect(UIElement source, object routevalue)
        {
            if (routevalue is RoutedViewResult)
            {
                if (_Mapping.ContainsKey(source))
                {
                    if (_Mapping[source].SourceInstance is Window)
                    {
                        if (_Mapping[source].ViewType.BaseType == typeof(Window))
                        {
                            Window _win = (Window)Activator.CreateInstance(_Mapping[source].ViewType);
                            if (_Mapping[source].RoutedValues.ContainsKey("IsDialog"))
                            {
                                if ((bool)_Mapping[source].RoutedValues["IsDialog"])
                                {
                                    _win.ShowDialog();
                                }
                                else
                                {
                                    _win.Show();
                                }
                            }
                            return;
                        }
                    }

                    if (_Mapping[source].SourceInstance is UserControl)
                    {
                        if (_Mapping[source].ViewType.BaseType == typeof(Window))
                        {
                            Window _win = (Window)Activator.CreateInstance(_Mapping[source].ViewType);
                            if (_Mapping[source].RoutedValues.ContainsKey("IsDialog"))
                            {
                                if ((bool)_Mapping[source].RoutedValues["IsDialog"])
                                {
                                    _win.ShowDialog();
                                }
                                else
                                {
                                    _win.Show();
                                }
                            }
                            return;
                        }

                        if (_Mapping[source].SourceInstance is TabControl)
                        {
                            TabControl control = (TabControl)_Mapping[source].SourceInstance;

                            if (control != null)
                            {
                                TabItem addWorkarea = null;

                                string Header = string.Empty;

                                if (!string.IsNullOrEmpty(_Mapping[source].DisplayText))
                                    Header = _Mapping[source].DisplayText;
                                else
                                    Header = string.Format(_Mapping[source].FormatedDisplay, _Mapping[source].FormatedParameters);

                                object SharedModel = _Mapping[source].DataContent;

                                addWorkarea = new TabItem() { Header = Header };

                                bool isExisted = false;

                                foreach (TabItem item in control.Items.OfType<TabItem>())
                                {
                                    if (item.Header.Equals(addWorkarea.Header))
                                    {
                                        isExisted = true;
                                        addWorkarea = item;
                                        break;
                                    }
                                }

                                if (!isExisted)
                                {

                                    var vm = Activator.CreateInstance(_Mapping[source].ViewType);

                                    if (vm != null)
                                    {
                                        var modellist = _Mapping[source].RoutedValues.OfType<IBaseViewModel>().ToList();

                                        foreach (var model in modellist)
                                        {
                                            model.ReplyCommand.Execute(_Mapping[source].DataContent);
                                        }
                                    }

                                    addWorkarea = new TabItem() { Header = Header };
                                    addWorkarea.Content = vm;
                                    addWorkarea.Margin = new Thickness(0);

                                    control.Items.Add(addWorkarea);
                                    control.SelectedItem = addWorkarea;


                                    return;
                                }
                                else
                                {
                                    control.SelectedItem = addWorkarea;
                                }

                            }
                        }

                    }

                    if (_Mapping[source].SourceInstance is Page)
                    {
                        if (_Mapping[source].RoutedValues.ContainsKey("View"))
                        {
                            Uri xamlurl = new Uri((string)_Mapping[source].RoutedValues["View"], UriKind.Relative);
                            System.Windows.Navigation.NavigationService.GetNavigationService(source).Navigate(xamlurl, _Mapping[source].DataContent);
                        }
                    }

                }
            }

        }

        private static Dictionary<UIElement, RoutedViewResult> _Mapping;

        public CommandRoutingManager()
        {
            if (_Mapping == null)
                _Mapping = new Dictionary<UIElement, RoutedViewResult>();
        }

        #region Command
        public static ICommand GetCommand(DependencyObject obj)
        {
            try
            {
                return (ICommand)obj.GetValue(CommandProperty);
            }
            catch
            {
                return null;
            }

        }

        public static void SetCommand(DependencyObject obj, ICommand value)
        {
            try
            {
                obj.SetValue(CommandProperty, value);
            }
            catch
            {
            }

        }

        // Using a DependencyProperty as the backing store for Command.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.RegisterAttached("Command", typeof(ICommand), typeof(CommandRoutingManager),
                new PropertyMetadata(null, new PropertyChangedCallback(CommandChange)));

        private static void CommandChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                if (_Mapping == null)
                    _Mapping = new Dictionary<UIElement, RoutedViewResult>();

                if (d is UIElement)
                {
                   

                    var p = ((UIElement)d).GetType().GetProperty("Command");

                    if (p != null)
                    {
                        if (e.OldValue != null)
                        {
                            p.SetValue(d, null);
                        }

                        if (e.NewValue != null)
                        {
                            p.SetValue(d, e.NewValue);
                        }
                        return;
                    }

                }

                if (d is Control)
                {
                    Control c = (Control)d;

                    c.MouseDoubleClick += Button_MouseDoubleClick;

                }

                //ICommand cmd = GetCommand(d);

                //EventHandler handler = CanExecuteChanged;

                //if (e.OldValue != null)
                //{
                //    ((ICommand)e.OldValue).CanExecuteChanged -= handler;
                //}

                //((ICommand)e.NewValue).CanExecuteChanged += handler;


            }
            catch
            {


            }
        }

        private static void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            GetCommand((DependencyObject)sender).Execute(GetCommandParameter((DependencyObject)sender));
        }

        private static void CanExecuteChanged(object sender, EventArgs e)
        {
            try
            {

                if (sender == null)
                    return;

                Type t = sender.GetType();
                var depobject = (DependencyObject)sender;
                ICommand command = GetCommand(depobject);
                var prop = t.GetProperty("IsEnabled");
                if (command != null)
                {

                    // If a RoutedCommand.
                    if (command != null)
                    {
                        if (command.CanExecute(GetCommandParameter(depobject)))
                        {
                            if (prop != null)
                            {
                                prop.SetValue(sender, true);
                            }

                        }
                        else
                        {
                            if (prop != null)
                            {
                                prop.SetValue(sender, false);
                            }
                        }
                    }
                    // If a not RoutedCommand.
                    else
                    {
                        if (command.CanExecute(GetCommandParameter(depobject)))
                        {
                            if (prop != null)
                            {
                                prop.SetValue(sender, true);
                            }

                        }
                        else
                        {
                            if (prop != null)
                            {
                                prop.SetValue(sender, false);
                            }
                        }
                    }
                }
            }
            catch
            {

            }

        }



        #endregion

        #region Command Parameter
        public static object GetCommandParameter(DependencyObject obj)
        {
            try
            {
                return obj.GetValue(CommandParameterProperty);
            }
            catch
            {

                return null;
            }

        }

        public static void SetCommandParameter(DependencyObject obj, object value)
        {
            obj.SetValue(CommandParameterProperty, value);
        }
        // Using a DependencyProperty as the backing store for CommandParameter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommandParameterProperty =
            DependencyProperty.RegisterAttached("CommandParameter", typeof(object), typeof(CommandRoutingManager),
                new PropertyMetadata(null, new PropertyChangedCallback(ParameterChange)));

        private static void ParameterChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                if (_Mapping == null)
                    _Mapping = new Dictionary<UIElement, RoutedViewResult>();

                if (d is UIElement)
                {

                    if (e.NewValue is RoutedViewResult)
                    {
                        RoutedViewResult routeitem = (RoutedViewResult)e.NewValue;

                        if (routeitem.SourceInstance == null)
                            routeitem.SourceInstance = d;

                        if (!_Mapping.ContainsKey((UIElement)routeitem.SourceInstance))
                        {
                            _Mapping.Add((UIElement)routeitem.SourceInstance, routeitem);
                        }

                    }

                    var cmdp = ((UIElement)d).GetType().GetProperty("CommandParameter");

                    if (cmdp == null)
                    {
                        cmdp.SetValue(d, e.NewValue);
                    }

                    //var p = ((UIElement)d).GetType().GetProperty("CommandParameter");

                    //if (p != null)
                    //{
                    //    if (e.OldValue != null)
                    //    {
                    //        p.SetValue(d, null);
                    //    }

                    //    if (e.NewValue != null)
                    //    {
                    //        p.SetValue(d, e.NewValue);
                    //    }
                    //    return;
                    //}
                }


            }
            catch
            {

            }
        }

        #endregion

        #region Command Target
        public static IInputElement GetCommandTarget(DependencyObject obj)
        {
            try
            {
                return (IInputElement)obj.GetValue(CommandTargetProperty);
            }
            catch
            {
                return null;
            }

        }

        public static void SetCommandTarget(DependencyObject obj, IInputElement value)
        {
            try
            {
                obj.SetValue(CommandTargetProperty, value);
            }
            catch
            {


            }

        }

        // Using a DependencyProperty as the backing store for CommandTarget.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommandTargetProperty =
            DependencyProperty.RegisterAttached("CommandTarget", typeof(IInputElement), typeof(CommandRoutingManager),
                new PropertyMetadata(null, new PropertyChangedCallback(TargetChange)));


        private static void TargetChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                if (d is UIElement)
                {
                    var p = ((UIElement)d).GetType().GetProperty("CommandTarget");

                    if (p != null)
                    {
                        if (e.OldValue != null)
                        {
                            p.SetValue(d, null);
                        }

                        if (e.NewValue != null)
                        {
                            p.SetValue(d, e.NewValue);
                        }
                        return;
                    }

                }
            }
            catch
            {


            }



        }

        #endregion

        public ICommand Command => (ICommand)GetValue(CommandProperty);

        public object CommandParameter => GetValue(CommandParameterProperty);

        public IInputElement CommandTarget => throw new NotImplementedException();

    }
}
