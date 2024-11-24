using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_5
{
    internal interface IEntregable
    {
        public bool entregar();
        public bool devolver();
        public bool isEntregado();
        public Object compareTo(Object a);

    }
}
