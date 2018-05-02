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

namespace WpfStyleTest
{
    /// <summary>
    /// AnimationWindow3.xaml 的交互逻辑
    /// </summary>
    public partial class AnimationWindow3 : Window
    {
        public AnimationWindow3()
        {
            InitializeComponent();
        }

        private void BtnArc_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text = "";
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            textblock.Text = "Download";
        }

    }
}
