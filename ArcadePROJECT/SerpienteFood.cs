using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadePROJECT {
    public class Food {
        public Position foodPos = new Position();

        Random random = new Random();
        Canvas canvas = new Canvas();

        public Food() {
            foodPos.X = random.Next(5, canvas.Width);
            foodPos.Y = random.Next(5, canvas.Heigth);
        }

        public void drawFood() {

            Console.SetCursorPosition(foodPos.X, foodPos.Y);
            Console.Write("█");
        }

        public Position foodLocation() {
            return foodPos;
        }

        public void foodNewLocation() {
            foodPos.X = random.Next(5, canvas.Width);
            foodPos.Y = random.Next(5, canvas.Heigth);

        }
    }
}
