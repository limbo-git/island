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
    /// WindowGame.xaml 的交互逻辑
    /// </summary>
    public partial class WindowGame : Window
    {
        public WindowGame()
        {
            InitializeComponent();
        }
        public WindowGame(MainWindow temp)
        {
            InitializeComponent();
            this.Owner = temp;
        }
        private void Esc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {

                MenuWindow menu = new MenuWindow(this);
                menu.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
                menu.ShowDialog();
            }
        }
    }
}
