﻿using System;
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
using ControlzEx.Standard;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace WpfStyleTest
{
    /// <summary>
    /// MetroTestWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MetroTestWindow : MetroWindow
    {
        public MetroTestWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.ShowModalLoginExternal("This is the title", "Some message");
            this.ShowInputAsync("This is the title", "Some message");
        }
    }
}
