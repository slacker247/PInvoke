using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using PInvoke.structures;

namespace PInvoke.desktop
{
    public class Gdi32
    {

        ///  You need to define a 256 color "RAMP" to set this api. Check example for explanation.
        ///  2. Values from 1 to 256 are supported.
        [DllImport("gdi32.dll")]
        public static extern bool SetDeviceGammaRamp(IntPtr hDC, ref RAMP lpRamp);
    }
}
