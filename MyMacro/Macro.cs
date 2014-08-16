using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyMacro
{
    /// <summary>
    /// Macro que representa una regla de envio de una tecla hacia un proceso
    /// </summary>
    class Macro
    {
        private int key;
        private int interval;
        private bool running;
        private Window window;
        private Thread thread;
        private KeySender keySender;

        /// <summary>
        /// Macro que representa una regla de envio de una tecla hacia un proceso
        /// </summary>
        /// <param name="key">Tecla a enviar</param>
        /// <param name="interval">Intervalo</param>
        public Macro(int key, int interval)
        {
            if (interval <= 0)
                throw new Exception("Sleep time must be greather than zero");

            if (!char.IsLetterOrDigit((char)key))
                throw new Exception("Invalid key number");

            this.key = key;
            this.interval = interval;

            keySender = new KeySender();
        }

        /// <summary>
        /// Tecla a enviar
        /// </summary>
        public int Key
        {
            get { return key; }
            set { key = value; }
        }

        /// <summary>
        /// Intervalo de envio
        /// </summary>
        public int Interval
        {
            get { return interval; }
            set { interval = value; }
        }

        /// <summary>
        /// Inicia el macro de manera segura
        /// </summary>
        /// <param name="window"></param>
        public void Start(Window window)
        {
            if (running)
                throw new Exception("Thread already running, stop it first");

            this.window = window;

            thread = new Thread(new ThreadStart(run));
            running = true;
            thread.Start();
        }

        /// <summary>
        /// Detiene el macro de manera segura
        /// </summary>
        public void Stop()
        {
            if (!running)
                throw new Exception("Thread not running");

            running = false;
        }

        private void run()
        {
            while (running)
            {
                keySender.sendKey(IntPtr.Zero, key);
                //KeySender.PressKey((short)key);
                Thread.Sleep(interval);
            }
        }
    }
}
