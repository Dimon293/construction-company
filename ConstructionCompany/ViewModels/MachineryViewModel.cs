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
    class MachineryViewModel : ViewModelFilter
    {
        public static readonly DependencyProperty FilterTextProperty =
           DependencyProperty.Register("FilterText", typeof(string), typeof(MachineryViewModel), new PropertyMetadata("", FilterText_Changed));

        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        private static void FilterText_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as MachineryViewModel;
            if (current != null)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterMachinery;
            }
        }
        public new ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public static readonly new DependencyProperty ItemsProperty =
           DependencyProperty.Register("Items", typeof(ICollectionView), typeof(MachineryViewModel), new PropertyMetadata(null));
        public MachineryViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(DataModel.Machinery);
            Items.Filter = FilterMachinery;
        }
        private bool FilterMachinery(object obj)
        {
            bool result = true;
            Machinery machinery = (obj as Machinery);
            if (!string.IsNullOrWhiteSpace(FilterText)
                && machinery != null
                && !machinery.MachineryTypeName.ToLower().Contains(FilterText.ToLower())
                && !machinery.Name.ToLower().Contains(FilterText.ToLower()))
            {
                result = false;
            }
            return result;
        }
    }
}
