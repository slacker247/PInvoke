using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace PInvoke.desktop
{
    public class Crypt32
    {
        /// <summary>
        /// The CryptQueryObject function retrieves information about the contents of a cryptography API
        /// object, such as a certificate, a certificate revocation list, or a certificate trust list.
        /// The object can either reside in a structure in memory or be contained in a file.
        /// 
        /// ref: https://msdn.microsoft.com/en-us/library/windows/desktop/aa380264%28v=vs.85%29.aspx
        /// </summary>
        /// <param name="dwObjectType">A pointer to the object to be queried. The type of data pointer
        /// depends on the contents of the dwObjectType parameter.</param>
        /// <param name="dwExpectedContentTypeFlags">Indicates the expected content type. This can be one
        /// of the  CERT_QUERY_CONTENT_FLAG_*.</param>
        /// <param name="dwExpectedFormatTypeFlags">Indicates the expected format of the returned type.
        /// This can be one of the CERT_QUERY_FORMAT_FLAG_*.</param>
        /// <param name="dwFlags">This parameter is reserved for future use and must be set to zero.</param>
        /// <param name="pdwMsgAndCertEncodingType">A pointer to a DWORD value that receives the type of
        /// encoding used in the message. If this information is not needed, set this parameter to NULL.
        /// 
        /// This parameter can receives a combination of one or more of the following values:
        /// <see cref="PKCS_7_ASN_ENCODING"/>
        /// <see cref="X509_ASN_ENCODING"/>
        /// </param>
        /// <param name="pdwContentType">A pointer to a DWORD value that receives the actual type of the
        /// content. If this information is not needed, set this parameter to NULL. The returned content
        /// type can be of the type CERT_QUERY_CONTENT_*.</param>
        /// <param name="pdwFormatType">A pointer to a DWORD value that receives the actual format type of
        /// the content. If this information is not needed, set this parameter to NULL. The returned format
        /// type can be one of CERT_QUERY_FORMAT_*.</param>
        /// <param name="phCertStore">A pointer to an HCERTSTORE value that receives a handle to a certificate
        /// store that includes all of the certificates, CRLs, and CTLs in the object.
        /// 
        /// This parameter only receives a certificate store handle when the dwContentType parameter receives
        /// one of the CERT_QUERY_CONTENT_*. This parameter receives NULL for all other content types.
        /// 
        /// When you have finished using the handle, free it by passing the handle to the CertCloseStore function.
        /// If this information is not needed, set this parameter to NULL.</param>
        /// <param name="phMsg">A pointer to an HCRYPTMSG value that receives the handle of an opened message.
        /// This parameter only receives a message handle when the dwContentType parameter receives one of the
        /// CERT_QUERY_CONTENT_PKCS7_*. This parameter receives NULL for all other content types.  When you have
        /// finished using the handle, free it by passing the handle to the CryptMsgClose function.  If this
        /// information is not needed, set this parameter to NULL.</param>
        /// <param name="ppvContext">A pointer to a pointer that receives additional information about the object.
        /// The format of this data depends on the value received by the dwContentType parameter. The table on
        /// MSDN lists the format of the data for the specified dwContentType value.  If this information is not
        /// needed, set this parameter to NULL.</param>
        /// <returns>If the function succeeds, the function returns nonzero.
        /// If the function fails, it returns zero. For extended error information, call GetLastError.</returns>
        [DllImport("CRYPT32.DLL", EntryPoint = "CryptQueryObject", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Boolean CryptQueryObject(
            Int32 dwObjectType,
            [MarshalAs(UnmanagedType.LPWStr)]String pvObject,
            Int32 dwExpectedContentTypeFlags,
            Int32 dwExpectedFormatTypeFlags,
            Int32 dwFlags,
            IntPtr pdwMsgAndCertEncodingType,
            IntPtr pdwContentType,
            IntPtr pdwFormatType,
            IntPtr phCertStore,
            IntPtr phMsg,
            ref IntPtr ppvContext
        );

        /// <summary>
        /// The CryptMsgGetParam function acquires a message parameter after a cryptographic message
        /// has been encoded or decoded. This function is called after the final CryptMsgUpdate call.
        /// </summary>
        /// <param name="hCryptMsg">Handle of a cryptographic message.</param>
        /// <param name="dwParamType">Indicates the parameter types of data to be retrieved. The type
        /// of data to be retrieved determines the type of structure to use for pvData.  For an
        /// encoded message, only the CMSG_BARE_CONTENT, CMSG_ENCODE_SIGNER, CMSG_CONTENT_PARAM
        /// and CMSG_COMPUTED_HASH_PARAM dwParamTypes are valid.</param>
        /// <param name="dwIndex">Index for the parameter being retrieved, where applicable. When a
        /// parameter is not being retrieved, this parameter is ignored and is set to zero.</param>
        /// <param name="pvData">A pointer to a buffer that receives the data retrieved. The form of
        /// this data will vary depending on the value of the dwParamType parameter.
        /// This parameter can be NULL to set the size of this information for memory allocation
        /// purposes. For more information, see Retrieving Data of Unknown Length.
        /// When processing the data returned in this buffer, applications need to use the actual
        /// size of the data returned. The actual size can be slightly smaller than the size of the
        /// buffer specified on input. (On input, buffer sizes are usually specified large enough to
        /// ensure that the largest possible output data will fit in the buffer.) On output, the
        /// variable pointed to by this parameter is updated to reflect the actual size of the data
        /// copied to the buffer.</param>
        /// <param name="pcbData">A pointer to a variable that specifies the size, in bytes, of the
        /// buffer pointed to by the pvData parameter. When the function returns, the variable
        /// pointed to by the pcbData parameter contains the number of bytes stored in the
        /// buffer.</param>
        /// <returns>If the function succeeds, the return value is nonzero (TRUE).
        /// If the function fails, the return value is zero (FALSE). For extended error information,
        /// call GetLastError.
        /// The CRYPT_E_* are most commonly returned by the GetLastError function. View:
        /// https://msdn.microsoft.com/en-us/library/windows/desktop/aa380227%28v=vs.85%29.aspx
        /// for a complete list.
        /// 
        /// For dwParamType CMSG_COMPUTED_HASH_PARAM, an error can be propagated from CryptGetHashParam.
        /// If the function fails, GetLastError may return an Abstract Syntax Notation One (ASN.1)
        /// encoding/decoding error. For information about these errors, see ASN.1 Encoding/Decoding
        /// Return Values.</returns>
        [DllImport("crypt32.dll", SetLastError = true)]
        public static extern bool CryptMsgGetParam(
            IntPtr hCryptMsg,
            uint dwParamType,
            int dwIndex,
            IntPtr pvData,
            ref uint pcbData
            );

        [DllImport("crypt32.dll", SetLastError = true)]
        public static extern bool CryptMsgGetParam(
            IntPtr hCryptMsg,
            uint dwParamType,
            int dwIndex,
            [In, Out] byte[] pvData,
            ref int pcbData
            );

        [DllImport("crypt32.dll", SetLastError = true)]
        public static extern bool CryptMsgGetParam(
            IntPtr hCryptMsg,
            uint dwParamType,
            int dwIndex,
            ref uint pvData,
            ref uint pcbData
            );

        /// <summary>
        /// The CertFindCertificateInStore function finds the first or next certificate context in
        /// a certificate store that matches a search criteria established by the dwFindType and
        /// its associated pvFindPara. This function can be used in a loop to find all of the
        /// certificates in a certificate store that match the specified find criteria.
        /// </summary>
        /// <param name="hCertStore">A handle of the certificate store to be searched.</param>
        /// <param name="dwCertEncodingType">Specifies the type of encoding used. Both the
        /// certificate and message encoding types must be specified by combining them with a 
        /// bitwise-OR operation as shown in the following example:
        /// X509_ASN_ENCODING | PKCS_7_ASN_ENCODING
        /// Currently defined encoding types are:
        /// X509_ASN_ENCODING
        /// PKCS_7_ASN_ENCODING</param>
        /// <param name="dwFindFlags">Used with some dwFindType values to modify the search
        /// criteria. For most dwFindType values, dwFindFlags is not used and should be set to
        /// zero. For detailed information, see Remarks.</param>
        /// <param name="dwFindType">Specifies the type of search being made. The search type
        /// determines the data type, contents, and the use of pvFindPara. This parameter can
        /// be one of the following values.
        /// Note  There are alternate forms of the value of dwFindType that pass a string in
        /// pvFindPara. One form uses a Unicode string, and the other an ASCII string. Values
        /// that end in "_W" or without a suffix use Unicode. Values that end with "_A" use
        /// ASCII strings.</param>
        /// <param name="pszFindPara">Points to a data item or structure used with dwFindType.</param>
        /// <param name="pPrevCertCntxt">A pointer to the last CERT_CONTEXT structure returned by this 
        /// function. This parameter must be NULL on the first call of the function. To find
        /// successive certificates meeting the search criteria, set pPrevCertContext to the
        /// pointer returned by the previous call to the function. This function frees the
        /// CERT_CONTEXT referenced by non-NULL values of this parameter.</param>
        /// <returns>If the function succeeds, the function returns a pointer to a read-only
        /// CERT_CONTEXT structure.
        /// If the function fails and a certificate that matches the search criteria is not
        /// found, the return value is NULL.
        /// A non-NULL CERT_CONTEXT that CertFindCertificateInStore returns must be freed by
        /// CertFreeCertificateContext or by being passed as the pPrevCertContext parameter
        /// on a subsequent call to CertFindCertificateInStore.
        /// For extended error information, call GetLastError.</returns>
        [DllImport("crypt32.dll", SetLastError = true)]
        public static extern IntPtr CertFindCertificateInStore(IntPtr hCertStore,
           uint dwCertEncodingType, uint dwFindFlags, uint dwFindType,
           IntPtr pszFindPara, IntPtr pPrevCertCntxt);

        /// <summary>
        /// The CertFindCertificateInStore function finds the first or next certificate context
        /// in a certificate store that matches a search criteria established by the dwFindType
        /// and its associated pvFindPara. This function can be used in a loop to find all of
        /// the certificates in a certificate store that match the specified find criteria.
        /// </summary>
        /// <param name="hCertStore">A handle of the certificate store to be searched.</param>
        /// <param name="dwCertEncodingType">Specifies the type of encoding used. Both the
        /// certificate and message encoding types must be specified by combining them with a
        /// bitwise-OR operation as shown in the following example:
        ///     X509_ASN_ENCODING | PKCS_7_ASN_ENCODING
        /// Currently defined encoding types are:
        ///     X509_ASN_ENCODING
        ///     PKCS_7_ASN_ENCODING</param>
        /// <param name="dwFindFlags">Used with some dwFindType values to modify the search
        /// criteria. For most dwFindType values, dwFindFlags is not used and should be set to
        /// zero. For detailed information, see Remarks.</param>
        /// <param name="dwFindType">Specifies the type of search being made. The search type
        /// determines the data type, contents, and the use of pvFindPara. 
        /// Note  There are alternate forms of the value of dwFindType that pass a string in
        /// pvFindPara. One form uses a Unicode string, and the other an ASCII string. Values
        /// that end in "_W" or without a suffix use Unicode. Values that end with "_A" use
        /// ASCII strings.</param>
        /// <param name="pszFindPara">Points to a data item or structure used with dwFindType.
        /// </param>
        /// <param name="pPrevCertCntxt">A pointer to the last CERT_CONTEXT structure returned
        /// by this function. This parameter must be NULL on the first call of the function.
        /// To find successive certificates meeting the search criteria, set pPrevCertContext
        /// to the pointer returned by the previous call to the function. This function frees
        /// the CERT_CONTEXT referenced by non-NULL values of this parameter.</param>
        /// <returns>If the function succeeds, the function returns a pointer to a read-only
        /// CERT_CONTEXT structure.
        /// If the function fails and a certificate that matches the search criteria is not
        /// found, the return value is NULL.
        /// A non-NULL CERT_CONTEXT that CertFindCertificateInStore returns must be freed by
        /// CertFreeCertificateContext or by being passed as the pPrevCertContext parameter on
        /// a subsequent call to CertFindCertificateInStore.
        /// For extended error information, call GetLastError.</returns>
        [DllImport("crypt32.dll", SetLastError = true)]
        public static extern IntPtr CertFindCertificateInStore(IntPtr hCertStore,
           uint dwCertEncodingType, uint dwFindFlags, uint dwFindType,
           IntPtr pszFindPara, IntPtr pPrevCertCntxt);

        /// <summary>
        /// The CertFreeCertificateContext function frees a certificate context by decrementing
        /// its reference count. When the reference count goes to zero,
        /// CertFreeCertificateContext frees the memory used by a certificate context.
        /// To free a context obtained by a get, duplicate, or create function, call the
        /// appropriate free function. To free a context obtained by a find or enumerate function,
        /// either pass it in as the previous context parameter to a subsequent invocation of
        /// the function, or call the appropriate free function. For more information, see the
        /// reference topic for the function that obtains the context.
        /// </summary>
        /// <param name="pCertContext">A pointer to the CERT_CONTEXT to be freed.</param>
        /// <returns>The function always returns nonzero.</returns>
        [DllImport("crypt32.dll")]
        public static extern bool CertFreeCertificateContext(IntPtr pCertContext);

        /// <summary>
        /// The CertCloseStore function closes a certificate store handle and reduces the reference
        /// count on the store. There needs to be a corresponding call to CertCloseStore for each
        /// successful call to the CertOpenStore or CertDuplicateStore functions.
        /// </summary>
        /// <param name="storeProvider">Handle of the certificate store to be closed.</param>
        /// <param name="flags">Typically, this parameter uses the default value zero. The default
        /// is to close the store with memory remaining allocated for contexts that have not been
        /// freed. In this case, no check is made to determine whether memory for contexts remains
        /// allocated.
        /// Set flags can force the freeing of memory for all of a store's certificate, certificate
        /// revocation list (CRL), and certificate trust list (CTL) contexts when the store is
        /// closed. Flags can also be set that check whether all of the store's certificate, CRL,
        /// and CTL contexts have been freed.</param>
        /// <returns>If the function succeeds, the return value is TRUE.
        /// If the function fails, the return value is FALSE. For extended error information, call
        /// GetLastError.
        /// If CERT_CLOSE_STORE_CHECK_FLAG is not set or if it is set and all contexts associated
        /// with the store have been freed, the return value is TRUE.
        /// If CERT_CLOSE_STORE_CHECK_FLAG is set and memory for one or more contexts associated
        /// with the store remains allocated, the return value is FALSE. The store is always
        /// closed even when the function returns FALSE. For details, see Remarks.
        /// GetLastError is set to CRYPT_E_PENDING_CLOSE if memory for contexts associated with the
        /// store remains allocated. Any existing value returned by GetLastError is preserved
        /// unless CERT_CLOSE_STORE_CHECK_FLAG is set.</returns>
        [DllImport("CRYPT32.DLL", EntryPoint = "CertCloseStore", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertCloseStore(IntPtr storeProvider, int flags);

        /// <summary>
        /// The CryptMsgClose function closes a cryptographic message handle. At each call
        /// to this function, the reference count on the message is reduced by one. When
        /// the reference count reaches zero, the message is fully released.
        /// </summary>
        /// <param name="hCryptMsg">Handle of the cryptographic message to be closed.</param>
        /// <returns>If the function succeeds, the function returns nonzero (TRUE).
        /// If the function fails, it returns zero (FALSE). For extended error information,
        /// call GetLastError.</returns>
        [DllImport("crypt32.dll", SetLastError = true)]
        public static extern bool CryptMsgClose(
            IntPtr hCryptMsg
            );

        /// <summary>
        /// The CertGetNameString function obtains the subject or issuer name from a certificate
        /// CERT_CONTEXT structure and converts it to a null-terminated character string.
        /// </summary>
        /// <param name="CertContext">A pointer to a CERT_CONTEXT certificate context that
        /// includes a subject and issuer name to be converted.</param>
        /// <param name="lType">DWORD indicating how the name is to be found and how the output
        /// is to be formatted.</param>
        /// <param name="lFlags">Indicates the type of processing needed.</param>
        /// <param name="pTypeParameter">A pointer to either a DWORD containing the dwStrType
        /// or an object identifier (OID) specifying the name attribute. The type pointed to
        /// is determined by the value of dwType.</param>
        /// <param name="str">A pointer to an allocated buffer to receive the returned string.
        /// If pszNameString is not NULL and cchNameString is not zero, pszNameString is a
        /// null-terminated string.
        /// If CERT_NAME_SEARCH_ALL_NAMES_FLAG is specified in the dwFlags parameter and
        /// CERT_NAME_DNS_TYPE is set in the dwType parameter, the returned string will contain
        /// all of the DNS names that apply. Each string in the output string is null-terminated
        /// and the last string will be double null-terminated. If no DNS names are found, a
        /// single null-terminated empty string is returned.</param>
        /// <param name="cch">Size, in characters, allocated for the returned string. The size
        /// must include the terminating NULL character.</param>
        /// <returns>Returns the number of characters converted, including the terminating zero
        /// character. If pszNameString is NULL or cchNameString is zero, returns the required
        /// size of the destination string (including the terminating NULL character). If the
        /// specified name type is not found, returns a null-terminated empty string with a
        /// returned character count of 1.</returns>
        [DllImport("crypt32.dll", EntryPoint = "CertGetNameString", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern UInt32 CertGetNameString(
            IntPtr CertContext,
            UInt32 lType,
            UInt32 lFlags,
            IntPtr pTypeParameter,
            System.Text.StringBuilder str,
            UInt32 cch);

        /// <summary>
        /// The CryptDecodeObject function decodes a structure of the type indicated by
        /// the lpszStructType parameter. The use of CryptDecodeObjectEx is recommended
        /// as an API that performs the same function with significant performance
        /// improvements.
        /// </summary>
        /// <param name="CertEncodingType">Type of encoding used. It is always acceptable
        /// to specify both the certificate and message encoding types by combining them
        /// with a bitwise-OR operation as shown in the following example:
        ///     X509_ASN_ENCODING | PKCS_7_ASN_ENCODING
        /// Currently defined encoding types are:
        ///     X509_ASN_ENCODING
        ///     PKCS_7_ASN_ENCODING
        /// Note  Either a certificate or message encoding type is required.
        /// X509_ASN_ENCODING is the default. If that type is indicated, it is used.
        /// Otherwise, if the PKCS7_ASN_ENCODING type is indicated, it is used.</param>
        /// <param name="lpszStructType">A pointer to an OID defining the structure type.
        /// If the high-order word of the lpszStructType parameter is zero, the low-order
        /// word specifies the integer identifier for the type of the specified structure.
        /// Otherwise, this parameter is a long pointer to a null-terminated string.
        /// For more information about object identifier strings, their predefined
        /// constants and corresponding structures, see Constants for CryptEncodeObject
        /// and CryptDecodeObject.</param>
        /// <param name="pbEncoded">A pointer to the encoded structure to be decoded.</param>
        /// <param name="cbEncoded">Number of bytes pointed to by pbEncoded.</param>
        /// <param name="flags">The following flags are defined. They can be combined with
        /// a bitwise-OR operation.</param>
        /// <param name="pvStructInfo">A pointer to a buffer to receive the decoded structure.
        /// When the buffer that is specified is not large enough to receive the decoded
        /// structure, the function sets the ERROR_MORE_DATA code and stores the required
        /// buffer size, in bytes, in the variable pointed to by pcbStructInfo.
        /// This parameter can be NULL to retrieve the size of this information for memory
        /// allocation purposes. For more information, see Retrieving Data of Unknown Length.
        /// </param>
        /// <param name="cbStructInfo">A pointer to a DWORD value specifying the size, in bytes,
        /// of the buffer pointed to by the pvStructInfo parameter. When the function returns,
        /// this DWORD value contains the size of the decoded data copied to pvStructInfo. The
        /// size contained in the variable pointed to by pcbStructInfo can indicate a size larger
        /// than the decoded structure, as the decoded structure can include pointers to other
        /// structures. This size is the sum of the size needed by the decoded structure and
        /// other structures pointed to.
        /// Note  When processing the data returned in the buffer, applications must use the
        /// actual size of the data returned. The actual size can be slightly smaller than the
        /// size of the buffer specified on input. (On input, buffer sizes are usually specified
        /// large enough to ensure that the largest possible output data fits in the buffer.)
        /// On output, the variable pointed to by this parameter is updated to reflect the actual
        /// size of the data copied to the buffer.</param>
        /// <returns>If the function succeeds, the return value is nonzero (TRUE).
        /// If the function fails, the return value is zero (FALSE). For extended error
        /// information, call GetLastError.
        /// If the function fails, GetLastError may return an Abstract Syntax Notation One (ASN.1)
        /// encoding/decoding error. For information about these errors, see ASN.1 Encoding/Decoding
        /// Return Values.</returns>
        [DllImport("crypt32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptDecodeObject(
          uint CertEncodingType,
          UIntPtr lpszStructType,
          byte[] pbEncoded,
          uint cbEncoded,
          uint flags,
          [In, Out] byte[] pvStructInfo,
          ref uint cbStructInfo);
    }
}
