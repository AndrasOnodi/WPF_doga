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

namespace WPF_doga.Pages
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Oldal : UserControl
    {
        public string Title { get { return (string)GetValue(TitleProperty); } set { SetValue(TitleProperty, value); } }
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(Oldal));
        public string Kind { get { return (string)GetValue(KindProperty); } set { SetValue(KindProperty, value); } }
        public static readonly DependencyProperty KindProperty = DependencyProperty.Register("Kind", typeof(string), typeof(Oldal));
    }
    public Oldal()
    {
        InitializeComponent();
        this.DataContext = this;
    }
}
