using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APDAYC_Ejercicio1_EP202302.Entities;
using APDAYC_Ejercicio1_EP202302.Reportes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace APDAYC_Ejercicio1_EP202302.Controllers
{
    internal class PeliculaController
    {
        public static List<Pelicula> pelicula  {get; set;}

        public PeliculaController() {

            if (pelicula == null)
            {
                pelicula = new ();
            }

        }

        public Pelicula peliXCod(string codigo)
        {
            return pelicula.Find(pel => pel.Codigo.Equals(codigo));

        }

        public bool PeliAsigDirec(string codigo)
        {
            return DirectorController.directors.Exists(dir => dir.Peliculas.Exists(pel => pel.Codigo.Equals(codigo)));
        }
        /*
        public bool ExistsCodPeli(String numCodPeli)
        {
            List<Director> directors = DirectorController.listarTodo();


            foreach (Director en in directors) {
                bool existe = en.Peliculas.Exists(en => en.Codigo.Equals(numCodPeli));
                if (existe)
                {
                    return true;
                }
            }
            return false;
        }
        */


        public string AgregarPeli(Pelicula newPeli)
        {

                if (pelicula.Any(cam => cam.Codigo.Equals(newPeli.Codigo)))
                {
                return "Codigo ya registrado";
                }

                pelicula.Add(newPeli);
                return "";
            
        }


        public List<Pelicula> listarTodo(String codigoPeli)
        {
            Director? en = DirectorController.listarTodo().Find(en => en.DNI.Equals(codigoPeli));

            if (en != null)
            {
                return en.Peliculas;
            }
            else
            {
                return new List<Pelicula>();
            }

        }

        public List<Pelicula> peliculaPorGenero(string Genero)
        {
            return pelicula.FindAll(en => en.Genero.Equals(Genero));
        }


        /*  public List<Pelicula> peliculaPorDuacion(string duracion)
          {
              List<Pelicula> listaPelis = new() { };

              foreach (Pelicula en in pelicula) {

                  int min = 1;

                  if (en.Duracion)

              }

              return pelicula.FindAll(en => en.Duracion.Equals(duracion));
          }

          */
    }
}
