using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenClose
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Machine coffeeMachine = new CoffeeMachine(20, 14, new Tea(10), 0);
            Thread t = new Thread(coffeeMachine.Start);
            t.Start();
            Thread.Sleep(6000);
            t.Join();
            Console.WriteLine(((CoffeeMachine)coffeeMachine).CoffeeBrewed().LiquidAmount);
        }
    }
}