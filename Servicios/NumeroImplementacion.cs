using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Multiplicacion.Servicios
{
    internal class NumeroImplementacion : NumeroInterfaz
    {

        public int solicitarNumero()
        {
            int numero;
            Console.WriteLine("Dame un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
    }
}
