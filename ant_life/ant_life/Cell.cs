using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ant_life
{
    struct Cell
    {
        int smellOfDanger;  //запах опасности в этой ячейке
        int smellOfEat;     //запах еды
        int amountOfFood;   //количество еды в клетке
        int idOfObject;     //номер объекта из списка объектов, если 0 - пустота
        public void DownId(int id)
        {   //уменьшает id объекта. Используется после удаления объекта из списка
            if (idOfObject == id)
                idOfObject = 0;
            if (idOfObject > id)
                idOfObject--;
        }
    }
}
