using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Windows.Input;

namespace KeyBoardCSharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //system call to windows on screen keyboard
            //System.Diagnostics.Process.Start("osk.exe");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 fm = new Form1();

            //making the form transperent
            fm.Opacity = new Double();
            fm.Opacity = 0.90;

            //making the form(keyboard) alway on top
            fm.TopMost = true;
            Application.Run(fm);
           
             
        }
    }
}
