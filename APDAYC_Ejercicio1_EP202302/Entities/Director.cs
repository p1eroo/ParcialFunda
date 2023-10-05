using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APDAYC_Ejercicio1_EP202302.Entities
{
    internal class Director
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public string Estado { get; set; }
        public int Telefono { get; set; }

        public List<Pelicula> Peliculas { get; set; }
    }
}
