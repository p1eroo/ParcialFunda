using APDAYC_Ejercicio1_EP202302.Controllers;
using APDAYC_Ejercicio1_EP202302.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace APDAYC_Ejercicio1_EP202302
{
    public partial class formAgregarDirectorApeli : Form
    {
        DirectorController directorController = new();
        PeliculaController peliController = new();

        public formAgregarDirectorApeli()
        {
            InitializeComponent();
        }

        //Creamos la funcion mostrar

        private void mostrarDirectores(List<Director> lista)
        {
            listViewSEg.Items.Clear();

            foreach (Director dir in lista)
            {
                ListViewItem item = new ListViewItem(dir.DNI);
                item.SubItems.Add(dir.Nombre);
                item.SubItems.Add(dir.Sexo);
                item.SubItems.Add(dir.Estado);
                item.SubItems.Add(dir.Telefono.ToString());

                listViewSEg.Items.Add(item);
            }
        }

        private void formAgregarDirectorApeli_Load(object sender, EventArgs e)
        {
            cbDirector.DisplayMember = "Nombre";
            cbDirector.ValueMember = "DNI";
            cbDirector.DataSource = DirectorController.directors;

            mostrarDirectores(DirectorController.directors);
            mostrarPelis(listViewPrim, PeliculaController.pelicula);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbDirector.SelectedIndex == -1 || listViewPrim.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleccione el director y la(s) pelicula(s)que desea juntar  ", "Aviso!!");
                return;
            }

            //Al seleccionar el DNI del director
            string DNI = cbDirector.SelectedValue.ToString();


            Director dir = directorController.directorPorDNI(DNI);

            foreach (int index in listViewPrim.SelectedIndices)
            {
                string cod = listViewPrim.Items[index].Text;
                string mensaje = directorController.AsignarPelicula_Director(dir, cod);

                if (!mensaje.Equals(""))
                {
                    MessageBox.Show(mensaje, "Aviso!!");
                }
            }

            MessageBox.Show("Pelicula registrado a director", "Aviso!!");
        }

        private void mostrarPelis(ListView vista, List<Pelicula> lista)
        {
            vista.Items.Clear();

            foreach (Pelicula en in lista)
            {
                ListViewItem fila = new(en.Codigo);
                fila.SubItems.Add(en.Nombre);
                fila.SubItems.Add(en.Genero);
                fila.SubItems.Add(en.Estado);
                fila.SubItems.Add(en.Duracion);
                fila.SubItems.Add(en.TaquillaG);
                fila.SubItems.Add(en.AnioEstreno);
                vista.Items.Add(fila);

            }
        }

        private void listViewSEg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSEg.SelectedItems.Count > 0)
            {
                string DNI = listViewSEg.SelectedItems[0].Text;
                mostrarPelis(listViewTree, directorController.PelisXDirector(DNI));
            }
        }
    }
}
