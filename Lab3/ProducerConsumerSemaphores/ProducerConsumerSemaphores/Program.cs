using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace ProducerConsumerSemaphores
{
    class Program
    {        
        public static Semaphore semFull;
        public static Semaphore semEmpty;
        public static int size = 20;
        public static CircularBuffer<int> cBuffer;
        public static Random rand = new Random();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Teacher-Student Synchronization");
            semFull = new Semaphore(size, size);
            semEmpty = new Semaphore(0, size);
            cBuffer = new CircularBuffer<int>(size);
            Thread teacherThread = new Thread(Teacher.teacher);
            Thread studentThread = new Thread(Student.student);
            teacherThread.Start();
            studentThread.Start();
        }
    }
}
