using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_5
{
    internal interface IEntregable
    {
        void entregar();
        void devolver();
        bool isEntregado();
        int compareTo(object a);
    }
}
