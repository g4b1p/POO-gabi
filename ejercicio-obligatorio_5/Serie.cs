using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_5
{
    internal class Serie : IEntregable
    {
        private string titulo;
        private int numTemporadas;
        private bool entregado;
        private string genero;
        private string creador;

        // vars por defecto
        private string _título = "";
        private int _numTemporadas = 3;
        private bool _entregado = false;
        private string _genero = "";
        private string _creador = "";

        public Serie()
        {
            titulo = _título;
            numTemporadas = _numTemporadas;
            entregado = _entregado;
            genero = _genero;
            creador = _creador;
        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
            numTemporadas = _numTemporadas;
            entregado = _entregado;
            genero = _genero;
        }

        public Serie(string titulo, int numTemporadas, string genero, string creador)
        {
            this.titulo = titulo;
            this.numTemporadas = numTemporadas;
            this.genero = genero;
            this.creador = creador;
        }

        #region sets

        public void sTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public void sNumTemporadas(int numTemporadas)
        {
            this.numTemporadas = numTemporadas;
        }

        public void sGenero(string genero)
        {
            this.genero = genero;
        }

        public void sCreador(string creador)
        {
            this.creador = creador;
        }

        #endregion

        #region gets

        public string gTitulo()
        {
            return titulo;
        }

        public int gNumTemporadas()
        {
            return numTemporadas;
        }

        public string gGenero()
        {
            return genero;
        }

        public string gCreador()
        {
            return creador;
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
            if (a is Serie serie)
            {

                if (this.numTemporadas < serie.gNumTemporadas())
                {
                    return -1;
                }
                else if (this.numTemporadas == serie.gNumTemporadas())
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
                throw new ArgumentException("el objeto no es de tipo serie");
            }
        }
    }
}
