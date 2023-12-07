﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace MultiTextBoxName
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = DataAccessLayer.LoadCustomer().FirstOrDefault();
        }
    }
}
