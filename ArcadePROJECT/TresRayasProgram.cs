using System;

namespace ArcadePROJECT {
    class ProgramTresRayas {
        public void TresRayas(){
            int jugador = 2;
            int ingreso = 0;
            bool ingresoCorrecto = true;
            bool tresEnRaya = true;
            Random turnoMaquina = new Random();


            do {

                if (jugador == 2) {
                    jugador = 1;
                    PonerXoO(jugador, ingreso);
                } else if (jugador == 1) {
                    jugador = 2;
                    PonerXoO(jugador, ingreso);
                }
                CreaTablero();

                //Código que verifica si hay un ganador

                string[] cadaSigno = { " X ", " O " };

                foreach (string signo in cadaSigno) {
                    if ((tableroJuego[0, 0] == signo) && (tableroJuego[0, 1] == signo) && (tableroJuego[0, 2] == signo)
                        || (tableroJuego[1, 0] == signo) && (tableroJuego[1, 1] == signo) && (tableroJuego[1, 2] == signo)
                        || (tableroJuego[2, 0] == signo) && (tableroJuego[2, 1] == signo) && (tableroJuego[2, 2] == signo)
                        || (tableroJuego[0, 0] == signo) && (tableroJuego[1, 0] == signo) && (tableroJuego[2, 0] == signo)
                        || (tableroJuego[0, 1] == signo) && (tableroJuego[1, 1] == signo) && (tableroJuego[2, 1] == signo)
                        || (tableroJuego[0, 2] == signo) && (tableroJuego[1, 2] == signo) && (tableroJuego[2, 2] == signo)
                        || (tableroJuego[0, 0] == signo) && (tableroJuego[1, 1] == signo) && (tableroJuego[2, 2] == signo)
                        || (tableroJuego[0, 2] == signo) && (tableroJuego[1, 1] == signo) && (tableroJuego[2, 0] == signo)) {
                        if (signo == " X ")
                            Console.WriteLine("Valla, ha ganado la maquina... Perdiste :c");
                        else
                            Console.WriteLine("Felicitaciones Has ganado :D");

                        Console.WriteLine();
                        Console.WriteLine("Quieres volver a jugar el juego? Si/No");
                        bool repetirPregunta = true;
                        do {
                            String pregunta = Console.ReadLine().ToLower().TrimStart().TrimEnd();
                            if (pregunta != null) {

                                switch (pregunta) {
                                    case "si":
                                        tresEnRaya = true; repetirPregunta = false;
                                        break;

                                    case "no":
                                        tresEnRaya = false; repetirPregunta = false;
                                        Resetear();
                                        break;

                                    default:
                                        repetirPregunta = true;
                                        break;
                                }
                            }
                        } while (repetirPregunta);
                        ingreso = 0;
                        jugador = 1;
                        if (tresEnRaya == true) Resetear();
                        break;

                    } else if (turnos == 10) {
                        Console.WriteLine("\n¡Empate!");
                        Console.WriteLine();
                        Console.WriteLine("Quiere reiniciar el juego? Si/No");
                        bool repetirPregunta = true;
                        do {
                            String pregunta = Console.ReadLine().ToLower().TrimStart().TrimEnd();
                            if (pregunta != null) {

                                switch (pregunta) {
                                    case "si":
                                        tresEnRaya = true; repetirPregunta = false;
                                        break;

                                    case "no":
                                        tresEnRaya = false; repetirPregunta = false;
                                        break;

                                    default:
                                        repetirPregunta = true;
                                        break;
                                }
                            }
                        } while (repetirPregunta);
                        ingreso = 0;
                        jugador = 1; if (tresEnRaya == true) Resetear();
                        break;
                    }


                }
                if (tresEnRaya == false) {
                    break;
                }
                //Código que verifica si el valor ingresado es válido
                if (jugador == 1) {
                    do {
                        Console.WriteLine("\nPor favor elije un casillero para poner tu signo");
                        try {
                            ingreso = Convert.ToInt32(Console.ReadLine());
                        } catch {

                        }
                        if ((ingreso == 1) && (tableroJuego[0, 0] == "[1]"))
                            ingresoCorrecto = true;
                        else if ((ingreso == 2) && (tableroJuego[0, 1] == "[2]"))
                            ingresoCorrecto = true;
                        else if ((ingreso == 3) && (tableroJuego[0, 2] == "[3]"))
                            ingresoCorrecto = true;
                        else if ((ingreso == 4) && (tableroJuego[1, 0] == "[4]"))
                            ingresoCorrecto = true;
                        else if ((ingreso == 5) && (tableroJuego[1, 1] == "[5]"))
                            ingresoCorrecto = true;
                        else if ((ingreso == 6) && (tableroJuego[1, 2] == "[6]"))
                            ingresoCorrecto = true;
                        else if ((ingreso == 7) && (tableroJuego[2, 0] == "[7]"))
                            ingresoCorrecto = true;
                        else if ((ingreso == 8) && (tableroJuego[2, 1] == "[8]"))
                            ingresoCorrecto = true;
                        else if ((ingreso == 9) && (tableroJuego[2, 2] == "[9]"))
                            ingresoCorrecto = true;
                        else {
                            if (jugador == 1) {
                                Console.WriteLine("\nPor favor ingrese otro número");
                            }
                            ingresoCorrecto = false;
                        }

                    } while (!ingresoCorrecto);

                } else if (jugador == 2) {
                    do {
                        ingreso = turnoMaquina.Next(10);

                        if ((ingreso == 1) && (tableroJuego[0, 0] == "[1]"))
                            ingresoCorrecto = true;
                        else if ((ingreso == 2) && (tableroJuego[0, 1] == "[2]"))
                            ingresoCorrecto = true;
                        else if ((ingreso == 3) && (tableroJuego[0, 2] == "[3]"))
                            ingresoCorrecto = true;
                        else if ((ingreso == 4) && (tableroJuego[1, 0] == "[4]"))
                            ingresoCorrecto = true;
                        else if ((ingreso == 5) && (tableroJuego[1, 1] == "[5]"))
                            ingresoCorrecto = true;
                        else if ((ingreso == 6) && (tableroJuego[1, 2] == "[6]"))
                            ingresoCorrecto = true;
                        else if ((ingreso == 7) && (tableroJuego[2, 0] == "[7]"))
                            ingresoCorrecto = true;
                        else if ((ingreso == 8) && (tableroJuego[2, 1] == "[8]"))
                            ingresoCorrecto = true;
                        else if ((ingreso == 9) && (tableroJuego[2, 2] == "[9]"))
                            ingresoCorrecto = true;
                        else {
                            ingresoCorrecto = false;
                        }
                    } while (!ingresoCorrecto && turnos != 9);
                }

            } while (tresEnRaya);


        }

        //Método para identificar Jugador
        public static void PonerXoO(int jugador, int ingreso) {
            string signo = "";

            if (jugador == 1) {
                signo = "X";
            } else if (jugador == 2) {
                signo = "O";
            }

            switch (ingreso) {
                case 1: tableroJuego[0, 0] = " " + signo + " "; break;
                case 2: tableroJuego[0, 1] = " " + signo + " "; break;
                case 3: tableroJuego[0, 2] = " " + signo + " "; break;
                case 4: tableroJuego[1, 0] = " " + signo + " "; break;
                case 5: tableroJuego[1, 1] = " " + signo + " "; break;
                case 6: tableroJuego[1, 2] = " " + signo + " "; break;
                case 7: tableroJuego[2, 0] = " " + signo + " "; break;
                case 8: tableroJuego[2, 1] = " " + signo + " "; break;
                case 9: tableroJuego[2, 2] = " " + signo + " "; break;
            }
        }

        //Array que contiene variables del juego
        static string[,] tableroJuego =
        {
            {"[1]","[2]","[3]" },
            {"[4]","[5]","[6]" },
            {"[7]","[8]","[9]" }
        };
        static int turnos = 0;

        //Método que Crea el Tablero
        public static void CreaTablero() {
            Console.Clear();
            Console.WriteLine("       |       |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", tableroJuego[0, 0], tableroJuego[0, 1], tableroJuego[0, 2]);
            Console.WriteLine("_______|_______|_____");
            Console.WriteLine("       |       |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", tableroJuego[1, 0], tableroJuego[1, 1], tableroJuego[1, 2]);
            Console.WriteLine("_______|_______|_____");
            Console.WriteLine("       |       |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", tableroJuego[2, 0], tableroJuego[2, 1], tableroJuego[2, 2]);
            Console.WriteLine("       |       |");
            turnos++;
        }

        //Método que reinicia todo el juego
        public static void Resetear() {
            tableroJuego[0, 0] = "[1]";
            tableroJuego[0, 1] = "[2]";
            tableroJuego[0, 2] = "[3]";
            tableroJuego[1, 0] = "[4]";
            tableroJuego[1, 1] = "[5]";
            tableroJuego[1, 2] = "[6]";
            tableroJuego[2, 0] = "[7]";
            tableroJuego[2, 1] = "[8]";
            tableroJuego[2, 2] = "[9]";

            CreaTablero();
            turnos = 0;

        }
    }
}
