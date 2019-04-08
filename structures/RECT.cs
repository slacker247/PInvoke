using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace PInvoke.structures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }
}
