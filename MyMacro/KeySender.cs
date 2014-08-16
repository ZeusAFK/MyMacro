using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;

namespace MyMacro
{
    /// <summary>
    /// Permite enviar pulsaciones de teclas a diferentes procesos utilizando el handle de la ventana
    /// </summary>
    class KeySender
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);
        
        [DllImport("user32.dll")]
        private static extern uint MapVirtualKey(uint uCode, uint uMapType);
        
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr GetMessageExtraInfo();

        private enum InputType
        {
            INPUT_MOUSE,
            INPUT_KEYBOARD,
            INPUT_HARDWARE
        }
        [Flags]
        private enum MOUSEEVENTF
        {
            MOVE = 1,
            LEFTDOWN = 2,
            LEFTUP = 4,
            RIGHTDOWN = 8,
            RIGHTUP = 16,
            MIDDLEDOWN = 32,
            MIDDLEUP = 64,
            XDOWN = 128,
            XUP = 256,
            WHEEL = 2048,
            VIRTUALDESK = 16384,
            ABSOLUTE = 32768
        }
        [Flags]
        private enum KEYEVENTF
        {
            EXTENDEDKEY = 1,
            KEYUP = 2,
            UNICODE = 4,
            SCANCODE = 8
        }
        private struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }
        private struct KEYBDINPUT
        {
            public short wVk;
            public short wScan;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }
        private struct HARDWAREINPUT
        {
            public int uMsg;
            public short wParamL;
            public short wParamH;
        }
        [StructLayout(LayoutKind.Explicit)]
        private struct INPUT
        {
            [FieldOffset(0)]
            public int type;
            [FieldOffset(4)]
            public MOUSEINPUT mi;
            [FieldOffset(4)]
            public KEYBDINPUT ki;
            [FieldOffset(4)]
            public HARDWAREINPUT hi;
        }

        public static uint KeyPress(short key)
        {
            INPUT iNPUT = default(INPUT);
            iNPUT.type = 1;
            iNPUT.ki.wScan = (short)MapVirtualKey((uint)key, 0u);
            iNPUT.ki.time = 0;
            iNPUT.ki.dwFlags = 8;
            INPUT[] pInputs = new INPUT[]
				{
					iNPUT
				};
            return SendInput(1u, pInputs, Marshal.SizeOf(iNPUT));
        }

        public static uint KeyRelease(short key)
        {
            INPUT iNPUT = default(INPUT);
            iNPUT.type = 1;
            iNPUT.ki.wScan = (short)MapVirtualKey((uint)key, 0u);
            iNPUT.ki.time = 0;
            iNPUT.ki.dwFlags = 8;
            iNPUT.ki.dwFlags = 2;
            INPUT[] pInputs = new INPUT[]
				{
					iNPUT
				};
            return SendInput(1u, pInputs, Marshal.SizeOf(iNPUT));
        }

        /// <summary>
        /// Envia una tecla hacia un proceso
        /// </summary>
        /// <param name="hWnd">Window handle</param>
        /// <param name="key">Tecla</param>
        /// <returns></returns>
        public bool sendKey(IntPtr hWnd, int key)
        {
            KeyPress((short)key);
            Thread.Sleep(50);
            KeyRelease((short)key);
            
            return true;
        }
    }
}
