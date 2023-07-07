using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadePROJECT {

    class ProgramSerpiente {


        public void Serpiente() {


            bool finished = false;
            Canvas canvas = new Canvas();
            Snake snake = new Snake();
            Food food = new Food();
            while (!finished) {
                try {
                    canvas.drawCanvas();
                    Console.SetCursorPosition(53, 1);
                    Console.WriteLine("SCORE {0}", snake.score);
                    snake.Input();
                    food.drawFood();
                    snake.drawSnake();
                    snake.moveSnake();
                    snake.eat(food.foodLocation(), food);
                    snake.isDead();
                    snake.hitWall(canvas);

                } catch (SnakeExeptions e) {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                    Console.WriteLine(@"
        |-------------------------------|
        |   DESEAS INTENTARLO DENUEVO   |
        |-------------------------------|
            [1] = SI
            [2] = NO
");
                    string respuesta = Console.ReadLine();
                    switch (respuesta) {
                        case "1":
                            snake.X = 20;
                            snake.Y = 20;
                            snake.score = 0;
                            snake.snakeBody.RemoveRange(0, snake.snakeBody.Count - 1);
                            finished = false;
                            break;
                        default:
                            snake.X = 20;
                            snake.Y = 20;
                            snake.score = 0;
                            snake.snakeBody.RemoveRange(0, snake.snakeBody.Count - 1);
                            finished = true;
                            break;
                    }
                }
            }
        }
    }
}