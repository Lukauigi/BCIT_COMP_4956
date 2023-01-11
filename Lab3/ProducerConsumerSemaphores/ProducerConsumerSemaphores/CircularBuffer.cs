using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProducerConsumerSemaphores
{
    class CircularBuffer<T> : Queue<T>
    {
        public CircularBuffer(int size) : base(size)
        {
        }
        
        public void Put(T qValue)
        {
            Monitor.Enter(this);
            try
            {
                Enqueue(qValue);
            }
            finally
            {
                Monitor.Exit(this);
            }
        }
       
        public T Get()
        {
            Monitor.Enter(this);
            try
            {
                return Dequeue();
            }
            finally
            {
                Monitor.Exit(this);
            }
        }
    }
}
