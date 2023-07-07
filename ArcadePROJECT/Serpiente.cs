using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace ArcadePROJECT {
    public class Snake {

        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'w';
        char dir = 'u';
        public List<Position> snakeBody { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int score { get; set; }

        public Snake() {
            X = 20;
            Y = 20;
            score = 0;
            snakeBody = new List<Position>();

            snakeBody.Add(new Position(X, Y));
            Console.CursorVisible = false;


        }
        public void drawSnake() {
            foreach (Position pos in snakeBody) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(pos.X, pos.Y);
                Console.Write("█");
                Console.CursorVisible = false;
                Console.ResetColor();
            }

        }
        public void Input() {
            Console.CursorVisible = false;
            if (Console.KeyAvailable) {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }

        }

        private void direction() {
            if (key == 'w' && dir != 'd') {
                dir = 'u';
            } else if (key == 's' && dir != 'u') {
                dir = 'd';
            } else if (key == 'd' && dir != 'l') {
                dir = 'r';
            } else if (key == 'a' && dir != 'r') {
                dir = 'l';
            }
        }

        public void moveSnake() {
            Console.CursorVisible = false;
            direction();
            if (dir == 'u') {
                Y--;
            } else if (dir == 'd') {
                Y++;
            } else if (dir == 'r') {
                X++;
            } else if (dir == 'l') {
                X--;
            }
            snakeBody.Add(new Position(X, Y));
            snakeBody.RemoveAt(0);
            Thread.Sleep(10);
        }

        public void eat(Position food, Food f) {

            Position head = snakeBody[snakeBody.Count - 1];
            if (head.X == food.X && head.Y == food.Y) {
                snakeBody.Add(new Position(X, Y));
                f.foodNewLocation();
                score++;
            }
        }

        public void isDead() {
            Position head = snakeBody[snakeBody.Count - 1];
            for (int i = 0; i < snakeBody.Count - 2; i++) {
                Position sb = snakeBody[i];
                if (head.X == sb.X && head.Y == sb.Y) {
                    throw new SnakeExeptions("              PERDISTE");
                }
            }
        }

        public void hitWall(Canvas canvas) {
            Position head = snakeBody[snakeBody.Count - 1];
            if (head.X >= canvas.Width || head.X <= 0 || head.Y >= canvas.Heigth || head.Y <= 0) {

                throw new SnakeExeptions("              PERDISTE");
            }

        }
    }
}
