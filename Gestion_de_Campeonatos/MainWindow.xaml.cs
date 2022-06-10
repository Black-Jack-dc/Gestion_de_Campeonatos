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

namespace Gestion_de_Campeonatos
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
        

        private void btnClose_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLug_Click(object sender, RoutedEventArgs e)
        {
            UserControl lugares = null;
            gtViews.Children.Clear();
            lugares = new Lugares.LugaresView();
            gtViews.Children.Add(lugares);
        }

        private void btnEqui_Click(object sender, RoutedEventArgs e)
        {
            UserControl equipos = null;
            gtViews.Children.Clear();
            equipos = new Equipos.EquiposView();
            gtViews.Children.Add(equipos);
        }

        private void btnCamp_Click(object sender, RoutedEventArgs e)
        {
            UserControl campeonatos = null;
            gtViews.Children.Clear();
            campeonatos = new Campeonatos.CampeonatosView();
            gtViews.Children.Add(campeonatos);
        }

        private void btnDep_Click(object sender, RoutedEventArgs e)
        {
            UserControl deportes = null;
            gtViews.Children.Clear();
            deportes = new Deportes.DeportesView();
            gtViews.Children.Add(deportes);
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
