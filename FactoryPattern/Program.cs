using System.Numerics;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1.Create Interface
            //2.Create Classes to conform to Interface
            //3.Create Factory
            //4.Call Factory Method
            //5.Call Interface Method

            Console.WriteLine("Enter ''Playstation'' or ''Xbox''");
            var choice = Console.ReadLine();
            IGameConsole consoleInstance = ConsoleFactory.GetConsole(choice);
            consoleInstance.GameConsole();
        }
    }
}




//Complete the console app to utilize factory pattern by taking a user’s input of how many tires are on a vehicle and, based on their input, creates that type of vehicle.
//Complete this using an interface. You must have at least 2 subclasses. For instance, if I type 4 into the console, the program would create a car or truck,
//or if someone types 2 it would create a motorcycle.

//Feel free to use something other than vehicles if you want to be creative, but the other constraints still apply!

//    Create an Interface named IVehicle that has a stubbed out public void Drive method.
//    Create 2 new public classes that will conform to IVehicle.
//        Example) Car, Motorcycle, BigRig - DONE

//    Note: These classes must conform to IVehicle and implement the Drive() method - which will just Console.WriteLine(“Building a new Car!”) - DONE

//Now we will make our static VehicleFactory class. It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of tires it’s given
//as a parameter
//Call this functionality in the Main method.

//Possible Answer: https://github.com/mvdoyle/FactoryPattern
