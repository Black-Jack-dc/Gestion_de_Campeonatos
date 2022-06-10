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

namespace Gestion_de_Campeonatos.Equipos
{
    /// <summary>
    /// Interaction logic for EquiposView.xaml
    /// </summary>
    public partial class EquiposView : UserControl
    {
        Controlador equipos;
        Equipo equipo;
        public EquiposView()
        {
            InitializeComponent();
        }
        void Select()
        {
            equipos = new Controlador();
            dgtEquipos.ItemsSource = null;

            try
            {
                dgtEquipos.ItemsSource = equipos.Select_Equipos().DefaultView;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            equipo = new Equipo(txtName.Text, int.Parse(txtCant.Text));
            equipos = new Controlador();

            try
            {
                int n = equipos.Insert_Equipos(equipo);

                if (n> 0)
                {
                    MessageBox.Show("Agregado con exito");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Select();
        }
    }
}
