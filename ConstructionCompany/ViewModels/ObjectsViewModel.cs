using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Data;
using ConstructionCompany.Models;
using System.Windows;
using ConstructionCompany.ViewModels;

namespace ConstructionCompany.ViewModels
{
    class ObjectsViewModel : ViewModelFilter
    {
        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(string), typeof(ObjectsViewModel), new PropertyMetadata("", FilterText_Changed));

        private static void FilterText_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as ObjectsViewModel;
            if (current != null)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterObject;
            }
        }

        public new ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public static readonly new DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(ObjectsViewModel), new PropertyMetadata(null));

        public ObjectsViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(DataModel.Objects);
            Items.Filter = FilterObject;
        }
        private bool FilterObject(object obj)
        {
            bool result = true;
            Models.Object @object = (obj as Models.Object);
            if (!string.IsNullOrWhiteSpace(FilterText)
                && @object != null && !@object.Address.ToLower().Contains(FilterText.ToLower())
                && !@object.Area.ToString().ToLower().Contains(FilterText.ToLower())
                && !@object.ObjectTypeName.ToString().ToLower().Contains(FilterText.ToLower())
                && !@object.CustomerName.ToString().ToLower().Contains(FilterText.ToLower()))
            {
                result = false;
            }
            return result;
        }
    }
}
