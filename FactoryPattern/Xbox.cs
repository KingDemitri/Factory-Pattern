using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Xbox :IGameConsole
    {
        public void GameConsole()
        {
            Console.WriteLine("Xbox is the best console made by Microsoft");
        }
    }
}
