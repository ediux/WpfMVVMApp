﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using WpfMVVMApp.ViewModel;

namespace WpfMVVMApp.ViewModel
{
    public class RoutedViewResult : DependencyObject
    {
        public RoutedViewResult()
        {
            RoutedValues = new Dictionary<string, object>();
            RoutingBinding = new Dictionary<string, string>();
   
        }



        public string DisplayText
        {
            get { return (string)GetValue(DisplayTextProperty); }
            set { SetValue(DisplayTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DisplayText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisplayTextProperty =
            DependencyProperty.Register("DisplayText", typeof(string), typeof(RoutedViewResult), new PropertyMetadata(string.Empty));


        //public string DisplayText { get; set; }
        //public string FormatedDisplay { get; set; }


        public string FormatedDisplay
        {
            get { return (string)GetValue(FormatedDisplayProperty); }
            set { SetValue(FormatedDisplayProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FormatedDisplay.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FormatedDisplayProperty =
            DependencyProperty.Register("FormatedDisplay", typeof(string), typeof(RoutedViewResult), new PropertyMetadata(string.Empty));



        public object[] FormatedParameters
        {
            get { return (object[])GetValue(FormatedParametersProperty); }
            set { SetValue(FormatedParametersProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FormatedParameters.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FormatedParametersProperty =
            DependencyProperty.Register("FormatedParameters", typeof(object[]), typeof(RoutedViewResult), new PropertyMetadata(null));



        public Type ViewType { get; set; }

        public object SourceInstance { get; set; }

        /// <summary>
        /// 資料來源繫結
        /// </summary>
        public object DataContent
        {
            get { return (object)GetValue(DataContentProperty); }
            set { SetValue(DataContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DataContent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DataContentProperty =
            DependencyProperty.Register("DataContent", typeof(object), typeof(RoutedViewResult), new PropertyMetadata(null));


        //public Dictionary<string, object> RoutedValues { get; set; }
        //public string AttachedTargetElementName { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> RoutingBinding
        {
            get { return (Dictionary<string, string>)GetValue(RoutingBindingProperty); }
            set { SetValue(RoutingBindingProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RoutingBindingProperty =
            DependencyProperty.Register("RoutingBinding", typeof(Dictionary<string, string>), typeof(RoutedViewResult), new PropertyMetadata(default(Dictionary<string, Binding>)));




        public Dictionary<string, object> RoutedValues
        {
            get { return (Dictionary<string, object>)GetValue(RoutedValuesProperty); }
            set { SetValue(RoutedValuesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RoutedValues.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RoutedValuesProperty =
            DependencyProperty.Register("RoutedValues", typeof(Dictionary<string, object>), typeof(RoutedViewResult), new PropertyMetadata(default(Dictionary<string, object>)));


        public string AttachedTargetElementName
        {
            get { return (string)GetValue(AttachedTargetElementNameProperty); }
            set { SetValue(AttachedTargetElementNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AttachedTargetElementName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AttachedTargetElementNameProperty =
            DependencyProperty.Register("AttachedTargetElementName", typeof(string), typeof(RoutedViewResult), new PropertyMetadata(string.Empty));



    }
}
