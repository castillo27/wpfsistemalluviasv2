﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Protell.ViewModel;

namespace Protell.UI
{
    /// <summary>
    /// Lógica de interacción para SistemaAddView.xaml
    /// </summary>
    public partial class SistemaAddView : Window
    {
        public SistemaAddView()
        {
            InitializeComponent();
            this.DataContext = new SistemaAddViewModel();
        }

        private SistemaAddViewModel GetViewModel()
        {
            return this.DataContext as SistemaAddViewModel;
        }

        private void btGuardar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
