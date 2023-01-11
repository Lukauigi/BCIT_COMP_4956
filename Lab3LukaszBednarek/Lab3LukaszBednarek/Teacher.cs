using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

/// <summary>
/// Module of a teacher as a producer in the producer-consumer design pattern.
/// Author: Lukasz Bednarek
/// Date: November 2022
/// Source: From sample ProducerConsumerSemaphores program project.
/// </summary>
namespace Lab3LukaszBednarek
{
    /// <summary>
    /// A teacher.
    /// </summary>
    class Teacher
    {
        /*
        /// <summary>
        /// Runs a teacher producer.
        /// </summary>
        public static void teacher()
        {
            int num = 0;
            while (true)
            {
                num++;
                
                Program.semFull.WaitOne(); //wait signal
                Thread.Sleep(Program.rand.Next(10) * 500); //sleep for a random amount of time to produce
                Program.cBuffer.Put(num); //put in buffer
                //Console.WriteLine("Teacher posted assignment " + num);
                Program.semEmpty.Release(); //allow others to access resource
                if (num > Program.size - 1) //reset num when reaches size
                {
                    num = 0;
                }
            }
        }

        /// <summary>
        /// Returns a message after creating an assignment.
        /// </summary>
        /// <param name="num"> the assignment number. </param>
        /// <returns> message of assignment creation. </returns>
        private static string Message(int num)
        {
            return "Teacher posted assignment " + num + "\n";
        }*/
    }
}
