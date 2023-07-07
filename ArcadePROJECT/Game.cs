using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadePROJECT {
    internal class Game {

        public int Start() {
            Title = "Arcade";
            int option = selectTheGame();
            return option;
        }

        //|---------------------------------|
        //|  MENU DE CON TODOS LOS JUEGOS   |
        //|---------------------------------|
        public int selectTheGame() {
            Texts text = new Texts();
            string prompt = text.selectGame();
            string[] options = {
                "|        LA SERPIENTE       |",
                "|          3 RAYAS          |",
                "|  PIEDRA, PAPEL O TIJERAS  |",
                "|        EL AHORCADO        |",
                "|          TETRIS           |",
                "|           EXIT            |"
            };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();
            return seletedIndex;
        }


        //|---------------------------------|
        //|  111   MENU DE TODOS LOS JUEGOS    |
        //|---------------------------------|
        public int menuSerpiente(int nameNumber) {
            Texts text = new Texts();
            string prompt = text.nameGame(nameNumber);
            string[] options = {
                "|           PLAY           |",
                "|          CREDITS         |",
                "|           EXIT           |"
            };
            Menu serpienteMenu = new Menu(prompt, options);
            int seletedIndex = serpienteMenu.Serpiente();
            return seletedIndex;
        }


        //|---------------------------------|
        //|  222   MENU DE TODOS LOS JUEGOS    |
        //|---------------------------------|
        public int menuRayas(int nameNumber) {
            Texts text = new Texts();
            string prompt = text.nameGame(nameNumber);
            string[] options = {
                "|           PLAY           |",
                "|          CREDITS         |",
                "|           EXIT           |"
            };
            Menu rayasMenu = new Menu(prompt, options);
            int seletedIndex = rayasMenu.tresRayas();
            return seletedIndex;
        }


        //|---------------------------------|
        //|  333   MENU DE TODOS LOS JUEGOS    |
        //|---------------------------------|
        public int menuPapelOTijera(int nameNumber) {
            Texts text = new Texts();
            string prompt = text.nameGame(nameNumber);
            string[] options = {
                "|           PLAY           |",
                "|          CREDITS         |",
                "|           EXIT           |"
            };
            Menu PiedraMenu = new Menu(prompt, options);
            int seletedIndex = PiedraMenu.PiedraPapel();
            return seletedIndex;
        }


        //|---------------------------------|
        //|  444   MENU DE TODOS LOS JUEGOS    |
        //|---------------------------------|
        public int menuAhorcado(int nameNumber) {
            Texts text = new Texts();
            string prompt = text.nameGame(nameNumber);
            string[] options = {
                "|           PLAY           |",
                "|          CREDITS         |",
                "|           EXIT           |"
            };
            Menu ahorcadoMenu = new Menu(prompt, options);
            int seletedIndex = ahorcadoMenu.Ahorcado();
            return seletedIndex;
        }


        //|---------------------------------|
        //|  555   MENU DE TODOS LOS JUEGOS    |
        //|---------------------------------|
        public int menuTetris(int nameNumber) {
            Texts text = new Texts();
            string prompt = text.nameGame(nameNumber);
            string[] options = {
                "|           PLAY           |",
                "|          CREDITS         |",
                "|           EXIT           |"
            };
            Menu tetrisMenu = new Menu(prompt, options);
            int seletedIndex = tetrisMenu.Tetris();
            return seletedIndex;
        }
    }
}

