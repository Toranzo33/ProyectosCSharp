namespace Tonga
{
    using System;
    class Jugador
    {
        // CLASES
        Random rNumero = new Random();
        Selector cChoose = new Selector();
        Pantalla cScreen = new Pantalla();
        // VARIABLES
        public const int CANTDATOS = 3;
        int nPjDmg, nPjVida;
        string name = "Vikingo";
        string[,] sPjClase = new string[4 , 8]{
                                { "Vacio","Gladiador", "Guerrero", "Curador", "Mago", "Asesino", "Cazador", "Mago oscuro"},
                                { "0","100","120","140","150","160","170","180" },
                                { "0","10","12","14","15","16","17","18" },
                                { "0","100","120","140","150","160","170","180" }
        };
        string[,] sSpell = new string[3, 8]{
                                { "Vacio","Basico", "AltoValor", "BajoValor", "Dotter", "Freezer", "DobleDotted", "DobleFreezed"},
                                { "0","10","20","5","10","10","10","10" },
                                { "0","5","15","2","10","10","10","10" } 
        };
        string[] nPjselected = new string[9];
        // -- CUERPO CLASE --
        public string[] SeleccionJugador()
        {
            string[] sRetPj = new string[9]; // sRetPj -> cadena armada con PJ a devolver
            cScreen.MuestraTexto("Elige tu Personaje", 1, 2);
            nPjselected = cChoose.Seleccion(sPjClase, 3);
            Console.SetCursorPosition(0, 20);
            for (int i = 0; i <= 2; i++)
            {
                sRetPj[i] = nPjselected[i];
            }

            Console.Write("\nEres " + name.ToUpper() + " un " + sRetPj[0] + " -- " + sRetPj[1] + " -- " + sRetPj[2]);
            Console.ReadKey();
            return sRetPj;
        }
        // -- CUERPO CLASE --
        public string NombreJugador()
        {
            return name = "Vikingo";   //Console.ReadLine();
        }
        //-- Ataque de Jugador a Enemigo --
        public int atacaJugador(int nPjDmg, int nPjVida, int nFoeDmg, int nFoeVida)
        {
            // -- CUERPO CLASE --
            string [] sumaDmg;
            sumaDmg = cChoose.Seleccion(sSpell);
            Console.Write("-----------------" + sumaDmg[0],sumaDmg[1]);
            nFoeVida -= (nPjDmg + rNumero.Next(0, 20));
            return nFoeVida;
        }
    }

}
