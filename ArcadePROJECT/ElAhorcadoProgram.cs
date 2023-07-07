using System;
namespace ArcadePROJECT {
    class ProgramAhorcado {
        public void elAhorcado() {
            string[,] matriz = new string[8, 6];
            string palabra = "null";
            bool jugar = true;
            int intentos = 0;
            string letra = " ";
            char Letrachar = ' ';
            string volverjugar = " ";
            int Gano = 0;
            int contador = 0;                              // " Primera Parte" 
            while (jugar == true) {
                palabra = escojerPalabra(palabra);
                char[] palabravector = palabra.ToCharArray();
                char[] espaciosEnBlanco = new char[palabra.Length];
                for (int i = 0; i < palabra.Length; i++) espaciosEnBlanco[i] = '_';
                Gano = 0;
                while (intentos <= 6) {
                    bool letraMayorQueUno = true;
                    tablero(matriz, intentos);
                    MostrarMatriz(matriz);
                    Console.WriteLine();                            // "Segunda Parte"
                    MostrarEpaciosEnBlanco(espaciosEnBlanco);
                    Console.WriteLine();
                    while (letraMayorQueUno == true) {
                        Console.Write("dijite la letra: ");
                        letra = Console.ReadLine();
                        if (letra.Length == 1) {
                            Letrachar = Convert.ToChar(letra);
                            letraMayorQueUno = false;
                        }
                    }

                    for (int i = 0; i < espaciosEnBlanco.Length; i++) {
                        if (Letrachar == espaciosEnBlanco[i]) {
                            Console.WriteLine("esa letra ya estaba,Ingrese otra");
                            Console.ReadKey();
                            contador++;
                        } else {
                            if (Letrachar == palabravector[i]) {
                                espaciosEnBlanco[i] = Letrachar;
                                contador++;
                                Gano++;
                            }
                        }
                    }
                    if (contador == 0) {
                        intentos++;
                    }
                    if (Gano == palabra.Length) break;
                    else contador = 0;
                }
                if (Gano == palabra.Length) {
                    tablero(matriz, intentos);
                    MostrarMatriz(matriz);
                    Console.WriteLine();
                    MostrarEpaciosEnBlanco(espaciosEnBlanco);
                    Console.WriteLine();
                    Console.WriteLine("!Si la palabra era {0} ,acabas de ganar !! quieres volver a jugar? : S / N", palabra);
                    volverjugar = Console.ReadLine();
                    if (volverjugar == "n") jugar = false;
                    else intentos = 0;
                } else {
                    Console.WriteLine("se te acabaron los intentos la palabra era {0} quieres jugar de nuevo? : S /  N", palabra);
                    volverjugar = Console.ReadLine();
                    if (volverjugar == "n") jugar = false;

                    else intentos = 0;
                }

            }
        }
        static void MostrarEpaciosEnBlanco(char[] Espacios) {
            for (int i = 0; i < Espacios.Length; i++) {
                Console.Write(Espacios[i] + " ");
            }
        }
        static string[,] tablero(string[,] matriz, int intentos) {
            Console.Clear();
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int k = 0; k < matriz.GetLength(1); k++) {
                    matriz[i, k] = " ";
                }
            }
            for (int i = 0; i < 6; i++) matriz[0, i] = "_";
            for (int k = 1; k < 7; k++) matriz[k, 1] = "|";
            for (int j = 0; j < 6; j++) matriz[7, j] = "_";
            if (intentos >= 1) matriz[3, 4] = "O";
            if (intentos >= 2) matriz[4, 4] = "|";
            if (intentos >= 3) matriz[5, 3] = "/";
            if (intentos >= 4) matriz[5, 5] = @"\";
            if (intentos >= 5) matriz[4, 3] = "-";
            if (intentos >= 6) matriz[4, 5] = "-";
            matriz[1, 4] = "|";
            matriz[2, 4] = "|";
            return matriz;
        }
        static void MostrarMatriz(string[,] matriz) {
            int pasarcolumnna = 0;
            int pasarfila = 0;
            while (pasarfila <= 7) {
                while (pasarcolumnna <= 5) {
                    Console.Write(matriz[pasarfila, pasarcolumnna]);
                    pasarcolumnna++;
                    if (pasarcolumnna > 5) Console.WriteLine();
                }
                pasarcolumnna = 0;
                pasarfila++;
            }

        }
        static string escojerPalabra(string palabra) {
            string[] palabras = new string[16] { "hamburguesa", "refresco", "papas", "chimi", "yaroa", "empanada", "pizza", "cachapas", "aguacate", "arroz", "habichuela", "picapollo", "fritos", "mangu", "manzana", "uva" };
            Random nroaleatorio = new Random();
            palabra = palabras[nroaleatorio.Next(10)];
            return palabra;
        }
    }
}