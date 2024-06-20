using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;


namespace Propriedadesaula.Models
{
    public class MeuArray<T>
    {
        private static int capacidade = 10;
        private int contador = 0;
        private T[] array = new T[10];

        public void AdicionarElementoArray(T elemento)
        {
            if (contador + 1 < 11)
            {
                array[contador] = elemento;
            }
            contador++;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}



























// namespace Propriedadesaula.Models
// {
//     public class MeuArray<T>
//     {
//         private static int capacidade = 10;
//         private int contador = 0;
//         private T[] array = new T[10];

//         public void AdicionarElementoArray(T elemento)
//         {
//             if (contador + 1 < 11)
//             {
//                 array[contador] = elemento;
//             }
//             contador++;
//         }

//         public T this[int index]
//         {
//             get { return array[index]; }
//             set { array[index] = value; }
//         }
//     }
// }