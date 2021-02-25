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
    class WorksViewModel : ViewModelFilter
    {
        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(string), typeof(WorksViewModel), new PropertyMetadata("", FilterText_Changed));

        private static void FilterText_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as WorksViewModel;
            if (current != null)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterWork;
            }
        }

        public new ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public static readonly new DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(WorksViewModel), new PropertyMetadata(null));

        public WorksViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(DataModel.Works);
            Items.Filter = FilterWork;
        }
        private bool FilterWork(object obj)
        {
            bool result = true;
            Work work = (obj as Work);
            if (!string.IsNullOrWhiteSpace(FilterText)
                && work != null && !work.WorkTypeName.ToLower().Contains(FilterText.ToLower())
                && !work.WorkName.ToLower().Contains(FilterText.ToLower())
                && !work.Tariff.ToString().ToLower().Contains(FilterText.ToLower()))
            {
                result = false;
            }
            return result;
        }
    }
}
