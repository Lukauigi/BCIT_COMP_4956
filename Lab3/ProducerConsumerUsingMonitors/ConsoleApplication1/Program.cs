using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the buffer, the producer and the consumer
            CircularBuffer sharedBuffer = new SynchronizedCircularBuffer(IntegerFromConsole("Enter the buffer size: "));
            Producer producer = new Producer(sharedBuffer, IntegerFromConsole("Enter the Producer's sleep time in ms: "));
            Consumer consumer = new Consumer(sharedBuffer, IntegerFromConsole("Enter the Consumer's sleep time in ms: "));

            // create the threads
            Thread producerThread = new Thread(new ThreadStart(producer.Produce));
            producerThread.Name = "Producer";

            Thread consumerThread = new Thread(new ThreadStart(consumer.Consume));
            consumerThread.Name = "Consumer";

            // start the threads
            producerThread.Start();
            consumerThread.Start();

            // to not quit the console
            Console.ReadLine();
        }

        static int IntegerFromConsole(string msg)
        {
            int result;
            Console.WriteLine(msg);
            while (true)
            {
                string line = Console.ReadLine();
                if (int.TryParse(line, out result))
                    return result;
            }

        }
    }
}

