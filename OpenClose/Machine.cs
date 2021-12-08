using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
   /// <summary>
   /// Abstract class that represents a machine
   /// </summary>
    public abstract class Machine
    {
        public bool IsRunning { get; protected set; }

        /// <summary>
        /// Starts the machine
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// Stops the machine
        /// </summary>
        public abstract void Stop();
    }
}
