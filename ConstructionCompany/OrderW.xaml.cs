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
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class OrderW : Window
    {
        public OrderW()
        {
            InitializeComponent();
            Loaded += OrderW_Loaded;

        }

        private void OrderW_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new OrdersViewModel();
        }

        //private void ChangeOrder_Click(object sender, RoutedEventArgs e)
        //{
        //    if (OrderDG.SelectedItem != null)
        //    {
        //        OrderBrigadeW OrderBrigadeWDialog = new OrderBrigadeW();
        //        OrderBrigadeWDialog.DataContext = (OrderDG.SelectedItem as Order);
        //        OrderBrigadeWDialog.Owner = this;
        //        OrderBrigadeWDialog.ShowDialog();
        //    }
        //    else MessageBox.Show("Выберите заказ");
        //}

        private void BuyMaterialOrder_Click(object sender, RoutedEventArgs e)
        {
            if (OrderDG.SelectedItem != null)
            {
                MaterialUsingW MaterialUsingWDialog = new MaterialUsingW();
                MaterialUsingWDialog.DataContext = new MaterialsInBrigadesByOrderViewModel(OrderDG.SelectedItem as Order);
                MaterialUsingWDialog.Owner = this;
                MaterialUsingWDialog.ShowDialog();
            }
            else MessageBox.Show("Выберите заказ");
        }

        private void AddBrigadeWorkOrder_Click(object sender, RoutedEventArgs e)
        {
            if (OrderDG.SelectedItem != null)
            {
                OrderBrigadeWorkW OrderBrigadeWorkWDialog = new OrderBrigadeWorkW();
                OrderBrigadeWorkWDialog.DataContext = new OrderBrigadeWorkViewModel(OrderDG.SelectedItem as Order);
                OrderBrigadeWorkWDialog.Owner = this;
                OrderBrigadeWorkWDialog.ShowDialog();
            }
            else MessageBox.Show("Выберите заказ");
        }

        private void BuyMachineryOrder_Click(object sender, RoutedEventArgs e)
        {
            if (OrderDG.SelectedItem != null)
            {
                MachineryUsingW MachineryUsingWDialog = new MachineryUsingW();
                MachineryUsingWDialog.DataContext = new MachineryInBrigadesByOrderViewModel(OrderDG.SelectedItem as Order);
                MachineryUsingWDialog.Owner = this;
                MachineryUsingWDialog.ShowDialog();
            }
            else MessageBox.Show("Выберите заказ");
        }

        private void AddOrder_Click(object sender, RoutedEventArgs e)
        {
            AddOrder AO = new AddOrder();
            AO.DataContext = new Order();
            AO.Owner = this;
            AO.ShowDialog();
            if (AO.DataContext != null && AO.DialogResult == true)
            {
                DataModel.Orders.Add(AO.DataContext as Order);
            }
        }

        private void EditOrder_Click(object sender, RoutedEventArgs e)
        {
            if (OrderDG.SelectedItem != null)
            {
                AddOrder AO = new AddOrder();
                AO.DataContext = (OrderDG.SelectedItem as Order);
                AO.Owner = this;
                AO.ShowDialog();
            }
            else MessageBox.Show("Выберите заказ для редактирования.");
        }

        private void DeleteOrder_Click(object sender, RoutedEventArgs e)
        {
            if ((OrderDG.SelectedItem as Order) != null)
            {
                foreach (OrderBrigade ob in DataModel.OrderBrigades.ToArray())
                {
                    if (ob.IdOrder == (int)(OrderDG.SelectedItem as Order).Id) DataModel.OrderBrigades.Remove(ob);
                }
                DataModel.Orders.Remove(OrderDG.SelectedItem as Order);
                
                foreach (OrderWork ow in DataModel.OrderWorks.ToArray())
                {
                    if (ow.IdOrder == (int)(OrderDG.SelectedItem as Order).Id) DataModel.OrderWorks.Remove(ow);
                }
                DataModel.Orders.Remove(OrderDG.SelectedItem as Order);

                foreach (MaterialUsing mu in DataModel.MaterialsUsing.ToArray())
                {
                    if (mu.IdOrder == (int)(OrderDG.SelectedItem as Order).Id) DataModel.MaterialsUsing.Remove(mu);
                }
                DataModel.Orders.Remove(OrderDG.SelectedItem as Order);

            }
            else MessageBox.Show("Выберите проект для удаления.");
        }

       
    }
}
