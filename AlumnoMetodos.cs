using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4
{
    public partial class Alumno
    {
        public double CalcularPromedioCalificaciones()
        {
            if (Calificaciones.Count == 0)
            {
                return 0;
            }
            double sumaCalificaciones = 0;
            foreach (var calificacion in Calificaciones)
            {
                sumaCalificaciones += calificacion;
            }
            return sumaCalificaciones / Calificaciones.Count;
        }

        public string EstadoAprobacion()
        {
            double promedio = CalcularPromedioCalificaciones();
            if (promedio >= 60)
            {
                return "Aprobado";
            }
            else
            {
                return "Reprobado";
            }
        }
    }
}
