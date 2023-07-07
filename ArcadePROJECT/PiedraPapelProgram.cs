using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadePROJECT {
    internal class ProgramPiedraPapel {
        //Variables

        public void PiedraPapelOTijeras() {

            //Variables
            int inputPlayer;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;
            bool playAgain = true;

            bool disponible = true;

            string[] inputCPU ={
            "piedra",
            "papel",
            "tijeras"
            };

            string[] selectMenu = {
            "piedra",
            "papel",
            "tijeras"
            };

            //Inicio del RSP

            while (playAgain) {
                while (scorePlayer < 3 && scoreCPU < 3) {
                    do {
                        if (disponible == false) {
                            Console.Clear();
                            Console.WriteLine("Entrada Inválida. Elija una de las opciones dadas.");
                        }
                        
                        Console.WriteLine("Elige entre...");
                        Console.WriteLine("[0] piedra");
                        Console.WriteLine("[1] papel");
                        Console.WriteLine("[2] tijeras");
                        Console.WriteLine();
                        inputPlayer = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        if (inputPlayer < 4) {
                            Random rnd = new Random();
                            randomInt = rnd.Next(3);
                            switch (randomInt) {
                                case 0:

                                    Console.WriteLine("El CPU eligió {0}", inputCPU[randomInt]);

                                    if (selectMenu[inputPlayer] == inputCPU[randomInt]) {
                                        Console.WriteLine("EMPATE \n\n ");
                                    } else if (selectMenu[inputPlayer] == "papel") {
                                        Console.WriteLine("JUGADOR GANA!! \n\n");
                                        scorePlayer++;
                                    } else if (selectMenu[inputPlayer] == "tijeras") {
                                        Console.WriteLine("EL CPU GANA");
                                        scoreCPU++;
                                    }
                                    disponible = true;
                                    break;

                                case 1:
                                    Console.WriteLine("El CPU eligió {0}", inputCPU[randomInt]);
                                    if (selectMenu[inputPlayer] == inputCPU[randomInt]) {
                                        Console.WriteLine("EMPATE \n\n ");
                                    } else if (selectMenu[inputPlayer] == "tijeras") {
                                        Console.WriteLine("JUGADOR GANA!! \n\n");
                                        scorePlayer++;
                                    } else if (selectMenu[inputPlayer] == "piedra") {
                                        Console.WriteLine("EL CPU GANA");
                                        scoreCPU++;
                                    }
                                    disponible = true;
                                    break;
                                case 2:
                                    Console.WriteLine("El CPU eligió {0}", inputCPU[randomInt]);

                                    if (selectMenu[inputPlayer] == inputCPU[randomInt]) {
                                        Console.WriteLine("EMPATE \n\n ");
                                    } else if (selectMenu[inputPlayer] == "piedra") {
                                        Console.WriteLine("JUGADOR GANA!! \n\n");
                                        scorePlayer++;
                                    } else if (selectMenu[inputPlayer] == "papel") {
                                        Console.WriteLine("EL CPU GANA");
                                        scoreCPU++;
                                    }
                                    disponible = true;
                                    break;
                            }
                        } else {
                            disponible = false;
                        }

                        Console.WriteLine(@"
|----------------------------------------------|
|   PULSA CUALQUIER TECLA Y ELIGE OTRA OPCION  |
|----------------------------------------------|
");
                        Console.ReadKey();
                        Console.Clear();
                    } while (disponible == false);


                    Console.WriteLine("\n\nSCORES:\t\tPLAYER:\t" + scorePlayer + " \tCPU:\t" + scoreCPU);
                    Console.WriteLine();

                    if (scorePlayer == 3) {
                        Console.WriteLine(@"
     _____   _             _   _   _    ____      _      ____     ___    ____      _   _      _         ____      _      _   _      _      ____     ___  
    | ____| | |           | | | | | |  / ___|    / \    |  _ \   / _ \  |  _ \    | | | |    / \       / ___|    / \    | \ | |    / \    |  _ \   / _ \ 
    |  _|   | |        _  | | | | | | | |  _    / _ \   | | | | | | | | | |_) |   | |_| |   / _ \     | |  _    / _ \   |  \| |   / _ \   | | | | | | | |
    | |___  | |___    | |_| | | |_| | | |_| |  / ___ \  | |_| | | |_| | |  _ <    |  _  |  / ___ \    | |_| |  / ___ \  | |\  |  / ___ \  | |_| | | |_| |
    |_____| |_____|    \___/   \___/   \____| /_/   \_\ |____/   \___/  |_| \_\   |_| |_| /_/   \_\    \____| /_/   \_\ |_| \_| /_/   \_\ |____/   \___/ 
                                                                                                                                                        
    ");
                    } else if (scoreCPU == 3) {
                        Console.WriteLine(@"
     _____   _          ____   ____    _   _     _   _      _         ____      _      _   _      _      ____     ___  
    | ____| | |        / ___| |  _ \  | | | |   | | | |    / \       / ___|    / \    | \ | |    / \    |  _ \   / _ \ 
    |  _|   | |       | |     | |_) | | | | |   | |_| |   / _ \     | |  _    / _ \   |  \| |   / _ \   | | | | | | | |
    | |___  | |___    | |___  |  __/  | |_| |   |  _  |  / ___ \    | |_| |  / ___ \  | |\  |  / ___ \  | |_| | | |_| |
    |_____| |_____|    \____| |_|      \___/    |_| |_| /_/   \_\    \____| /_/   \_\ |_| \_| /_/   \_\ |____/   \___/ 
                                                                                                                        
    ");
                    }
                }
                Console.WriteLine("Quieres jugar de nuevo? (S / N)");
                string loop = Console.ReadLine();
                if (loop == "S") {
                    playAgain = true;
                    Console.Clear();
                    scorePlayer = 0;
                    scoreCPU = 0;
                } else if (loop == "N") {
                    playAgain = false;
                }
            }
            // FIN DEL RSP


        }
    }
}