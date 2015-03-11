namespace Tonga
{
    using System;
    public class Selector
    {
        int count = 0;
        private bool repeat = true;
        string[] sRet = new string[9];
        // Seleccion de Personaje Jugador sSelector es el array de Clases de Jugadores
        public string[] Seleccion(string[,] sSelector, int largo = 1)
        {
            //VARIABLES
            int tecla = 0; //la i es el incremento de fila para impresion.
            // -- CUERPO CLASE --
            // Imprime las opciones
            for (count = 1; count < sSelector.GetLength(1); count++)
            {
                Console.SetCursorPosition(1, (4 + count));
                Console.Write((count) + "- " + sSelector[0, count]);

            }
            ConsoleKeyInfo entrada;
            Console.TreatControlCAsInput = true; // Desactiva CTRL-C como Break
            // Loop para ingregso de tecla seleccion
            while (repeat == true)
            {
                Console.SetCursorPosition(1, 15);
                Console.Write(" Seleccion - ");
                entrada = Console.ReadKey();
                tecla = int.Parse(entrada.KeyChar.ToString());
                for (int j = 0; j <= sSelector.Rank;j++ )
                    sRet[j] = sSelector[j, tecla];
                // Loop para confirmacion de avance
                while (1 == 1)
                {
                    Console.SetCursorPosition(1, 16);
                    Console.Write("Continuar s/n");
                    ConsoleKeyInfo cSiNo = (Console.ReadKey(true));
                    string continuar = (cSiNo.Key.ToString());
                    if (continuar == "S" || continuar == "s")
                    {
                        return sRet;
                    }
                    if (continuar == "N" || continuar == "n")
                    {
                        break;
                    }
                }

            } return sRet;
        }
    }
}


