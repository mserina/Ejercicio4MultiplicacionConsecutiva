using Ejercicio4Multiplicacion.Servicios;

namespace Ejercicio4Multiplicacion
{
    /// <summary>
    /// Clase principal
    /// msm - 301023
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo main, contiene el procedimiento de la aplicacion
        /// msm - 301023
        /// </summary>
        /// <param name="args"></param>
        static void Main (string[] args)
        {

            //Variable 
            int numero;
            string respuesta;
            bool cerrarBucle = false;

            //Objeto
            NumeroInterfaz num = new NumeroImplementacion();
            OperacionInterfaz op = new OperacionImplementacion();


            //Metodos
            
            while (!cerrarBucle)
            {
                //Llamo a los metodos para solicitar numero/control de iteracion y la de la multiplicacion
                numero = num.solicitarNumero();
                op.multiplicacion(numero);


                //Creamos una condicion para que se siga añadiendo numeros en caso contrario se cerrara el programa 
                Console.WriteLine("Quieres añadir otro numero");
                respuesta = Console.ReadLine(); 

                if (respuesta != "s")
                {
                    cerrarBucle = true;
                }
            }
        }
    }
}