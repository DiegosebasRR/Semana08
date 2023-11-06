using Data1;
using Entety2;
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
using System.Xml.Linq;

namespace Semana07
{
    /// <summary>
    /// Lógica de interacción para Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        public Update() 
        {
            InitializeComponent();
        }
        private void Button_Actualizar_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product
            {
                name = txtName.Text,
                price = decimal.Parse(txtPrice.Text),
                stock = int.Parse(txtStock.Text),
                active = chkActive.IsChecked ?? false
            };

            DProduct data = new DProduct();
            data.Update(product);
            MessageBox.Show("Producto actualo correctamente.");
        }
    }
}
