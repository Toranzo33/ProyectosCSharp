using System;

namespace Tonga
{
    class Pantalla
    {
        // Mostrar la pantalla de combate
        public void initgameScreen(string nomPJ, string nomEne="Enemigo")
        {
            Console.Clear();
            Console.SetCursorPosition(0,3);
            Console.Write(nomPJ);
            Console.SetCursorPosition(0,4);
            Console.Write("Puntos de Vida:");
            Console.SetCursorPosition(45,3);
            Console.Write(nomEne);
            Console.SetCursorPosition(45,4);
            Console.Write("Puntos de Vida:");
            
        }
        // Clase universal de impresion en pantalla 
        public void MuestraTexto(string texto, int x = 0, int y = 0)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(texto);
        }
    }
}




