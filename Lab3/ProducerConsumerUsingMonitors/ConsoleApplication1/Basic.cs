using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Basic
    {
        protected CircularBuffer sharedBuffer;
        protected int sleepTime;
        protected int itemCount;

        public Basic(CircularBuffer buffer, int sleepTime)
        {
            this.sleepTime = sleepTime;
            sharedBuffer = buffer;
            itemCount = 0;
        }
    }
}

