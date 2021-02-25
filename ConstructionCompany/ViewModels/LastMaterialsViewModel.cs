using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionCompany.Models;
using System.Windows;
using System.Windows.Data;
using System.Collections.Specialized;
using System.ComponentModel;


namespace ConstructionCompany.ViewModels
{
    class LastMaterialsViewModel : ViewModelFilter
    {
        static int Count { get; set; }

        public new ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public static readonly new DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(LastMaterialsViewModel), new PropertyMetadata(null, Items_Changed));

        private static void Items_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Count = -1;
            var current = d as LastMaterialsViewModel;
            if (current != null)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.LimitMaterials;
            }
        }

        public LastMaterialsViewModel()
        {
            DataModel.MaterialsUsing.CollectionChanged += MaterialsUsing_CollectionChanged;
            Count = -1;
            Items = CollectionViewSource.GetDefaultView(DataModel.MaterialsUsing.OrderBy(x => x.Date).Reverse());
            Items.Filter = LimitMaterials;
            
        }

        private void MaterialsUsing_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.Items = CollectionViewSource.GetDefaultView(DataModel.MaterialsUsing.OrderBy(x => x.Date).Reverse());
                    break;
            }
        }

        bool LimitMaterials(object obj)
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
