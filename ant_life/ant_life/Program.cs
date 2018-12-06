using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ant_life
{
    class Program
    {
        static void Main()
        {
            StartingInit init = new StartingInit();
            init.start();
            Console.WriteLine(init.map[1, 1].valuee);

            Console.ReadLine();
        }
    }
}
