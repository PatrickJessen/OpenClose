using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    /// <summary>
    /// Abstract liquid class
    /// </summary>
    public abstract class Liquid
    {
        public int LiquidAmount { get; set; }

        public Liquid(int liquidAmount)
        {
            LiquidAmount = liquidAmount;
        }
    }
}
