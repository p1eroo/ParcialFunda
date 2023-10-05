using APDAYC_Ejercicio1_EP202302.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APDAYC_Ejercicio1_EP202302.Entities;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace APDAYC_Ejercicio1_EP202302.Controllers
{
    internal class DirectorController
    {
        public static List<Director> directors { get; set; }

        private PeliculaController peliculaController = new ();

        public DirectorController() { 
        
            if (directors == null)
            {
                directors = new List<Director>();
            }
        
        }

        public bool Existe(String numDNiDirector)
        {
            return directors.Exists(di => di.DNI.Equals(numDNiDirector));
        }

        public string AgregarDirector (Director director)
        {
            string mensaje = "";
            
            if (Existe(director.DNI))
            {
                mensaje = "DNI ya regsitrado";
                return mensaje;
            }

            directors.Add(director);
            return mensaje;

        }

        public Director directorPorDNI(string DNI)
        {
            return directors.Find(dir => dir.DNI.Equals(DNI));
        }

        public string AsignarPelicula_Director(Director dir, string cod)
        {
            if (peliculaController.PeliAsigDirec(cod))
            {
                return "Pelicula con código" + cod + " ya está asiganda a un director";
            }

            Pelicula peliculaV = peliculaController.peliXCod(cod);
            dir.Peliculas.Add(peliculaV);
            return "";
        }

        public static List<Director> listarTodo()
        {
            return directors;

        }

        public List<Pelicula> PelisXDirector(string DNI)
        {
            return directors.Find(cli => cli.DNI == DNI).Peliculas;
        }

        public List<Director> ListarPorPeliculasMasTaquillerasXdirector(string taquillaG)
        {
            List<Director> directorTemp = new();

            List<Director> directors = DirectorController.directors.FindAll(dir => dir.Peliculas.Exists(pel => pel.Codigo.Equals(taquillaG)));

            foreach(Director di in directors)
            {
                Director objDir = new ()
                {
                    Nombre = di.Nombre ,
                    Peliculas= new()
        
                };

                Pelicula peli = di.Peliculas.MaxBy(pel => pel.TaquillaG);
                objDir.Peliculas.Add(peli);

                directorTemp.Add(objDir);
           
            }

            return directors;
        }


        public List<Director> listarPorTaquilla(string masTaquilla)
        {
            List<Director> clientesTemp = new();

            foreach (Director en in directors)
            {
                bool existe = en.Peliculas.Exists(ped => ped.TaquillaG.Equals(masTaquilla));
               
                if (existe)
                {
                    clientesTemp.Add(en);

                }
            }
            return clientesTemp;

        }

    }
}
