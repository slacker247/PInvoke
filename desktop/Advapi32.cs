using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace PInvoke.desktop
{
    public class Advapi32
    {
        /// <summary>
        /// Stops a system shutdown that has been initiated.
        /// </summary>
        /// <param name="lpMachineName"></param>
        /// <returns></returns>
        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern bool AbortSystemShutdown(string lpMachineName);

        /// <summary>
        /// The AccessCheck function determines whether a security descriptor grants
        /// a specified set of access rights to the client identified by an access
        /// token. Typically, server applications use this function to check access
        /// to a private object.
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <param name="ClientToken"></param>
        /// <param name="DesiredAccess"></param>
        /// <param name="GenericMapping"></param>
        /// <param name="PrivilegeSet"></param>
        /// <param name="PrivilegeSetLength"></param>
        /// <param name="GrantedAccess"></param>
        /// <param name="AccessStatus"></param>
        /// <returns></returns>
        [DllImport("advapi32", SetLastError = true)]
        public static extern bool AccessCheck(
          [MarshalAs(UnmanagedType.LPArray)]
          byte[] pSecurityDescriptor,
          IntPtr ClientToken,
          uint DesiredAccess,
          [In] ref structures.GENERIC_MAPPING GenericMapping,
          IntPtr PrivilegeSet,
          ref uint PrivilegeSetLength,
          out uint GrantedAccess,
          out bool AccessStatus);

        [DllImport("advapi32.dll")]
        public static extern int LogonUserA(String lpszUserName,
            String lpszDomain,
            String lpszPassword,
            int dwLogonType,
            int dwLogonProvider,
            ref IntPtr phToken);
        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DuplicateToken(IntPtr hToken,
            int impersonationLevel,
            ref IntPtr hNewToken);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RevertToSelf();
    }
}
