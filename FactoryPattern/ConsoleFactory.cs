using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class ConsoleFactory
    {
        public static IGameConsole GetConsole(string choice)
        {
            switch (choice)
            {
                case "Playstation":
                    return new Playstation();
                case "Xbox":
                    return new Xbox();
                default:
                    Console.WriteLine("Invalid Input. Here is the most popular choice:");
                return new Playstation();
            }
        }
    }
}
