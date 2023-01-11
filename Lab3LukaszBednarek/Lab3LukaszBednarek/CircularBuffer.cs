using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

/// <summary>
/// A circular buffer of items of assignments.
/// Author: Lukasz Bednarek
/// Date: November 2022
/// Source: From sample ProducerConsumerSemaphores program project.
/// </summary>
namespace Lab3LukaszBednarek
{
    /// <summary>
    /// A circular buffer of items.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CircularBuffer<T> : Queue<T>
    {
        /// <summary>
        /// Constructs a circular buffer given a size for the buffer.
        /// </summary>
        /// <param name="size"></param>
        public CircularBuffer(int size) : base(size)
        {
        }

        /// <summary>
        /// Puts an item in the circular buffer.
        /// </summary>
        /// <param name="qValue"></param>
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

        /// <summary>
        /// Provides an item from the beginning of the queue.
        /// </summary>
        /// <returns> an item. </returns>
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
