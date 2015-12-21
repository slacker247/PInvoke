using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using PInvoke.structures;

namespace PInvoke.helpers
{
    public class Brightness
    {
        public static bool SetBrightness(short gamma)
        {
            bool status = false;
            if (gamma <= 256 && gamma >= 1)
            {
                RAMP ramp = new RAMP();
                ramp.Red = new ushort[256];
                ramp.Green = new ushort[256];
                ramp.Blue = new ushort[256];
                for (int i = 1; i < 256; i++)
                {
                    int iArrayValue = i * (gamma + 128);

                    if (iArrayValue > 65535)
                        iArrayValue = 65535;
                    ramp.Red[i] = ramp.Blue[i] = ramp.Green[i] = (ushort)iArrayValue;
                }
                status = desktop.Gdi32.SetDeviceGammaRamp(desktop.User32.GetDC(IntPtr.Zero), ref ramp);
            }
            return status;
        }
    }
}
