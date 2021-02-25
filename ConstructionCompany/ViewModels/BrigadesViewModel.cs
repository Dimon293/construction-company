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
    class BrigadesViewModel : ViewModelFilter
    {
        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(string), typeof(BrigadesViewModel), new PropertyMetadata("", FilterText_Changed));
        private static void FilterText_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var cur = d as BrigadesViewModel;
            if (cur != null)
            {
                cur.Items.Filter = null;
                cur.Items.Filter = cur.FilterBrigade;
            }
        }
        public new ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public static readonly new DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(BrigadesViewModel), new PropertyMetadata(null));
        public BrigadesViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(DataModel.Brigades);
            Items.Filter = FilterBrigade;
        }
        private bool FilterBrigade(object obj)
        {
            bool result = true;
            Brigade brigade = (obj as Brigade);
            if (!string.IsNullOrWhiteSpace(FilterText)
                && brigade != null
                && !brigade.Id.ToString().ToLower().Contains(FilterText.ToLower())
                && !brigade.Name.ToLower().Contains(FilterText.ToLower())
                && !brigade.BrigadierName.ToLower().Contains(FilterText.ToLower())
                && !brigade.WorkName.ToLower().Contains(FilterText.ToLower()))
            {
                result = false;
            }
            return result;
        }
    }
}
