using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace MyMacro
{
    class Applications
    {
        /// <summary>
        /// Devuelve la lista de ventanas activas en el sistema con un titulo visible
        /// </summary>
        /// <returns>Lista de ventanas activas</returns>
        public static Window[] getActiveWindows()
        {
            Process[] processes = Process.GetProcesses();
            Window[] activeWindows = new Window[processes.Length];

            for (int i = 0; i < processes.Length; i++)
                activeWindows[i] = new Window(processes[i]);

            return activeWindows;
        }
    }
}
