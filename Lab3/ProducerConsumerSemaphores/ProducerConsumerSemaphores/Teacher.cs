using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProducerConsumerSemaphores
{
    class Teacher
    {
        public static void teacher()
        {
            int num = 0;
            while (true)
            {
                num++;

                Program.semFull.WaitOne(); //wait signal
                    Thread.Sleep(Program.rand.Next(10) * 500); //sleep for a random amount of time to produce
                    Program.cBuffer.Put(num); //put in buffer
                    Console.WriteLine("Teacher posted assignment " + num);
                Program.semEmpty.Release(); //allow others to access resource
                if (num > Program.size - 1) //reset num when reaches size
                {
                    num = 0;
                }
            }
        }
    }
}
