using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

/// <summary>
/// Module of the program.
/// Author: Lukasz Bednarek
/// Date: November 2022
/// Source: From sample ProducerConsumerSemaphores program project.
/// </summary>
namespace Lab3LukaszBednarek
{
    /// <summary>
    /// Drives the program.
    /// </summary>
    public static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
