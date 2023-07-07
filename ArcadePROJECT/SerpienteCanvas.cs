

using System;

namespace ArcadePROJECT {

    public class Canvas {
        public int Width { get; set; }
        public int Heigth { get; set; }

        public Canvas() {
            Width = 50;
            Heigth = 30;
            Console.CursorVisible = false;
        }
        public void drawCanvas() {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            for (int i = 0; i < Width; ++i) {
                Console.SetCursorPosition(i, 0);
                Console.Write("-");
            }
            for (int i = 0; i < Width; ++i) {
                Console.SetCursorPosition(i, Heigth);
                Console.Write("-");
            }
            for (int i = 0; i < Heigth; ++i) {
                Console.SetCursorPosition(0, i);
                Console.Write("|");
            }
            for (int i = 0; i < Heigth; ++i) {
                Console.SetCursorPosition(Width, i);
                Console.Write("|");
            }
            Console.ResetColor();
        }
    }

}