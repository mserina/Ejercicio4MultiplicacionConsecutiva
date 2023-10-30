using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Multiplicacion.Servicios
{
    /// <summary>
    /// Clase implementacion, almacena toda la logica de los metodos que estan en la interfaz
    /// msm - 301023
    /// </summary>
    internal class OperacionImplementacion :OperacionInterfaz
    {
        public void multiplicacion(int numero)
        {
            int operacionAlmacenado = 1;

            // Utilizamos el for para multiplicar una serie de numeros dependiendo del numero que metamos por consola 
            for (int i = 1; i <= numero; i++)
            {
                operacionAlmacenado *= i;
            }
            Console.WriteLine("Resultado: " + operacionAlmacenado);
            
        }
    }
}
