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
using ConstructionCompany.Models;
using System.ComponentModel;

namespace ConstructionCompany
{
    /// <summary>
    /// Логика взаимодействия для AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button_addcustomer_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
