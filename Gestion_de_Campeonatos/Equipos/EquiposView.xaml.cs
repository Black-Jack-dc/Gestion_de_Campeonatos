using System;
using System.Collections.Generic;
using System.Data;
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
        int id = 0;
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
                dgtEquipos.Columns[0].Visibility = Visibility.Collapsed;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        void Datos()
        {
            equipo = new Equipo(txtName.Text, int.Parse(txtCant.Text));
            equipos = new Controlador();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Datos();
            try
            {
                int n = equipos.Insert_Equipos(equipo);

                if (n> 0)
                {
                    MessageBox.Show("Agregado con exito");
                    Select();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            equipo = new Equipo(short.Parse(id.ToString()));
            equipos = new Controlador();
            if (MessageBox.Show("Esta seguro de elminar este elemento?","Eliminar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                equipos.Delete_Equipos(equipo);
                MessageBox.Show("Eliminado con exito");
                Select();
            }
            else
            {
                MessageBox.Show("Eliminado sin exito");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            equipo = new Equipo(short.Parse(id.ToString()),txtName.Text, int.Parse(txtCant.Text));
            equipos = new Controlador();
            try
            {
                int n = equipos.Update_equipos(equipo);
                if (n > 0)
                {
                    MessageBox.Show("Actualizado con exito");
                    Select();
                }
                else
                {
                    MessageBox.Show("Ningun dato seleccionado");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Select();
        }

        private void dgtEquipos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgtEquipos.SelectedIndex >= 0 )
            {
               equipos = new Controlador();
                try
                {
                    DataTable election = equipos.Select_Equipos();
                    id = int.Parse(election.Rows[dgtEquipos.SelectedIndex][0].ToString());
                    int p = dgtEquipos.SelectedIndex;
                    txtName.Text = election.Rows[p][1].ToString();
                    txtCant.Text = election.Rows[p][2].ToString();
                    //MessageBox.Show(id.ToString());
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
    }
}
