using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Data;
using ConstructionCompany.Models;
using System.Windows;

namespace ConstructionCompany.ViewModels
{
    class CustomersViewModel : ViewModelFilter
    {
        public static readonly DependencyProperty FilterTextProperty =
           DependencyProperty.Register("FilterText", typeof(string), typeof(CustomersViewModel), new PropertyMetadata("", FilterText_Changed));

        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        private static void FilterText_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as CustomersViewModel;
            if (current != null)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterCustomer;
            }
        }
        public new ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public static readonly new DependencyProperty ItemsProperty =
           DependencyProperty.Register("Items", typeof(ICollectionView), typeof(CustomersViewModel), new PropertyMetadata(null));
        public CustomersViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(DataModel.Customers);
            Items.Filter = FilterCustomer;
        }
        private bool FilterCustomer(object obj)
        {
            bool result = true;
            Customer customer = (obj as Customer);
            if (!string.IsNullOrWhiteSpace(FilterText)
                && customer != null
                && !customer.LastName.ToLower().Contains(FilterText.ToLower())
                && !customer.FirstName.ToLower().Contains(FilterText.ToLower())
                && !customer.Patronymic.ToLower().Contains(FilterText.ToLower())
                && !customer.Phone.ToString().ToLower().Contains(FilterText.ToLower())
                && !customer.Email.ToLower().Contains(FilterText.ToLower()))
            {
                result = false;
            }
            return result;
        }
    }
}
