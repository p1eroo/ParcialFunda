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

namespace APDAYC_Ejercicio1_EP202302
{
    public partial class formPelicula : Form
    {
        PeliculaController cC = new();

        public formPelicula()
        {
            InitializeComponent();
        }

        private void mostrar(List<Pelicula> lista)
        {

            listView1.Items.Clear();

            foreach (Pelicula en in lista)
            {
                ListViewItem fila = new(en.Codigo);
                fila.SubItems.Add(en.Nombre);
                fila.SubItems.Add(en.Genero);
                fila.SubItems.Add(en.Estado);
                fila.SubItems.Add(en.Duracion);
                fila.SubItems.Add(en.TaquillaG);
                fila.SubItems.Add(en.AnioEstreno);

                listView1.Items.Add(fila);

            }
            // labtotClient.Text = lista.Count.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Validation

            if (tbCod.Text == "" || tbName.Text == "" || cbGenero.Text == ""
                || tbEstado.Text == "" || tbDuracion.Text == "" || tbTaquillaG.Text == ""
                || tbAnioEstreno.Text =="" )
            {
                MessageBox.Show("Ingrese todos los campos", "Aviso!");
                return;
            }

            //Crear el objeto

            Pelicula pelicula = new()
            {
                Codigo = tbCod.Text,
                Nombre = tbName.Text,
                Genero = cbGenero.Text,
                Estado = tbEstado.Text,
                Duracion = tbDuracion.Text,
                TaquillaG = tbTaquillaG.Text,
                AnioEstreno = tbAnioEstreno.Text,
            };

            string mensaje = cC.AgregarPeli(pelicula);

            if (!mensaje.Equals(""))
            {
                MessageBox.Show(mensaje, "Aviso!!!");
                return;
            }

            //Actualizar lista listView

            mostrar(PeliculaController.pelicula);
        }
    }
}
