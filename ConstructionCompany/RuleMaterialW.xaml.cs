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
using ConstructionCompany.ViewModels;
using ConstructionCompany.Models;
using ConstructionCompany.ExpertPart;

namespace ConstructionCompany
{
    /// <summary>
    /// Логика взаимодействия для OrderWorkW.xaml
    /// </summary>
    public partial class RuleMaterialW : Window
    {
        public RuleMaterialW()
        {
            InitializeComponent();
        }

        private void AddMaterial_Click(object sender, RoutedEventArgs e)
        {
            AddMaterialUsing AMU = new AddMaterialUsing();
            AMU.DataContext = new MaterialUsing();
            AMU.ShowDialog();
            if(AMU.DialogResult ==  true && AMU.DataContext != null)
            {
                FindElement().MaterialCountCollection.Add(new MaterialCount((AMU.DataContext as MaterialUsing).Material, (AMU.DataContext as MaterialUsing).Count));
            }
        }
        // По выбранной бригаде и работе находим bwmc
        BrigadeWithMaterialCount FindElement()
        {
            foreach (BrigadeWithMaterialCount bwmc in (this.DataContext as ExpertMaterialCountViewModel).BrigadeWithMaterialCountCollection)
            {
                Brigade b = (WorksDG.SelectedItem as BrigadeWithMaterialCount).Brigade;
                Work w = (WorksDG.SelectedItem as BrigadeWithMaterialCount).Work;
                if (bwmc.Brigade.Name == b.Name && bwmc.Work.WorkName == w.WorkName)
                {
                    return bwmc;
                }
            }
            return null;
        }

        private void DeleteMaterial_Click(object sender, RoutedEventArgs e)
        {
            FindElement().MaterialCountCollection.Remove(MaterialsCountDG.SelectedItem as MaterialCount);
        }

        private void button_Success_Click(object sender, RoutedEventArgs e)
        {
            int count, brigadeId, materialCount, price;
            string materialName;
            int orderId = (int)(Owner.DataContext as MaterialsInBrigadesByOrderViewModel).Order.Id;

            foreach(BrigadeWithMaterialCount wwmc in (this.DataContext as ExpertMaterialCountViewModel).BrigadeWithMaterialCountCollection)
            {
                foreach (MaterialCount mc in wwmc.MaterialCountCollection)
                {
                    count = DataModel.MaterialsUsing.Count;
                    materialName = mc.MaterialName;
                    brigadeId = (int)wwmc.Brigade.Id;
                    materialCount = mc.Count;
                    price = mc.CountingPrice;

                    if(materialCount != 0)
                        DataModel.MaterialsUsing.Add(new MaterialUsing(count, materialName, orderId, brigadeId, materialCount, DateTime.Now, price));
                }
            }
            this.Close();
            
        }
    }

}
