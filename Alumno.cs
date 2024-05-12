using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Guia4
{
    public partial class Alumno
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carne { get; set;}

        public Carreras Carrera { get; set;}

        public List<double> Calificaciones { get; set; }

        public Alumno(string nombre, int edad, Carreras carrera, string carne)
        {
            Nombre = nombre;
            Edad = edad;
            Carrera = carrera;
            Carne = carne;
            Calificaciones = new List<double>();

        }
      
    }
   
}
