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
    /// ProgressWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ProgressWindow : Window
    {
        public ProgressWindow()
        {
            InitializeComponent();
        }

        private void BtnArc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void CountdownStoryboardA_Completed(object sender, EventArgs e)
        {
            TextBlock.RenderTransformOrigin = new Point(.5, .5);
        }

        private void CountdownStoryboardB_Completed(object sender, EventArgs e)
        {
            TextBlock.RenderTransformOrigin = new Point(.5, 1);

            //this.CountdownStoryboardA.Begin();
            //this.CountdownStoryboardB.Begin();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //this.CountdownStoryboardA.Begin();
            //this.CountdownStoryboardB.Begin();
        }
    }
}
