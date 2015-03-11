using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUSTOMER_ABM
{
    class ABM
    {
        public String Ingreso(string sTexto)
        {
            // VARIABLES
            ConsoleKeyInfo cki;
            StringBuilder sb = new StringBuilder();
            //  -- Cuerpo --  ** 
            Console.TreatControlCAsInput = true; // Desactiva CTRL-C como Break
            Console.WriteLine(sTexto + "(Esc) salir \n");
            do
            {
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Backspace)
                {
                    Console.Write(" ");
                    Console.Write("\b");
                    sb.Remove(sb.Length - 1, 1);
                }
                else if (cki.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else
                {
                    sb.Append(cki.KeyChar);
                }
            } while (cki.Key != ConsoleKey.Escape);
            return sb.ToString();
        }
    }
}



