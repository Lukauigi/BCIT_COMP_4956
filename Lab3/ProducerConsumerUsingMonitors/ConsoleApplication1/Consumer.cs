using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Consumer: Basic
    {
        public Consumer(CircularBuffer buffer, int sleepTime) : base(buffer, sleepTime) { }

        public void Consume()
        {
            while (true)
            {
                Thread.Sleep(sleepTime);
                sharedBuffer.removeItem();
            }
        }
    }
}
