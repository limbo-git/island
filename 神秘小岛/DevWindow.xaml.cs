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
using System.Windows.Shapes;

namespace 神秘小岛
{
    /// <summary>
    /// DevWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DevWindow : Window
    {
        public DevWindow()
        {
            InitializeComponent();
        }

        public DevWindow(MainWindow temp)
        {
            InitializeComponent();
            this.Owner = temp;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }
        private void DevWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
