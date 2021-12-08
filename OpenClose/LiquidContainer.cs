using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    /// <summary>
    /// Represents a liquid container
    /// </summary>
    public class LiquidContainer : IContainer
    {
        public int Size { get; set; }
        public bool IsFull { get; set; }
        public Liquid Liquid { get; set; }

        public LiquidContainer(int size, Liquid liquid)
        {
            Size = size;
            Liquid = liquid;
        }
    }
}
