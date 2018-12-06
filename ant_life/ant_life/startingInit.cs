using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ant_life
{
    class StartingInit
    {
        int windowWidth = 200;
        int windowHeigh = 55;
        static int mapWidth = 500;
        static int mapHeight = 500;
        public Objects[,] map = new Objects[mapWidth, mapHeight];


        public void start()
        {
            Screen screen = new Screen();

            // инициализируем окно
            Console.SetWindowSize(windowWidth, windowHeigh);
            Console.SetBufferSize(windowWidth, windowHeigh);

            // размер видимой части карты
            screen.widthOfVisible = 30;
            screen.heightOfVisible = 30;
            
            // создаём массив карты
            
            for (int x = 0; x < mapWidth; x++)
            {
                for (int y = 0; y < mapHeight; y++)
                {
                    map[x, y] = new Objects();
                }

            }
            //map[1, 1] = new Objects();
            map[1, 1].valuee = 10;

            Console.WriteLine("Инициализировано...");
        }
    }
}
