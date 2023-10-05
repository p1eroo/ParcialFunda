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
    public partial class formReport2 : Form
    {
        private PeliculaController pC = new();
        private DirectorController dC = new();

        public formReport2()
        {
            InitializeComponent();
        }

        private void mostrar(List<Pelicula> lista)
        {

            listView3.Items.Clear();


            foreach (Pelicula en in lista)
            {
                ListViewItem fila = new(en.Codigo);
                fila.SubItems.Add(en.Nombre);
                fila.SubItems.Add(en.Genero);
                fila.SubItems.Add(en.Estado);
                fila.SubItems.Add(en.Duracion);
                fila.SubItems.Add(en.TaquillaG);
                fila.SubItems.Add(en.AnioEstreno);

                listView3.Items.Add(fila);

            }
        }

        private void btnBuscReg_Click(object sender, EventArgs e)
        {
            //Validation de campos

            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese el campo", "Aviso!");
                return;
            }

            //Mostrar en el listView

           // mostrar(dC.listarPorTaquilla(tbNombre.Text));
        }

        
    }
}
