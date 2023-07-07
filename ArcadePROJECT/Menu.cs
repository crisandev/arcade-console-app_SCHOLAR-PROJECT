using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadePROJECT {
    internal class Menu {

        private int SeletedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options) {
            Prompt = prompt;
            Options = options;
            SeletedIndex = 0;
        }

        private ConsoleKey showMenu(ConsoleKey keyPressed) {
            if (keyPressed == ConsoleKey.UpArrow) {
                SeletedIndex--;
                if (SeletedIndex == -1) {
                    SeletedIndex = Options.Length - 1;
                }
            } else if (keyPressed == ConsoleKey.DownArrow) {
                SeletedIndex++;
                if (SeletedIndex == Options.Length) {
                    SeletedIndex = 0;
                }
            }
            return keyPressed;
        }

        // MENU PRINCIPAL
        private void DisplayOptions() {
            ForegroundColor = ConsoleColor.White;
            WriteLine(Prompt);
            ResetColor();
            for (int i = 0; i < Options.Length; i++) {
                string currentOption = Options[i];

                if (i == SeletedIndex) {
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.DarkBlue;
                } else {
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"    <<{currentOption}>>");
            }
            ResetColor();
        }



        // IMPRIMIR MENU PRINCIPAL
        public int Run() {
            ConsoleKey keyPressed;
            do {
                Clear();
                Texts titles = new Texts();
                titles.Arcade();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                keyPressed = showMenu(keyPressed);

            } while (keyPressed != ConsoleKey.Enter);
            return SeletedIndex;
        }





        //|---------------------------------|
        //|            MENU SERPIENTE       |
        //|---------------------------------|
        public int Serpiente() {
            Texts texts = new Texts();
            string[] textSerpiente = texts.showSnakeMenu();
            ConsoleKey keyPressed;
            do {
                Clear();
                DisplayOptions();
                switch (SeletedIndex) {
                    case 0:
                        WriteLine(textSerpiente[0]);
                        break;
                    case 1:
                        WriteLine(textSerpiente[1]);
                        break;
                    case 2:
                        WriteLine(textSerpiente[2]);
                        break;
                }
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                keyPressed = showMenu(keyPressed);

            } while (keyPressed != ConsoleKey.Enter);
            return SeletedIndex;
        }
        //|---------------------------------|
        //|            MENU 3 RAYAS         |
        //|---------------------------------|
        public int tresRayas() {
            Texts texts = new Texts();
            string[] textTresRayas = texts.showRayasMenu();
            ConsoleKey keyPressed;
            do {
                Clear();
                DisplayOptions();
                switch (SeletedIndex) {
                    case 0:
                        WriteLine(textTresRayas[0]);
                        break;
                    case 1:
                        WriteLine(textTresRayas[1]);
                        break;
                    case 2:
                        WriteLine(textTresRayas[2]);
                        break;
                }
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                keyPressed = showMenu(keyPressed);

            } while (keyPressed != ConsoleKey.Enter);
            return SeletedIndex;
        }


        //|---------------------------------|
        //|       MENU PIEDRA PAPEL         |
        //|---------------------------------|
        public int PiedraPapel() {
            Texts texts = new Texts();
            string[] textPiedraPapel = texts.showPiedraMenu();
            ConsoleKey keyPressed;
            do {
                Clear();
                DisplayOptions();
                switch (SeletedIndex) {
                    case 0:
                        WriteLine(textPiedraPapel[0]);
                        break;
                    case 1:
                        WriteLine(textPiedraPapel[1]);
                        break;
                    case 2:
                        WriteLine(textPiedraPapel[2]);
                        break;
                }
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                keyPressed = showMenu(keyPressed);

            } while (keyPressed != ConsoleKey.Enter);
            return SeletedIndex;
        }


        //|---------------------------------|
        //|       MENU AHORCADO             |
        //|---------------------------------|
        public int Ahorcado() {
            Texts texts = new Texts();
            string[] textAhorcado = texts.showAhorcadoMenu();
            ConsoleKey keyPressed;
            do {
                Clear();
                DisplayOptions();
                switch (SeletedIndex) {
                    case 0:
                        WriteLine(textAhorcado[0]);
                        break;
                    case 1:
                        WriteLine(textAhorcado[1]);
                        break;
                    case 2:
                        WriteLine(textAhorcado[2]);
                        break;
                }
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                keyPressed = showMenu(keyPressed);

            } while (keyPressed != ConsoleKey.Enter);
            return SeletedIndex;
        }


        //|---------------------------------|
        //|            MENU TETRIS          |
        //|---------------------------------|
        public int Tetris() {
            Texts texts = new Texts();
            string[] textTetris = texts.showTetrisMenu();
            ConsoleKey keyPressed;
            do {
                Clear();
                DisplayOptions();
                switch (SeletedIndex) {
                    case 0:
                        WriteLine(textTetris[0]);
                        break;
                    case 1:
                        WriteLine(textTetris[1]);
                        break;
                    case 2:
                        WriteLine(textTetris[2]);
                        break;
                }
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                keyPressed = showMenu(keyPressed);

            } while (keyPressed != ConsoleKey.Enter);
            return SeletedIndex;
        }


    }
}
