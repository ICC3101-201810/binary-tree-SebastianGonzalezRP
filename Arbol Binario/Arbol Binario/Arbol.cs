using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario
{
    public class Arbol  
    {
        public class Nodo
        {
            public int valor;
            public Nodo izquierda, derecha;

            public Nodo (int i, Nodo _L, Nodo _R)
            {
                valor = i;
                izquierda = _L;
                derecha = _R;
            }
            void insertar (int info)
            {

            }

        }
    }
}

           
