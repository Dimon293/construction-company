using System.Windows;
using System.ComponentModel;
using System.Windows.Data;
using ConstructionCompany.Models;

namespace ConstructionCompany.ViewModels
{
    class OrdersViewModel : ViewModelFilter
    {
        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(string), typeof(OrdersViewModel), new PropertyMetadata("", FilterText_Changed));

        private static void FilterText_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var cur = d as OrdersViewModel;
            if (cur != null)
            {
                cur.Items.Filter = null;
                cur.Items.Filter = cur.FilterOrder;
            }
        }

        public new ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public static readonly new DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(OrdersViewModel), new PropertyMetadata(null));

        public OrdersViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(DataModel.Orders);
            Items.Filter = FilterOrder;
        }
        private bool FilterOrder(object obj)
        {
            bool result = true;
            Order order = (obj as Order);
            if (!string.IsNullOrWhiteSpace(FilterText)
                && order != null
                && !order.ObjectAddress.ToLower().Contains(FilterText.ToLower())
                && !order.StartDate.ToLower().Contains(FilterText.ToLower())
                && !order.EndDate.ToLower().Contains(FilterText.ToLower())
                && !order.Price.ToString().ToLower().Contains(FilterText.ToLower())
                && !order.Note.ToLower().Contains(FilterText.ToLower()))
            {
                result = false;
            }
            return result;
        }
    }
}
