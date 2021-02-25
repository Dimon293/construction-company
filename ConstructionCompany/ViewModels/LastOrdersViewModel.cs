using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionCompany.Models;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Collections.Specialized;

namespace ConstructionCompany.ViewModels
{
    class LastOrdersViewModel : ViewModelFilter
    {
       static int Count { get; set; }
        
        public new ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public static readonly new DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(LastOrdersViewModel), new PropertyMetadata(null, Items_Changed));

        private static void Items_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

            Count = -1;
            var current = d as LastOrdersViewModel;
            if (current != null)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.LimitOrders;
            }
        }
        
        public LastOrdersViewModel()
        {
            DataModel.Orders.CollectionChanged += Orders_CollectionChanged;
            Count = -1;
            Items = CollectionViewSource.GetDefaultView(DataModel.Orders.OrderBy(x=>x.StartDate).Reverse());
            Items.Filter = LimitOrders;
        }

        private void Orders_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.Items = CollectionViewSource.GetDefaultView(DataModel.Orders.OrderBy(x => x.StartDate).Reverse());
                    break;
            }
        }

        bool LimitOrders(object obj)
        {
            bool result = false;  
           
            if (Count <= 20)
            {
                result = true;
                Count++;
            }
            return result;
        }

    }
}
