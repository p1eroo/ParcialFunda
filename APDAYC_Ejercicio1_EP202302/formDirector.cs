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
using System.Xml.Linq;

namespace APDAYC_Ejercicio1_EP202302
{
    public partial class formDirector : Form
    {
        private DirectorController dC = new();

        public formDirector()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void mostrar(List<Director> lista)
        {

            listView1.Items.Clear();

            foreach (Director en in lista)
            {
                ListViewItem fila = new(en.DNI);
                fila.SubItems.Add(en.Nombre);
                fila.SubItems.Add(en.Sexo);
                fila.SubItems.Add(en.Estado);
                fila.SubItems.Add(en.Telefono.ToString());

                listView1.Items.Add(fila);

            }
            // labtotClient.Text = lista.Count.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Validation

            if (tbCod.Text == "" || tbName.Text == "" || cbSexo.Text == "" || cbEstado.Text == "" || tbTelef.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos", "Aviso!");
                return;
            }

            // Creacion del objeto

            Director director = new()
            {
                DNI = tbCod.Text,
                Nombre = tbName.Text,
                Sexo = cbSexo.Text,
                Estado = cbEstado.Text,
                Telefono = Convert.ToInt32(tbTelef.Text.Trim()),
                Peliculas = new List<Pelicula>()

            };

            //La insertacion

            string mensaje = dC.AgregarDirector(director);

            /*
            if (!mensaje.Equals(""))
            {
                MessageBox.Show(mensaje, "Transpote");
                return;
            }
            */

            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "");
            }


            //Actualizar lista listView

            mostrar(DirectorController.directors);

        }

        private void formDirector_Load(object sender, EventArgs e)
        {
            mostrar(DirectorController.directors);
        }

        private void tbCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
