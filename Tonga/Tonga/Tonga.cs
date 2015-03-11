namespace Tonga
{
    using System;
    // Clase Tonga
    class Tonga
    {
        static void Main(string[] args)
        {
            //Clases
            Oponente cFoe = new Oponente();
            Pantalla cScreen = new Pantalla();
            Jugador cPlayer = new Jugador();
            // Variables
            const int NOMBRE = 0;
            const int PUNTOSVIDA = 1;
            const int PODER = 2;
            string sNomJuga; // -> Recibe el Nombre de Player
            string[] nPjselected = new string[9];// Cadena que recibe Jugador elegido (Clase,Vida,Dmg)
            string[] nFoeselected = new string[9]; // Variables usadas para elegir jugador
            int nPvPj;
            int nPvFoe;
            int nPjDmg;
            int nFoeDmg;
            // --- CUERPO PRINCIPAL ---
            sNomJuga = cPlayer.NombreJugador(); // Pide nombre jugador *** (Hacer el metodo con GETKEY) ***
            Console.Clear();
            nPjselected = cPlayer.SeleccionJugador(); // Selecciona Clase del Jugador
            Console.Clear();
            nFoeselected = cFoe.SeleccionaOponente(); // Selecciona Enemigo a Enfrentar
            Console.Clear();
            nPvPj = Convert.ToInt32(nPjselected[PUNTOSVIDA]);
            nPvFoe = Convert.ToInt32(nFoeselected[PUNTOSVIDA]);
            nPjDmg = Convert.ToInt32(nPjselected[PODER]);
            nFoeDmg = Convert.ToInt32(nFoeselected[PODER]);
            cScreen.initgameScreen(sNomJuga,nFoeselected[NOMBRE]);
            cScreen.MuestraTexto(nPvPj.ToString(),0,5);
            cScreen.MuestraTexto(nPvFoe.ToString(),48, 5);
            Console.ReadKey();
            // --- CICLO DE COMBATE ---
            int i = 6;
            while (nPvPj > 0 && nPvFoe > 0)
            {
                nPvFoe = cPlayer.atacaJugador(nPjDmg, nPvPj, nFoeDmg, nPvFoe);
                Console.SetCursorPosition(50,++i);
                Console.Write("{0:2d}",nPvFoe.ToString());
             if (nPvFoe <= 0)
             {
                break;
             }
             else
             {
                nPvPj = cFoe.atacaOponente(nPjDmg,nPvPj,nFoeDmg,nPvFoe);
                Console.SetCursorPosition(3,i);
                Console.Write("{0:2d}",nPvPj.ToString());
            }
             if (nPvFoe <= 0)
             {
                 break;
             }
            }
            // --- CHEQUEO GANADOR
            if (nPvFoe<=0)
            {
                cScreen.MuestraTexto("GANASTE!!!",0,20);
            }
            else
            {
                cScreen.MuestraTexto("PEDISTE!!!",0,20);
            }
            Console.WriteLine("\n---PRESS KEY !!!----");
            Console.ReadKey();
        }
     }
}
