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
using ConstructionCompany.ViewModels;

namespace ConstructionCompany
{
    /// <summary>
    /// Логика взаимодействия для OrderBrigade.xaml
    /// </summary>
    public partial class OrderBrigadeW : Window
    {
        public OrderBrigadeW()
        {
            InitializeComponent();
            Loaded += OrderBrigadeW_Loaded;
        }

        private void OrderBrigadeW_Loaded(object sender, RoutedEventArgs e)
        {
            BrigadesViewModel bvm = new BrigadesViewModel();
            BrigadeLeftDG.DataContext = bvm;
        }

        private void AddBrigade_Click(object sender, RoutedEventArgs e)
        {
            //Добавление бригады в коллекцию бригады заказа
            (this.DataContext as Order).BrigadesCollection.Add(BrigadeInOrderDG.SelectedItem as Brigade);

            //Добавление заказа в коллекцию заказов бригад
            (BrigadeInOrderDG.SelectedItem as Brigade).OrdersCollection.Add(this.DataContext as Order);

            //Добавление связи заказ-бригада
            DataModel.OrderBrigades.Add(new OrderBrigade(DataModel.OrderBrigades.Count, (int)(this.DataContext as Order).Id, (int)(BrigadeInOrderDG.SelectedItem as Brigade).Id));
        }

        private void DelBrigade_Click(object sender, RoutedEventArgs e)
        {
            //Удаление заказа из коллекции заказов бригады
            (BrigadeLeftDG.SelectedItem as Brigade).OrdersCollection.Remove(this.DataContext as Order);

            //Удаление связи заказ-бригада
            DataModel.OrderBrigades.Remove(GetBrigadesInOrder((int)(this.DataContext as Order).Id, (int)(BrigadeLeftDG.SelectedItem as Brigade).Id));

            //Удаление бригады из коллекции работ бригады
            (this.DataContext as Order).BrigadesCollection.Remove(BrigadeLeftDG.SelectedItem as Brigade);
        }

        private OrderBrigade GetBrigadesInOrder(int idOrder, int idBrigade)
        {
            foreach (OrderBrigade ob in DataModel.OrderBrigades)
            {
                if (ob.IdOrder == idOrder && ob.IdBrigade == idBrigade)
                    return ob;
            }
            return null;
        }
    }
}
