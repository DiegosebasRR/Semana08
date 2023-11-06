using Business1;
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
    /// Lógica de interacción para Delete.xaml
    /// </summary>
    public partial class Delete : Window
    {
        public Delete()
        {
            InitializeComponent();
        }
        private void Button_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;

            BProduct business = new BProduct();
            business.Delete(name);

            MessageBox.Show("Producto eliminado correctamente.");
        }
    }
}
