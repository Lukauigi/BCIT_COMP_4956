using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    public class SynchronizedCircularBuffer: CircularBuffer
    {
        /// <summary>
        /// consructor
        /// </summary>
        /// <param name="buffSize"></param>
        public SynchronizedCircularBuffer(int buffSize) : base(buffSize) { }

        /// <summary>
        /// Add monitor syncrhonization to the base class's AddItem
        /// </summary>
        /// <param name="item"></param>
        public override void AddItem(int item)
        {
            Monitor.Enter(this);
            while (IsFull)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " Wait on buffer full");
                Monitor.Wait(this);
            }
                
            base.AddItem(item);

            Console.WriteLine(Thread.CurrentThread.Name + " writes " + item.ToString());

            Monitor.Pulse(this);
            Monitor.Exit(this);
        }

        /// <summary>
        /// Add monitor syncrhonization to the base class's RemoveItem
        /// </summary>
        /// <returns></returns>
        public override int removeItem()
        {
            Monitor.Enter(this);
            while (IsEmpty)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " Wait on buffer empty");
                Monitor.Wait(this);
            }

            int item = base.removeItem();

            Console.WriteLine(Thread.CurrentThread.Name + " reads " + item.ToString());

            Monitor.Pulse(this);
            Monitor.Exit(this);
            return item;
        }
    }
}
