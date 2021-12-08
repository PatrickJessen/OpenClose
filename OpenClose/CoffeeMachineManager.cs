using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    public class CoffeeMachineManager : IPourLiquid
    {
        public int WaterCapacity { get; set; }
        public int BeanCapacity { get; set; }
        public LiquidContainer LiquidContainer { get; set; }
        public BeanContainer BeanContainer { get; set; }
        public Liquid Liquid { get; set; }
        public bool LiquidPoured { get; set; }
        public bool BeansAdded { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="waterCapacity">how much can the liquid container hold</param>
        /// <param name="beanCapacity">how much can the bean container hold</param>
        /// <param name="liquid">type of liquid</param>
        public CoffeeMachineManager(int liquidCapacity, int beanCapacity, Liquid liquid)
        {
            WaterCapacity = liquidCapacity;
            BeanCapacity = beanCapacity;
            Liquid = liquid;
            LiquidContainer = new LiquidContainer(liquidCapacity, liquid);
            BeanContainer = new BeanContainer(beanCapacity);
        }

        /// <summary>
        /// Pours liquid into the liquid container
        /// </summary>
        /// <param name="amount">amount of liquid to pour</param>
        public void PourLiquid(int amount)
        {
            LiquidContainer.Liquid.LiquidAmount = amount;
            while (!LiquidContainer.IsFull)
            {
                LiquidContainer.Liquid.LiquidAmount--;
                if (LiquidContainer.Liquid.LiquidAmount <= 0)
                    LiquidContainer.IsFull = true;
            }
            LiquidPoured = true;
        }

        /// <summary>
        /// Adds beans to the bean container
        /// </summary>
        /// <param name="amount">amount of beans to add</param>
        public void AddBeans(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                if (IsCapacityLimit(amount))
                {
                    BeansAdded = true;
                    return;
                }
                BeanContainer.Beans[i] = new Bean();
            }
        }

        /// <summary>
        /// Checks if the bean container is filled
        /// </summary>
        /// <param name="amount">amount of beans</param>
        /// <returns>returns true if bean container is full else false</returns>
        private bool IsCapacityLimit(int amount)
        {
            if (BeanContainer.Beans.Length < amount)
            {
                BeanContainer.IsFull = true;
                return true;
            }
            return false;
        }
    }
}
