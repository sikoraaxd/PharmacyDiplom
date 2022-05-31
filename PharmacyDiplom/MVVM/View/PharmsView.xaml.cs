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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PharmacyDiplom.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для PharmsView.xaml
    /// </summary>
    public partial class PharmsView : UserControl
    {
        public PharmsView()
        {
            InitializeComponent();

            priceSort.Items.Add("Цена: ↑");
            priceSort.Items.Add("Цена: ↓");

            nameSort.Items.Add("Название: А-Я");
            nameSort.Items.Add("Название: Я-А");
        }
    }
}
