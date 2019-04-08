using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace PInvoke.structures
{
    /// <summary>
    /// The GENERIC_MAPPING structure defines the mapping of
    /// generic access rights to specific and standard access
    /// rights for an object. When a client application requests
    /// generic access to an object, that request is mapped
    /// to the access rights defined in this structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct GENERIC_MAPPING
    {
        uint GenericRead;
        uint GenericWrite;
        uint GenericExecute;
        uint GenericAll;
    }
}
