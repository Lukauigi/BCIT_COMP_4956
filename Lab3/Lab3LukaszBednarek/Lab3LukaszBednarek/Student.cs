using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

/// <summary>
/// Module of a student as a consumer in the producer-consumer design pattern.
/// Author: Lukasz Bednarek
/// Date: November 2022
/// Source: From sample ProducerConsumerSemaphores program project.
/// </summary>
namespace Lab3LukaszBednarek
{
    /// <summary>
    /// A student.
    /// </summary>
    class Student
    {
        /*
        /// <summary>
        /// Runs a student consumer.
        /// </summary>
        public static void student()
        {
            while (true)
            {
                Program.semEmpty.WaitOne(); //wait signal
                Thread.Sleep(Program.rand.Next(10) * 1000); //wait to consume
                int num = Program.cBuffer.Get(); //get from buffer queue
                Message(num);
                Program.semFull.Release(); //signal done
            }
        }

        /// <summary>
        /// Returns a message after completing an assignment.
        /// </summary>
        /// <param name="num"> the assignment number. </param>
        /// <returns> message of assignment completion. </returns>
        private static string Message(int num)
        {
            return "Student solved assignment " + num + "\n";
        }*/
    }
}
