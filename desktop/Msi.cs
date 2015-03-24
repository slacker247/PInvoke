using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace PInvoke.desktop
{
    public class Msi
    {
        [DllImport("msi.dll", CharSet = CharSet.Unicode)]
        public static extern Int32 MsiGetProductInfo(string product,
            string property,
            [Out] StringBuilder valueBuf,
            ref Int32 len);
    }
}
