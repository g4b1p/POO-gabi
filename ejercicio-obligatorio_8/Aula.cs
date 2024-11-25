using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_8
{
    internal class Aula
    {
        public int identificador;
        public int numMaxEstudiantes;
        public Materia materia;

        public List<Estudiante> estudiantes;

        public Profesor profesor;

        public Aula(int identificador, int numMaxEstudiantes, Materia materia, Profesor profesor)
        {
            this.identificador = identificador;
            this.numMaxEstudiantes = numMaxEstudiantes;
            this.materia = materia;
            this.profesor = profesor;
            this.estudiantes = new List<Estudiante>();
        }

        public bool puedeDarClases()
        {
            /*int numPresentes = 0;

            if (profesor.asistirClase() == false)
            {
                return false;
            }

            if (profesor.materia.Equals(this.materia) == false)
            {
                return false;
            }*/

            /*else if(profesor.asistirClase() == true && profesor.materia.Equals(this.materia))
            {
                foreach (Estudiante e in estudiantes)
                {
                    if (e.asistirClase() == true)
                    {
                        numPresentes++;
                    }
                }
                if (numPresentes > 50)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                //return true;
            }
            else
            {
                return false;
            }*/
            /*
            foreach (Estudiante e in estudiantes)
            {
                if (e.asistirClase() == true)
                {
                    numPresentes++;
                }
            }

            if (numPresentes > (numMaxEstudiantes / 2))
            {
                return true;
            }
            else
            {
                return false;
            }*/


            // gpt
            if (!profesor.asistirClase())
            {
                Console.WriteLine("el profesor no asistio");
                return false;
            }

            if (!profesor.materia.Equals(this.materia))
            {
                Console.WriteLine("el profesor no enseña la materia correcta");
                return false;
            }

            int numPresentes = 0;
            foreach (Estudiante e in estudiantes)
            {
                if (e.asistirClase())
                {
                    //Console.WriteLine("el num aleatorio es MAYOR+ q 50");
                    numPresentes++;
                }
                /*else
                {
                    Console.WriteLine("el num aleatorio es MENOR- q 50");
                }*/
            }

            Console.WriteLine("num de estudiantes presentes: " + numPresentes);

            if (numPresentes > (numMaxEstudiantes / 2))
            {
                return true;
            }
            else
            {
                Console.WriteLine("no hay suficientes estudiantes");
                return false;
            }
        }

        public void mostrarAprobados()
        {
            int cantMujeres = 0;
            int cantHombres = 0;

            foreach (Estudiante e in estudiantes)
            {
                if (e.aprobado())
                {
                    if (e.sexo == 'm')
                    {
                        cantMujeres++;
                    }
                    else
                    {
                        cantHombres++;
                    }
                }
                /*else
                {
                    Console.WriteLine("el estudiante no aprobo");
                }*/
            }

            Console.WriteLine("cantidad de estudiantes mujeres aprobadas: " + cantMujeres);
            Console.WriteLine("cantidad de estudiantes hombres aprobados: " + cantHombres);
        }
    }
}
