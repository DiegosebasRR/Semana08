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
using Business1;
using Entety2;
namespace Semana07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string productName = txtName.Text; 

            BProduct bProduct = new BProduct();
            List<Product> products = bProduct.GetByName(productName);
            dataGrid.ItemsSource = products;

        }
        private void Button_Ventana1_Click(object sender, RoutedEventArgs e)
        {
            Update updateWindow = new Update();
            updateWindow.Show();

        }
        private void Button_Ventana2_Click(object sender, RoutedEventArgs e)
        {
            Delete deleteWindow = new Delete();
            deleteWindow.Show();
        }

    }
}
