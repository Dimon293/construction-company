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
    class MaterialsViewModel : ViewModelFilter
    {
        public static readonly DependencyProperty FilterTextProperty =
           DependencyProperty.Register("FilterText", typeof(string), typeof(MaterialsViewModel), new PropertyMetadata("", FilterText_Changed));

        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        private static void FilterText_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as MaterialsViewModel;
            if (current != null)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterMaterial;
            }
        }
        public new ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public static readonly new DependencyProperty ItemsProperty =
           DependencyProperty.Register("Items", typeof(ICollectionView), typeof(MaterialsViewModel), new PropertyMetadata(null));
        public MaterialsViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(DataModel.Materials);
            Items.Filter = FilterMaterial;
        }
        private bool FilterMaterial(object obj)
        {
            bool result = true;
            Material material = (obj as Material);
            if (!string.IsNullOrWhiteSpace(FilterText)
                && material != null
                && !material.Name.ToLower().Contains(FilterText.ToLower())
                && !material.UnitOfMeasurement.ToLower().Contains(FilterText.ToLower())
                && !material.Area.ToString().ToLower().Contains(FilterText.ToLower())
                && !material.Price.ToString().ToLower().Contains(FilterText.ToLower()))
            {
                result = false;
            }
            return result;
        }
    }
}
