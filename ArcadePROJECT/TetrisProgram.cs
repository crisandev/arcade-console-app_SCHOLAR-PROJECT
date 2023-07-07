using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Media;

namespace ArcadePROJECT {
   public class ProgramTetris {

        public static int[,] areaJuego = new int[23, 10];
        public static int[,] posicionCaidaPiezaEnGrid = new int[23, 10];
        public static string cuadrado = "■";
        public static Stopwatch temporizador = new Stopwatch();
        public static Stopwatch temporizadorCaida = new Stopwatch();
        public static Stopwatch temporizadorEntrada = new Stopwatch();
        public static int timepoCaida, velocidadCaida = 300;
        public static bool dejarCaer = false;
        static Tetrimino tetrimino;
        static Tetrimino proximoTetrimino;
        public static ConsoleKeyInfo tecla;
        public static bool teclaPulsada = true;
        public static int lineasConseguidas = 0, puntos = 0, nivel = 1;

        public void TETRISPrincipal() {
            pintarAreaJuego();

            Console.SetCursorPosition(4, 5);
            Console.WriteLine("Pulsa una tecla");
            Console.ReadKey(true);
            //SoundPlayer sp = new SoundPlayer();
            //sp.SoundLocation = Environment.CurrentDirectory + "\\Tetris.wav";
            //sp.PlayLooping();
            temporizador.Start();
            temporizadorCaida.Start();
            long time = temporizador.ElapsedMilliseconds;
            Console.SetCursorPosition(25, 0);
            Console.WriteLine("Nivel " + nivel);
            Console.SetCursorPosition(25, 1);
            Console.WriteLine("Puntos " + puntos);
            Console.SetCursorPosition(25, 2);
            Console.WriteLine("Lineas " + lineasConseguidas);
            proximoTetrimino = new Tetrimino();
            //Asignamos la pieza creada a la actual
            tetrimino = proximoTetrimino;
            //La dibujamos en el grid
            tetrimino.Aparecer();
            //Obtenemos la siguiente pieza
            proximoTetrimino = new Tetrimino();

            Actualizar();


            //sp.Stop();
            //sp.SoundLocation = Environment.CurrentDirectory + "\\Retro-game-over-sound-effect.wav";
            //sp.Play();
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine(@"
                                ______      ________ _____  
                               / __ \ \    / /  ____|  __ \ 
   __ _  __ _ _ __ ___   ___  | |  | \ \  / /| |__  | |__) |
  / _` |/ _` | '_ ` _ \ / _ \ | |  | |\ \/ / |  __| |  _  / 
 | (_| | (_| | | | | | |  __/ | |__| | \  /  | |____| | \ \ 
  \__, |\__,_|_| |_| |_|\___|  \____/   \/   |______|_|  \_\
   __/ |                                                    
  |___/                                                     
");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
TU NIVEL FUE                = {0}
TU PUNTUACION FINAL FUE     = {1}
", nivel, puntos);
            Console.ResetColor();

            Console.WriteLine(@"
|---------------------------------------------------------|
|            ¿DESEAS INTENTARLO DE NUEVO?                 |
|                                                         |
|                       PRESIONA:                         |
|                    y = Continuar                        |
|                                                         |
|         O PRESION CUALQUIER TECLA PARA SALIR            |
|---------------------------------------------------------|
");
            string teclaPulsada = Console.ReadLine()!;

            if (teclaPulsada.ToUpper() == "Y") {
                int[,] areaJuego = new int[23, 10];
                posicionCaidaPiezaEnGrid = new int[23, 10];
                temporizador = new Stopwatch();
                temporizadorCaida = new Stopwatch();
                temporizadorEntrada = new Stopwatch();
                velocidadCaida = 300;
                dejarCaer = false;
                ProgramTetris.teclaPulsada = false;
                lineasConseguidas = 0;
                puntos = 0;
                nivel = 1;
                GC.Collect();
                Console.Clear();
                TETRISPrincipal();
            } else {
                int[,] areaJuego = new int[23, 10];
                posicionCaidaPiezaEnGrid = new int[23, 10];
                temporizador = new Stopwatch();
                temporizadorCaida = new Stopwatch();
                temporizadorEntrada = new Stopwatch();
                velocidadCaida = 300;
                dejarCaer = false;
                ProgramTetris.teclaPulsada = false;
                lineasConseguidas = 0;
                puntos = 0;
                nivel = 1;
                GC.Collect();
                Console.Clear();
            };

        }

        private static void Actualizar() {
            while (true) {
                timepoCaida = (int)temporizadorCaida.ElapsedMilliseconds;
                if (timepoCaida > velocidadCaida) {
                    timepoCaida = 0;
                    temporizadorCaida.Restart();
                    tetrimino.Soltar();
                }
                if (dejarCaer == true) {
                    tetrimino = proximoTetrimino;
                    proximoTetrimino = new Tetrimino();
                    tetrimino.Aparecer();

                    dejarCaer = false;
                }
                int j;
                for (j = 0; j < 10; j++) {
                    if (posicionCaidaPiezaEnGrid[0, j] == 1)
                        return;
                }

                Pulsacion();
                moverBloque();
            }
        }
        private static void moverBloque() {
            int combo = 0;
            for (int i = 0; i < 23; i++) {
                int j;
                for (j = 0; j < 10; j++) {
                    if (posicionCaidaPiezaEnGrid[i, j] == 0)
                        break;
                }
                if (j == 10) {
                    lineasConseguidas++;
                    combo++;
                    for (j = 0; j < 10; j++) {
                        posicionCaidaPiezaEnGrid[i, j] = 0;
                    }
                    int[,] newdroppedtetrominoeLocationGrid = new int[23, 10];
                    for (int k = 1; k < i; k++) {
                        for (int l = 0; l < 10; l++) {
                            newdroppedtetrominoeLocationGrid[k + 1, l] = posicionCaidaPiezaEnGrid[k, l];
                        }
                    }
                    for (int k = 1; k < i; k++) {
                        for (int l = 0; l < 10; l++) {
                            posicionCaidaPiezaEnGrid[k, l] = 0;
                        }
                    }
                    for (int k = 0; k < 23; k++)
                        for (int l = 0; l < 10; l++)
                            if (newdroppedtetrominoeLocationGrid[k, l] == 1)
                                posicionCaidaPiezaEnGrid[k, l] = 1;
                    Dibujar();
                }
            }
            if (combo == 1)
                puntos += 40 * nivel;
            else if (combo == 2)
                puntos += 100 * nivel;
            else if (combo == 3)
                puntos += 300 * nivel;
            else if (combo > 3)
                puntos += 300 * combo * nivel;

            if (lineasConseguidas < 5) nivel = 1;
            else if (lineasConseguidas < 10) nivel = 2;
            else if (lineasConseguidas < 15) nivel = 3;
            else if (lineasConseguidas < 25) nivel = 4;
            else if (lineasConseguidas < 35) nivel = 5;
            else if (lineasConseguidas < 50) nivel = 6;
            else if (lineasConseguidas < 70) nivel = 7;
            else if (lineasConseguidas < 90) nivel = 8;
            else if (lineasConseguidas < 110) nivel = 9;
            else if (lineasConseguidas < 150) nivel = 10;


            if (combo > 0) {
                Console.SetCursorPosition(25, 0);
                Console.WriteLine("Nivel " + nivel);
                Console.SetCursorPosition(25, 1);
                Console.WriteLine("Puntos " + puntos);
                Console.SetCursorPosition(25, 2);
                Console.WriteLine("Lineas Conseguidas " + lineasConseguidas);
            }

            velocidadCaida = 300 - 22 * nivel;

        }
        private static void Pulsacion() {
            if (Console.KeyAvailable) {
                tecla = Console.ReadKey();
                teclaPulsada = true;
            } else
                teclaPulsada = false;

            if (ProgramTetris.tecla.Key == ConsoleKey.LeftArrow & !tetrimino.HayAlgoIzquierda() & teclaPulsada) {
                for (int i = 0; i < 4; i++) {
                    tetrimino.posicion[i][1] -= 1;
                }
                tetrimino.Actualizar();

            } else if (ProgramTetris.tecla.Key == ConsoleKey.RightArrow & !tetrimino.HayAlgoDerecha() & teclaPulsada) {
                for (int i = 0; i < 4; i++) {
                    tetrimino.posicion[i][1] += 1;
                }
                tetrimino.Actualizar();
            }
            if (ProgramTetris.tecla.Key == ConsoleKey.DownArrow & teclaPulsada) {
                tetrimino.Soltar();
            }
            if (ProgramTetris.tecla.Key == ConsoleKey.DownArrow & teclaPulsada) {
                for (; tetrimino.HayAlgoDebajo() != true;) {
                    tetrimino.Soltar();
                }
            }
            if (ProgramTetris.tecla.Key == ConsoleKey.UpArrow & teclaPulsada) {

                tetrimino.Rotar();
                tetrimino.Actualizar();
            }
        }
        public static void Dibujar() {
            for (int i = 0; i < 23; ++i) {
                for (int j = 0; j < 10; j++) {
                    Console.SetCursorPosition(1 + 2 * j, i);
                    if (areaJuego[i, j] == 1 | posicionCaidaPiezaEnGrid[i, j] == 1) {
                        Console.SetCursorPosition(1 + 2 * j, i);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(cuadrado);
                        Console.ForegroundColor = ConsoleColor.White;
                    } else {
                        Console.Write("  ");
                    }
                }

            }
        }

        public static void pintarAreaJuego() {

            Console.ForegroundColor = ConsoleColor.Green;

            for (int lengthCount = 0; lengthCount <= 22; ++lengthCount) {
                Console.SetCursorPosition(0, lengthCount);
                Console.Write("▒");
                Console.SetCursorPosition(21, lengthCount);
                Console.Write("▒");
            }
            Console.SetCursorPosition(0, 23);
            for (int widthCount = 0; widthCount <= 10; widthCount++) {
                Console.Write("▒▒");
            }


            Console.ForegroundColor = ConsoleColor.White;

        }

    }


}

