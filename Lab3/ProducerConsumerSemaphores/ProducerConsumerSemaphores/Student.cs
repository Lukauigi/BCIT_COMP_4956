using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProducerConsumerSemaphores
{
    class Student
    {
        public static void student()
        {
            while (true)
            {
                Program.semEmpty.WaitOne(); //wait signal
                Thread.Sleep(Program.rand.Next(10) * 1000); //wait to consume
                int num = Program.cBuffer.Get(); //get from buffer queue
                    Console.Out.Write("Student solved assignment " + num);
                Console.WriteLine("");
                Program.semFull.Release(); //signal done
            }
        }
    }
}
