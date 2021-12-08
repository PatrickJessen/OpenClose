using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    /// <summary>
    /// Container interface
    /// </summary>
    public interface IContainer
    {
        // Size of the container
        public int Size { get; set; }
        // To check if its full or not
        public bool IsFull { get; set; }
    }
}
