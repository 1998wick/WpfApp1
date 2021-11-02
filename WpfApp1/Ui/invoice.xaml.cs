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
using WpfApp1.Database;

namespace WpfApp1.Ui
{
    /// <summary>
    /// Interaction logic for invoice.xaml
    /// </summary>
    public partial class invoice : Window
    {
        public invoice()
        {
            InitializeComponent();
            loadOders();
            loadPayment();
        }

        private void loadOders()
        {
            DatabaseRepository list = new DatabaseRepository();

            Payment.ItemsSource = list.Orders.Where(a => a.Payment == null).ToList();

        }

        private void loadPayment()
        {
            DatabaseRepository list = new DatabaseRepository();

            Payment.ItemsSource = list.Payments.ToList();

        }
    }
}
