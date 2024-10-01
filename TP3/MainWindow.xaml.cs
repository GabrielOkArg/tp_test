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
using TP3.BLL;

namespace TP3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Crear una instancia de la clase CRUDtrabajador
            LlenarGrilla();
        }

        private void AltaTrabajador_Click(object sender, RoutedEventArgs e)
        {
            listTrabajadores altaTrabajadorWindow = new listTrabajadores();
            altaTrabajadorWindow.ShowDialog(); // Muestra la ventana como un cuadro de diálogo
        }



        public void LlenarGrilla()
        {
            trabajadoresDataGrid.ItemsSource = null;
            CRUDtrabajador crud = new CRUDtrabajador();
            trabajadoresDataGrid.ItemsSource = crud.GetAll();
        }
    }
}
