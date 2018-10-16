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

namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var n = (Math.Truncate(
                Double.Parse(c_tb.Text) *
                Double.Parse(tc_tb.Text) *
                Math.Log(Double.Parse(r_tb.Text)) /
                Double.Parse(tn_tb.Text)));
            result_n.Text = n.ToString();
            result_l.Text = (Math.Ceiling(Math.Log(n)/ Math.Log(Double.Parse(r_tb.Text)))).ToString();
        }
    }
}
