using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Producer: Basic
    {
        public Producer(CircularBuffer buffer, int sleepTime) : base(buffer, sleepTime) { }

        public void Produce()
        {
            while (true)
            {
                Thread.Sleep(sleepTime);
                sharedBuffer.AddItem(itemCount++);
            }
        }
    }
}
