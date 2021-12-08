using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    public class CoffeeMachine : Machine
    {
        private CoffeeMachineManager manager;
        private int beanAmount;
        private Liquid liquid;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterCapacity">how much can the liquid container hold</param>
        /// <param name="beanCapacity">how much can the bean container hold</param>
        /// <param name="liquid">type of liquid</param>
        /// <param name="beanAmount">how many beans to put in</param>
        public CoffeeMachine(int waterCapacity, int beanCapacity, Liquid liquid, int beanAmount)
        {
            this.liquid = liquid;
            this.beanAmount = beanAmount;
            manager = new CoffeeMachineManager(waterCapacity, beanCapacity, liquid);
        }
        public override void Start()
        {
            IsRunning = true;
            while (IsRunning)
            {
                BrewCoffee();
            }
        }

        public override void Stop()
        {
            IsRunning = false;
        }

        /// <summary>
        /// Starts brewing the coffee once everything has been added to the coffe machine
        /// </summary>
        private void BrewCoffee()
        {
            if (IsReady())
            {
                Stop();
                return;
            }
            manager.PourLiquid(liquid.LiquidAmount);
            manager.AddBeans(beanAmount);
        }

        /// <summary>
        /// Gets the brewed coffee ones its done
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>returns the brewed coffee if its ready</returns>
        public Liquid CoffeeBrewed(int amount = 10)
        {
            if (IsReady())
                return new Coffee(amount);
            return null;
        }

        /// <summary>
        /// Checks if liquid has been poured into the liquid container and if beans has been added to the bean container
        /// </summary>
        /// <returns>returns true if liquid has been poured into the liquid container and if beans has been added to the bean container else false</returns>
        private bool IsReady()
        {
            if (manager.LiquidPoured && manager.BeansAdded)
                return true;
            return false;
        }
    }
}
