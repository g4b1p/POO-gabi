using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("julio", 14, 'h', Estudiante.Calificacion.H);
            Estudiante estudiante2 = new Estudiante("raul", 15, 'h', Estudiante.Calificacion.A);
            Estudiante estudiante3 = new Estudiante("jose", 14, 'h', Estudiante.Calificacion.A);
            Estudiante estudiante4 = new Estudiante("natasha", 14, 'm', Estudiante.Calificacion.D);
            Estudiante estudiante5 = new Estudiante("rocio", 14, 'm', Estudiante.Calificacion.E);
            Estudiante estudiante6 = new Estudiante("ramona", 14, 'm', Estudiante.Calificacion.A);
            Estudiante estudiante7 = new Estudiante("julieta", 15, 'm', Estudiante.Calificacion.A);
            Estudiante estudiante8 = new Estudiante("martin", 14, 'h', Estudiante.Calificacion.G);
            Estudiante estudiante9 = new Estudiante("lucio", 14, 'h', Estudiante.Calificacion.A);
            Estudiante estudiante10 = new Estudiante("zoe", 15, 'm', Estudiante.Calificacion.F);

            /*Estudiante estudiante11 = new Estudiante("julio", 14, 'h', Estudiante.Calificacion.H);
            Estudiante estudiante12 = new Estudiante("raul", 15, 'h', Estudiante.Calificacion.A);
            Estudiante estudiante13 = new Estudiante("jose", 14, 'h', Estudiante.Calificacion.A);
            Estudiante estudiante14 = new Estudiante("natasha", 14, 'm', Estudiante.Calificacion.D);
            Estudiante estudiante15 = new Estudiante("rocio", 14, 'm', Estudiante.Calificacion.E);
            Estudiante estudiante16 = new Estudiante("ramona", 14, 'm', Estudiante.Calificacion.A);
            Estudiante estudiante17 = new Estudiante("julieta", 15, 'm', Estudiante.Calificacion.A);
            Estudiante estudiante18 = new Estudiante("martin", 14, 'h', Estudiante.Calificacion.G);
            Estudiante estudiante19 = new Estudiante("lucio", 14, 'h', Estudiante.Calificacion.A);
            Estudiante estudiante20 = new Estudiante("zoe", 15, 'm', Estudiante.Calificacion.F);
            */

            Profesor profesor1 = new Profesor("miguel", 45, 'h', Materia.física);

            Aula aula1 = new Aula(5, 10, Materia.física, profesor1);
            /*
             aula1.estudiantes.Add(estudiante1);
            aula1.estudiantes.Add(estudiante2);
            aula1.estudiantes.Add(estudiante3);
            aula1.estudiantes.Add(estudiante4);
            aula1.estudiantes.Add(estudiante5);
            aula1.estudiantes.Add(estudiante6);
            aula1.estudiantes.Add(estudiante7);
            aula1.estudiantes.Add(estudiante8);
            aula1.estudiantes.Add(estudiante9);
            aula1.estudiantes.Add(estudiante10);
             */
            aula1.estudiantes.AddRange(new List<Estudiante>
            {
                estudiante1,
                estudiante2,
                estudiante3,
                estudiante4,
                estudiante5,
                estudiante6,
                estudiante7,
                estudiante8,
                estudiante9,
                estudiante10/*,
                estudiante11,
                estudiante12,
                estudiante13,
                estudiante14,
                estudiante15,
                estudiante16,
                estudiante17,
                estudiante18,
                estudiante19,
                estudiante20*/
            });

            if (aula1.puedeDarClases())
            {
                aula1.mostrarAprobados();
            }
            else
            {
                Console.WriteLine("no se puede dar clases");
            }

            Console.ReadKey();
        }
    }
}
