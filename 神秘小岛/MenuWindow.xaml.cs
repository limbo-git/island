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
    /// MenuWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            
        }
        public MenuWindow(WindowGame temp)
        {
            InitializeComponent();
            this.Owner = temp;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            this.Owner.Owner.Show();
            this.Close();
            this.Owner.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
    }
}
