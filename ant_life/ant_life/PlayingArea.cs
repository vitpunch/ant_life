using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ant_life
{
    //содержит игровое поле. Клетки.
    static class PlayingArea
    {
        const int XSIZE = 1000;
        const int YSIZE = 1000;

        static Cell[,] cell = new Cell[XSIZE, YSIZE];
               
        static public void ClearFromObject(int id)
        {
            //очищает поле от сдохшего объекта и сдвигает нумерацию бОльших номеров
            for (int y = 0; y < YSIZE; y++)
                for (int x = 0; x < XSIZE; x++)
                {
                    cell[x, y].DownId(id);                    
                }
        }
    }
}
