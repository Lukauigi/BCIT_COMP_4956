using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

/// <summary>
/// Module of the form GUI.
/// Author: Lukasz Bednarek
/// Date: November 2022
/// </summary>
namespace Lab3LukaszBednarek
{
    /// <summary>
    /// The main form of the app.
    /// </summary>
    public partial class Form1 : Form
    {
        private delegate void SafeCallDelegate(string text);
        public static Semaphore semFull;
        public static Semaphore semEmpty;
        public static int size = 5;
        public static CircularBuffer<int> cBuffer;
        public static Random rand = new Random();

        /// <summary>
        /// Initializes form components and start producer-consumer threads.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            semFull = new Semaphore(size, size);
            semEmpty = new Semaphore(0, size);
            cBuffer = new CircularBuffer<int>(size);
            Thread teacherThread = new Thread(this.teacher);
            Thread studentThread = new Thread(this.student);
            teacherThread.Start();
            studentThread.Start();
        }

        /// <summary>
        /// Runs a teacher producer.
        /// </summary>
        public void teacher()
        {
            int num = 0;
            while (true)
            {
                num++;

                semFull.WaitOne(); //wait signal
                Thread.Sleep(rand.Next(10) * 500); //sleep for a random amount of time to produce
                cBuffer.Put(num); //put in buffer
                //Console.WriteLine("Teacher posted assignment " + num);
                WriteTextSafe("Teacher posted assignment " + num + "\n");
                semEmpty.Release(); //allow others to access resource
                if (num > size - 1) //reset num when reaches size
                {
                    num = 0;
                }
            }
        }

        /// <summary>
        /// Runs a student consumer.
        /// </summary>
        public void student()
        {
            while (true)
            {
                semEmpty.WaitOne(); //wait signal
                Thread.Sleep(rand.Next(10) * 1000); //wait to consume
                int num = cBuffer.Get(); //get from buffer queue
                WriteTextSafe("Student solved assignment " + num + "\n");
                semFull.Release(); //signal done
            }
        }

        /// <summary>
        /// Writes a message from the producer or consumer to the text box.
        /// </summary>
        /// <param name="text"> Message from producer/consumer. </param>
        private void WriteTextSafe(string text)
        {
            if (ProgramTextBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                ProgramTextBox.Invoke(d, new object[] { text });
            }
            else
            {
                ProgramTextBox.Text += text;
            }
        }        
    }
}
