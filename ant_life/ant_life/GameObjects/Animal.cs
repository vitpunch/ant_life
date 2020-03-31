using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ant_life
{
    class Animal : GameObject
    {
        int health;         //текущее количество здоровья
        protected int maxHealth;      //максимально возможное кол-во здоровья 100%
        int attakPower;     //сила атаки
        int defensePower;   //сила защиты
        int speedOfMovement;//скорость передвижения (наверное в милисекундах на ход
        int speedOfAction;  //скорость действия
        int direction;      //направление движения в градусах
        int distanceOfAttak;//дальность атаки в клетках
        int width;          //толщина животного, для расчёта площади атаки и занимаемого места
    }
}
