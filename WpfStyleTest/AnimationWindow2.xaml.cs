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
using System.Windows.Media.Animation;

namespace WpfStyleTest
{
    /// <summary>
    /// AnimationWindow2.xaml 的交互逻辑
    /// </summary>
    public partial class AnimationWindow2 : Window
    {
        public AnimationWindow2()
        {
            InitializeComponent();
        }

        private void Storyboard_CurrentTimeInvalidated(object sender, EventArgs e)
        {
            Clock clock = (Clock)sender;
            if (clock.CurrentProgress == null)
            {
                textBlock.Text = "[[stop]]";
                progressBar.Value = 0;
            }
            else
            {
                textBlock.Text = clock.CurrentTime.ToString();
                progressBar.Value = (((Double)clock.CurrentProgress)/10)*100;
            }
        }
    }
}
