using Business;
using Data1;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace semana07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Cadena de conexión correcta
        private string connectionString = "Data Source=LAB1507-11\\SQLEXPRESS03;Initial Catalog=Sebasdb;User ID=sebas;Password=123456;";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonListarinvoice_Click(object sender, RoutedEventArgs e)
        {
            Binvoice binvoice = new Binvoice();
            var invoices = binvoice.Get();
            datagrid.ItemsSource = invoices;
        }
    }
}