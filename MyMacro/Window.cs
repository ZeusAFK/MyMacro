using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MyMacro
{
    /// <summary>
    /// Representacion de una venta de una aplicacion
    /// </summary>
    class Window
    {
        [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowText(int hWnd, System.Text.StringBuilder lpString, int cch);

        [DllImport("user32.dll", EntryPoint = "FindWindowA")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern bool SetForegroundWindow(IntPtr hwnd);

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private Process process;
        private string title;
        private IntPtr hWnd;

        /// <summary>
        /// Representacion de una ventana de una aplicacion
        /// </summary>
        /// <param name="process">Proceso</param>
        public Window(Process process)
        {
            this.process = process;
            this.title = getTitle();
        }

        /// <summary>
        /// Obtiene el titulo de la ventana activa en el sistema en primer plano
        /// </summary>
        /// <returns>String: Titulo de la ventana</returns>
        public static string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        /// <summary>
        /// Obtiene el titulo de la ventana para el manejador especificado
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns>String: Titulo de la ventana</returns>
        public static string getWindowText(int hWnd)
        {
            StringBuilder titulo = new StringBuilder(new string(' ', 256));
            int ret;
            string nombreVentana;

            ret = GetWindowText(hWnd, titulo, titulo.Length);
            nombreVentana = titulo.ToString().Substring(0, ret);

            return nombreVentana;
        }

        /// <summary>
        /// Obtiene el titulo de la ventana
        /// </summary>
        /// <returns>String: Titulo de la ventana</returns>
        public string getTitle()
        {
            if ((hWnd = process.MainWindowHandle) != IntPtr.Zero)
            {
                return getWindowText((int)hWnd);
            }
            else
                return string.Empty;
        }

        /// <summary>
        /// Obtiene el handle de la window ventana
        /// </summary>
        /// <returns>IntPtr: Window handle</returns>
        public IntPtr getHandle()
        {
            hWnd = FindWindow(null, title);
            return hWnd;
        }

        /// <summary>
        /// Verifica si la ventana esta en primer plano en el sistema
        /// </summary>
        /// <returns>Boolean: Verdadero si la ventana esta en primer plano, falso en caso contrario</returns>
        public bool isForegroundWindow()
        {
            return GetActiveWindowTitle() == getTitle();
        }

        /// <summary>
        /// Establece la ventana actual como ventana de primer plano en el sistema
        /// </summary>
        /// <returns>Boolean: Verdadero si se logro establecer la ventana en primer plano, falso en cualquier otro caso</returns>
        public bool setForegroundWindow()
        {
            getHandle();
            return SetForegroundWindow(hWnd);
        }

        /// <summary>
        /// Devuelve el titulo de la ventana
        /// </summary>
        /// <returns>String: Titulo de la ventana</returns>
        public override string ToString()
        {
            return getTitle();
        }
    }
}
