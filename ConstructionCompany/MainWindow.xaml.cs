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
using ConstructionCompany.Models;
using System.ComponentModel;
using ConstructionCompany.ViewModels;

namespace ConstructionCompany
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LastOrdersDG.DataContext = new LastOrdersViewModel();
            LastMaterialsDG.DataContext = new LastMaterialsViewModel();
            ActiveBrigades.DataContext = new ActiveBrigadesViewModel();
        }

        private void Ord_Click(object sender, RoutedEventArgs e)
        {
            OrderW OW = new OrderW();
            OW.Owner = this;
            OW.Show();
        }

        

        private void Brig_Click(object sender, RoutedEventArgs e)
        {
            BrigadeW BW = new BrigadeW();
            BW.Show();
        }

        private void Worker_Click(object sender, RoutedEventArgs e)
        {
            WorkerW WW = new WorkerW();
            WW.Show();
        }

        private void Cust_Click(object sender, RoutedEventArgs e)
        {
            CustomerW CW = new CustomerW();
            CW.Show();
        }

        
        private void Mat_Click(object sender, RoutedEventArgs e)
        {
            MaterialW M = new MaterialW();
            M.Show();
        }
        private void Work_Click(object sender, RoutedEventArgs e)
        {
            WorkW W = new WorkW();
            W.Show();
        }

        private void Obj_Click(object sender, RoutedEventArgs e)
        {
            ObjectW O = new ObjectW();
            O.Show();
        }

        private void Mach_Click(object sender, RoutedEventArgs e)
        {
            MachineryW MW = new MachineryW();
            MW.Show();
        }
        

        private void ViewRule_Click(object sender, RoutedEventArgs e)
        {
            RulesW r = new RulesW();
            r.Show();
        }

        private void AddRule_Click(object sender, RoutedEventArgs e)
        {
            AddRule AR = new AddRule();
            AR.Show();
        }
    }
}
