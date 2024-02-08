using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Calender.UI.Units
{
    public class LoadingAnimation : Control
    {
        static LoadingAnimation()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LoadingAnimation), new FrameworkPropertyMetadata(typeof(LoadingAnimation)));
        }

        public static readonly DependencyProperty IsLoadingProperty =
            DependencyProperty.Register("IsLoading", typeof(bool), typeof(LoadingAnimation),
                new PropertyMetadata(false, OnIsLoadingChanged));

        private static void OnIsLoadingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as LoadingAnimation;
            if (control != null)
            {
                control.Visibility = (bool)e.NewValue ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        public bool IsLoading
        {
            get {  return (bool)GetValue(IsLoadingProperty);}
            set { SetValue(IsLoadingProperty, value);}
        }
    }
}
