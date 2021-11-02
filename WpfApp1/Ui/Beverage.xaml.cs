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
using WpfApp1.Database;

namespace WpfApp1.Ui
{
    /// <summary>
    /// Interaction logic for Beverage.xaml
    /// </summary>
    public partial class Beverage : Page
    {
        public Beverage()
        {
            InitializeComponent();
            loadlist();
        }
        private void loadlist()
        {
            DatabaseRepository foodtitem = new DatabaseRepository();

            burgerlist.ItemsSource = foodtitem.Items.Where(a => a.Category == "Beverage").ToList();

        }
    }
}
