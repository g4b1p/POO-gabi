using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_8
{
    internal class Estudiante
    {
        public string nombre;
        public int edad;
        public char sexo;
        public Calificacion calificacion;

        private static Random r = new Random();

        public enum Calificacion
        {
            A = 10,
            B = 9,
            C = 8,
            D = 7,
            E = 6,
            F = 5,
            G = 4,
            H = 3,
            I = 2,
            J = 1,
            K = 0
        };

        public Estudiante (string nombre, int edad, char sexo, Calificacion calificacion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.calificacion = calificacion;
        }

        public bool asistirClase()
        {
            //Random r = new Random();
            int rnum = r.Next(0, 100);
            
            if (rnum > 50)
            {
                return true;
            }
            else 
            {
                return false;
            }
            
        }

        public bool aprobado()
        {
            if ((int)calificacion >= (int)Calificacion.F)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
