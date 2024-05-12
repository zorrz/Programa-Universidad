namespace Guia4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Universidad uniNIC= new Universidad();

            uniNIC.AgregarAlumno(new Alumno("Steven",22,Carreras.Ingenieria_En_Computacion,"2019-1090F"));
            uniNIC.AgregarAlumno(new Alumno("Jacqueline carcache", 19, Carreras.Ingenieria_De_Sistemas, "2023-1040U"));
            uniNIC.AgregarAlumno(new Alumno("Morelia", 18, Carreras.Ingenieria_De_Sistemas, "2023-3640F"));

            //Implemente una forma de agregar calificaciones a los alumnos con metodo AddRange para la lista de calificaciones en una sola linea.

            uniNIC.ObtenerListAlumnos()[0].Calificaciones.AddRange(new List<double> { 90, 70, 85});
            uniNIC.ObtenerListAlumnos()[1].Calificaciones.AddRange(new List<double> { 65, 100, 90});
            uniNIC.ObtenerListAlumnos()[2].Calificaciones.AddRange(new List<double> { 50, 60, 65});

            int item = 1;

            Console.WriteLine();
            Console.WriteLine("Lista de alumnos:");
            Console.WriteLine();

            foreach (var alumno in uniNIC.ObtenerListAlumnos())
            {
                Console.WriteLine($"Alumno #{item}");
                Console.WriteLine($"Nombre: {alumno.Nombre}");
                Console.WriteLine($"Edad: {alumno.Edad}");
                Console.WriteLine($"Carrera: {alumno.Carrera}");
                Console.WriteLine($"Carne: {alumno.Carne}");
                Console.WriteLine($"Calificaciones: ");
                for ( int i = 0; i < alumno.Calificaciones.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {alumno.Calificaciones[i]}");
                }
                Console.WriteLine($"Promedio de calificaciones: {alumno.CalcularPromedioCalificaciones()}");
                Console.WriteLine($"Estado de aprobacion: {alumno.EstadoAprobacion()}");
                Console.WriteLine();

                item++;
            }

            Console.WriteLine($"Total de alumnos: {uniNIC.ObtenerListAlumnos().Count}");


        }
    }
}
