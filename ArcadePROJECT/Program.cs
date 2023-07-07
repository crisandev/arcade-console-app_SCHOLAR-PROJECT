using static System.Console;
namespace ArcadePROJECT {
    internal class ProgramPrincipal {
        static void Main(string[] args) {
            int option;
            int optionMenuJuego;
            Game myGame = new Game();
            do {
                option = myGame.Start();

                switch (option) {
                    case 0:
                        do {
                            Clear();
                            optionMenuJuego = myGame.menuSerpiente(0);

                            if (optionMenuJuego == 1) {
                                Clear();
                                WriteLine(@"
|--------------------------------------------------------|
|               JUEGO DE LA SERPIENTE                    |
|       DISFRUTA DEL JUEGO CLASICO DE LA SERPIENTE       |
|       DIVIERTETE CON NOSOTROS EN NUESTRO ARCADE        |
|            CREADO POR CRISITAN SANCHEZ                 |
|                MATRICULA 2021-1899                     |
|           TODOS LOS DERECHOS RESERVADOS                |
|                                                        |
|                 © ARCADE GAMES                         |
|--------------------------------------------------------|
");
                                ReadKey();
                            }
                            if (optionMenuJuego == 0) {
                                Clear();
                                ProgramSerpiente serpienteGame = new ProgramSerpiente();
                                serpienteGame.Serpiente();
                            }
                        } while (optionMenuJuego == 1);
                        break;
                    case 1:
                        // HECHO
                        do {
                            Clear();
                            optionMenuJuego = myGame.menuRayas(1);
                            if (optionMenuJuego == 1) {
                                Clear();
                                WriteLine(@"
|--------------------------------------------------------|
|                  JUEGO DE 3 RAYAS                      |
|       DISFRUTA DEL JUEGO 3 RAYAS Y GANALE AL CPU       |
|       DIVIERTETE CON NOSOTROS EN NUESTRO ARCADE        |
|            CREADO POR MARINO RODRIGUEZ                 |
|                MATRICULA 2022-0187                     |
|           TODOS LOS DERECHOS RESERVADOS                |
|                                                        |
|                 © ARCADE GAMES                         |
|--------------------------------------------------------|
");
                                ReadKey();
                            }
                            if (optionMenuJuego == 0) {
                                Clear();
                                ProgramTresRayas rayas = new ProgramTresRayas();
                                rayas.TresRayas();
                            }
                        } while (optionMenuJuego != 2);
                        break;
                    case 2:
                        //HECHO
                        Clear();
                        do {
                            optionMenuJuego = myGame.menuPapelOTijera(2);
                            if (optionMenuJuego == 1) {
                                Clear();
                                WriteLine(@"
|--------------------------------------------------------|
|               JUEGO PIEDRA PAPEL O TIJERA              |
|  DISFRUTA DEL CLASICO JUEGO DE PIEDRA PAPEL O TIJERAS  |
|                  PERO AHORA DESDE LA PC                |
|       DIVIERTETE CON NOSOTROS EN NUESTRO ARCADE        |
|            CREADO POR CRISTAL LANTIGUA                 |
|                MATRICULA 2022-0024                     |
|           TODOS LOS DERECHOS RESERVADOS                |
|                                                        |
|                 © ARCADE GAMES                         |
|--------------------------------------------------------|");
                                ReadKey();
                            }
                            if (optionMenuJuego == 0) {
                                Clear();
                                ProgramPiedraPapel piedraPapel = new ProgramPiedraPapel();
                                piedraPapel.PiedraPapelOTijeras();
                            }
                        } while (optionMenuJuego != 2);
                        break;
                    case 3:
                        // HECHO EL AHORCADO
                        do {
                            Clear();
                            optionMenuJuego = myGame.menuAhorcado(3);
                            if (optionMenuJuego == 1) {
                                Clear();
                                WriteLine(@"
|--------------------------------------------------------|
|                  JUEGO DEL AHORCADO                    |
|             ¿ERES BUENO/A ADIVINANDO PALABRAS?         |
|             DISFRUTA DEL JUEGO DEL AHORCADO            |
|             Y MUESTRA TODAS TUS HABILIDADES            |
|       DIVIERTETE CON NOSOTROS EN NUESTRO ARCADE        |
|            CREADO POR ROBERTO ISAAC                    |
|                MATRICULA 2022-0397                     |
|           TODOS LOS DERECHOS RESERVADOS                |
|                                                        |
|                 © ARCADE GAMES                         |
|--------------------------------------------------------|");
                                ReadKey();
                            }
                            if (optionMenuJuego == 0) {
                                Clear();
                                ProgramAhorcado Ahorcado = new ProgramAhorcado();
                                Ahorcado.elAhorcado();
                            }
                        } while (optionMenuJuego != 2);
                        break;
                    case 4:
                        do {
                            //HECHO
                            Clear();
                            optionMenuJuego = myGame.menuTetris(4); ;
                            if (optionMenuJuego == 1) {
                                Clear();
                                WriteLine(@"
|--------------------------------------------------------|
|                      JUEGO TETRIS                      |
|                ¿SE TE AGUARON LOS OJOS?                |
|      NO ESPERES MAS Y JUEGA CON NOSOTROS TETRIS        |
|       DIVIERTETE CON NOSOTROS EN NUESTRO ARCADE        |
|            CREADO POR WARLING GUZMAN                   |
|                MATRICULA 2022-0187                     |
|           TODOS LOS DERECHOS RESERVADOS                |
|                                                        |
|                 © ARCADE GAMES                         |
|--------------------------------------------------------|");
                                ReadKey();
                            }
                            if (optionMenuJuego == 0) {
                                Clear();
                                ProgramTetris tetris = new ProgramTetris();
                                tetris.TETRISPrincipal();
                            }
                        } while (optionMenuJuego != 2);
                        break;
                }
            } while (option != 5);
            Clear();
            WriteLine(@"
   ____   ____       _       ____   ___      _      ____  
  / ___| |  _ \     / \     / ___| |_ _|    / \    / ___| 
 | |  _  | |_) |   / _ \   | |      | |    / _ \   \___ \ 
 | |_| | |  _ <   / ___ \  | |___   | |   / ___ \   ___) |
  \____| |_| \_\ /_/   \_\  \____| |___| /_/   \_\ |____/                                                           
");
        }
    }
}