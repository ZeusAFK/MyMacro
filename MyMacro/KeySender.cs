using System;
using System.Collections.Generic;
using System.Text;
using WindowsInput;
using System.Runtime.InteropServices;
using System.Threading;

namespace MyMacro
{
    /// <summary>
    /// Permite enviar pulsaciones de teclas a diferentes procesos utilizando el handle de la ventana
    /// </summary>
    class KeySender
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        static extern UInt32 SendInput(UInt32 nInputs, [MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] INPUT[] pInputs, Int32 cbSize);

        private static InputSimulator inputSimulator = new InputSimulator();

        [Flags]
        public enum KeyFlag
        {
            KeyDown = 0x0000,
            KeyUp = 0x0002,
            Scancode = 0x0008
        }

        [StructLayout(LayoutKind.Sequential)]
        struct KEYBDINPUT
        {
            public short wVk;      //Virtual KeyCode (not needed here)
            public short wScan;    //Directx Keycode 
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

        public static void SendKey(short keyCode, KeyFlag keyFlag)
        {
            INPUT[] InputData = new INPUT[1];

            InputData[0].type = 1;
            InputData[0].ki.wScan = keyCode; // 0x14 = T for example
            InputData[0].ki.dwFlags = (int)keyFlag;
            InputData[0].ki.time = 0;
            InputData[0].ki.dwExtraInfo = IntPtr.Zero;

            SendInput(1, InputData, Marshal.SizeOf(typeof(INPUT)));
        }

        public static void PressKey(short key)
        {
            SendKey((short)WindowsInput.Native.VirtualKeyCode.VK_Z, KeyFlag.KeyDown | KeyFlag.Scancode);
            Thread.Sleep(50);
            SendKey((short)WindowsInput.Native.VirtualKeyCode.VK_Z, KeyFlag.KeyUp | KeyFlag.Scancode);
        }

        /// <summary>
        /// Envia una tecla hacia un proceso
        /// </summary>
        /// <param name="hWnd">Window handle</param>
        /// <param name="key">Tecla</param>
        /// <returns></returns>
        public bool sendKey(IntPtr hWnd, int key)
        {
            //SendMessage(hWnd, 0x100, (int)WindowsInput.Native.VirtualKeyCode.VK_Z, 0);
            //Thread.Sleep(50);
            //SendMessage(hWnd, 0x101, (int)WindowsInput.Native.VirtualKeyCode.VK_Z, 0);
            string keyChar = ((char)key).ToString().ToUpper();
            switch (keyChar)
            {
                case "1":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_1);
                    break;
                case "2":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_2);
                    break;
                case "3":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_3);
                    break;
                case "4":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_4);
                    break;
                case "5":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_5);
                    break;
                case "6":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_6);
                    break;
                case "7":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_7);
                    break;
                case "8":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_8);
                    break;
                case "9":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_9);
                    break;
                case "0":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_0);
                    break;
                case "A":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_A);
                    break;
                case "B":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_B);
                    break;
                case "C":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_C);
                    break;
                case "D":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_D);
                    break;
                case "E":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_E);
                    break;
                case "F":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_F);
                    break;
                case "G":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_G);
                    break;
                case "H":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_H);
                    break;
                case "I":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_I);
                    break;
                case "J":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_J);
                    break;
                case "K":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_K);
                    break;
                case "L":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_L);
                    break;
                case "M":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_M);
                    break;
                case "N":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_N);
                    break;
                case "O":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_O);
                    break;
                case "P":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_P);
                    break;
                case "Q":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_Q);
                    break;
                case "R":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_R);
                    break;
                case "S":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_S);
                    break;
                case "T":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_T);
                    break;
                case "U":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_U);
                    break;
                case "V":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_V);
                    break;
                case "W":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_W);
                    break;
                case "X":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_X);
                    break;
                case "Y":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_Y);
                    break;
                case "Z":
                    inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_Z);
                    break;
            }
            return true;
        }
    }
}
