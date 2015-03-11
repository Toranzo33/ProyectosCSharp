using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUSTOMER_ABM
{
    class Cliente
    {
        static void Main(string[] args)
        {
            // CLASES
            ABM entrada = new ABM();
            // VARIABLES
            int nIdCliente;
            string sRzonScial=null;
            long nCuit=0;
            string sDireccion;
            // CUERPO--
            sRzonScial=entrada.Ingreso("Razon Social");
            nCuit = Convert.ToInt32( entrada.Ingreso("CUIT"));
            Console.WriteLine("\n" + sRzonScial);
            Console.WriteLine("\n" + nCuit);

        }
    }
}
