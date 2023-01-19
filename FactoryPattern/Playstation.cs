using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Playstation : IGameConsole
    {
        public void GameConsole()
        {
            Console.WriteLine("Playstation is the best console made by Sony");
        }
    }
}
