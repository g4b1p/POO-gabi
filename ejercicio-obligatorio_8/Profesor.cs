using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_8
{
    internal class Profesor
    {
        public string nombre;
        public int edad;
        public char sexo;
        public Materia materia;

        private static Random r = new Random();

        public Profesor(string nombre, int edad, char sexo, Materia materia)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.materia = materia;
        }

        public bool asistirClase()
        {
            //Random r = new Random();
            int rnum = r.Next(0, 100);

            if (rnum > 20)
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
