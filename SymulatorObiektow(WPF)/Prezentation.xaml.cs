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

namespace SymulatorObiektow_WPF_
{
    /// <summary>
    /// Interaction logic for Prezentation.xaml
    /// </summary>
    public partial class Prezentation : Window
    {
        public Prezentation()
        {
            InitializeComponent();
        }

        private void onclose(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
        }
    }
}
