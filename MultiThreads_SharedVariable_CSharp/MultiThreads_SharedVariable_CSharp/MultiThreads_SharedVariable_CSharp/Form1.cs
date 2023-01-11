using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MultiThreads_SharedVariable_CSharp
{
    public partial class FormMain : Form
    {
        
        private int sharedVariable; //shared variable. 
        private Thread thread = null;
        private static Mutex myMutex = new Mutex(); //synchronization mutex 
        private int _threadCount; //the number of threads created 
        private int increment;
        private string _count; //the text associated with input count
        private string _threadName;
        
        /// <summary>
        /// Property associated with the count string that displays 
        /// the shared variable in the text box
        /// </summary>
        public string count
        {
            get
            {
                return _count;
            }

            set
            {
                _count = value;
                this.textBoxValue.Invoke(new Action(() => this.textBoxValue.Text = _count)); //change what is displayed
            }
        }

        /// <summary>
        /// Property associated with the thread name displayed in text box
        /// </summary>
        public string threadName
        {
            get
            {
                return _threadName;
            }

            set
            {
                _threadName = value;
                this.textBoxCurrentThreadName.Invoke(new Action(() => this.textBoxCurrentThreadName.Text = _threadName)); //change what is displayed
            }
        }

        /// <summary>
        /// Property associated with the nr of threads displayed in text box 
        /// </summary>
        public int threadCount
        {
            get
            {
                return _threadCount;
            }

            set
            {
                _threadCount = value;
                this.textBoxCurrentThreads.Invoke(new Action(() => this.textBoxCurrentThreads.Text = _threadCount.ToString()));
            }
        }

        public FormMain()
        {
            InitializeComponent();
        }

       
        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            threadCount = (int)numericUpDownThreadCount.Value; //takes input from thread textbox
            increment = (int)numericUpDownIncrement.Value; //takes input from increment textbox
            sharedVariable = 0;
            this.Refresh(); //redraw canvas

            for (int i = 0; i < threadCount; i++) //creates every thread desired, names it, and executes the thread counting
            {
                thread = new Thread(new ThreadStart(ThreadTask));
                thread.Name = "t" + i;
                thread.Start();

            }

        }

        public void ThreadTask()
        {
            try
            {
                int counter = 0;
                while (counter < increment)
                {
                    myMutex.WaitOne(); //lock the shared variables 

                    counter += 1;
                    sharedVariable++;
                    count = sharedVariable.ToString();
                    threadName = Thread.CurrentThread.Name;
                    
                    myMutex.ReleaseMutex(); //release the shared variables      


                    Thread.Sleep(500);
                }
            }
            catch (ThreadAbortException exc)
            {
                MessageBox.Show(exc.Message, Text);
                return;
            }
        
        }


        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode); // close properly all threads
        }
    }
}
