

namespace Tonga
{
    using System;
    class Oponente
    {
       // Clases
        Random rNumero = new Random();
        Selector selFoe = new Selector();
        Pantalla cScreen = new Pantalla();
        // Variables
        string[,] sFoe = new string [3,6] {{ "Vacio","Rata", "Arquero", "Wargo", "Orco", "Troll"},
                                           {"0","200","250","300","350","400"},  
                                           {"0","10","15","20","25","30"}};
        string[] nFoeselected = new string[9];
        // -- CUERPO CLASE --
        public string[] SeleccionaOponente()
        {
            string[] sRetFoe = new string[9]; // sRetFoe -> cadena armada con enemigo a devolver
            cScreen.MuestraTexto("Elige tu Oponente", 1, 2);
            nFoeselected = selFoe.Seleccion(sFoe); 
            Console.SetCursorPosition(0, 20);
            for (int i = 0; i <= 2; i++)
            {
                sRetFoe[i] = nFoeselected[i];
            }
            Console.Write("\nTu enemigo es un " + " un " + sRetFoe[0] + " -- " + sRetFoe[1] + " -- " + sRetFoe[2]);
            Console.ReadKey();
            //  *** verificar valor retornado  ***
            return sRetFoe;
        }
        public int atacaOponente(int nPjDmg, int nPjVida, int nFoeDmg, int nFoeVida)
        {
           
            // -- CUERPO CLASE --
            nPjVida -= (nFoeDmg + rNumero.Next(0, 3));
            return nPjVida;
        }
    }
}
     
     