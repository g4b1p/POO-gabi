using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_5
{
    internal class Videojuego : IEntregable
    {
        private string titulo;
        private int horasEstimadas;
        private bool entregado;
        private string genero;
        private string compania;

        // vars por defecto
        private string _titulo = "";
        private int _horasEstimadas = 10;
        private bool _entregado = false;
        private string _genero = "";
        private string _compania = "";

        public Videojuego()
        {
            titulo = _titulo;
            horasEstimadas = _horasEstimadas;
            entregado = _entregado;
            genero = _genero;
            compania = _compania;
        }

        public Videojuego(string titulo, int horasEstimadas)
        {
            this.titulo = titulo;
            this.horasEstimadas = horasEstimadas;
            entregado = _entregado;
            genero = _genero;
            compania = _compania;
        }

        public Videojuego(string titulo, int horasEstimadas, string genero, string compania)
        {
            this.titulo = titulo;
            this.horasEstimadas = horasEstimadas;
            this.genero = genero;
            this.compania = compania;
        }

        #region gets

        public string gTitulo()
        {
            return titulo;
        }

        public int gHorasEstimadas()
        {
            return horasEstimadas;
        }

        public string gGenero()
        {
            return genero;
        }

        public string gCompania()
        {
            return compania;
        }

        #endregion

        #region sets

        public void sTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public void sHorasEstimadas(int horasEstimadas)
        {
            this.horasEstimadas = horasEstimadas;
        }

        public void sGenero(string genero)
        {
            this.genero = genero;
        }

        public void sCompania(string compania)
        {
            this.compania = compania;
        }

        #endregion

        public void entregar()
        {
            this.entregado = true;
        }

        public void devolver()
        {
            this.entregado = false;
        }

        public bool isEntregado()
        {
            return entregado;
        }

        public int compareTo(object a)
        {
            /*
            if (a.Equals(this))
            if (a.GetType() == this.GetType())
            */

            if (a is Videojuego vj)
            {

                if (this.horasEstimadas < vj.gHorasEstimadas())
                {
                    return -1;
                }
                else if (this.horasEstimadas == vj.gHorasEstimadas())
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                //Console.WriteLine("el objeto no es de tipo videojuego");
                throw new ArgumentException("el objeto no es de tipo videojuego");
            }
        }
    }
}
