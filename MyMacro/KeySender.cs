using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
//using System.Windows.Forms;

namespace MyMacro
{
    /// <summary>
    /// Permite enviar pulsaciones de teclas a diferentes procesos utilizando el handle de la ventana
    /// </summary>
    class KeySender
    {
        [DllImport("user32.dll")]
        static extern UInt32 SendInput(UInt32 nInputs, [MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] INPUT[] pInputs, Int32 cbSize);

        [StructLayout(LayoutKind.Sequential)]
        struct KEYBDINPUT
        {
            public short wVk;      //Virtual KeyCode (not needed here)
            public int wScan;    //Directx Keycode 
            public int dwFlags;    //This tells you what is use (Keyup, Keydown..)
            public int time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Explicit)]
        struct INPUT
        {
            [FieldOffset(0)]
            public int type;
            [FieldOffset(4)]
            public KEYBDINPUT ki;
        }

        /// <summary>
        /// Envia una tecla hacia un proceso
        /// </summary>
        /// <param name="hWnd">Window handle</param>
        /// <param name="key">Tecla</param>
        /// <returns></returns>
        public static bool sendKey(IntPtr hWnd, int key)
        {
            INPUT[] InputData = new INPUT[1];

            InputData[0].type = 1;
            InputData[0].ki.wScan = 0x14;
            InputData[0].ki.dwFlags = 0x0008;
            InputData[0].ki.time = 0;
            InputData[0].ki.dwExtraInfo = IntPtr.Zero;

            SendInput(1, InputData, Marshal.SizeOf(typeof(INPUT)));

            //input.SendKey(Keys.A);
            //SendKeys.SendWait(((char)key).ToString());
            return true;
        }
    }
}
