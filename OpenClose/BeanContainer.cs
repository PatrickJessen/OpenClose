using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    /// <summary>
    /// Represents a bean container
    /// </summary>
    public class BeanContainer : IContainer
    {
        public int Size { get; set; }
        public bool IsFull { get; set; }
        public Bean[] Beans { get; set; }

        public BeanContainer(int size)
        {
            Size = size;
            Beans = new Bean[Size];
        }
    }
}
