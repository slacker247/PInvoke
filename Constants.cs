using System;
using System.Collections.Generic;
using System.Text;

namespace PInvoke
{
    public class Constants
    {
        /// <summary>
        /// Used by AttachConsole, to allocate the console to the parent PID of the calling thread.
        /// </summary>
        const uint ATTACH_PARENT_PROCESS = 0x0ffffffff;

        /// <summary>
        /// Messages you can send to combo boxes, either in an enum or defined as a series of constants
        /// </summary>
        public const int CB_GETEDITSEL = 0x0140;
        public const int CB_LIMITTEXT = 0x0141;
        public const int CB_SETEDITSEL = 0x0142;
        public const int CB_ADDSTRING = 0x0143;
        public const int CB_DELETESTRING = 0x0144;
        public const int CB_DIR = 0x0145;
        public const int CB_GETCOUNT = 0x0146;
        public const int CB_GETCURSEL = 0x0147;
        public const int CB_GETLBTEXT = 0x0148;
        public const int CB_GETLBTEXTLEN = 0x0149;
        public const int CB_INSERTSTRING = 0x014A;
        public const int CB_RESETCONTENT = 0x014B;
        public const int CB_FINDSTRING = 0x014C;
        public const int CB_SELECTSTRING = 0x014D;
        public const int CB_SETCURSEL = 0x014E;
        public const int CB_SHOWDROPDOWN = 0x014F;
        public const int CB_GETITEMDATA = 0x0150;
        public const int CB_SETITEMDATA = 0x0151;
        public const int CB_GETDROPPEDCONTROLRECT = 0x0152;
        public const int CB_SETITEMHEIGHT = 0x0153;
        public const int CB_GETITEMHEIGHT = 0x0154;
        public const int CB_SETEXTENDEDUI = 0x0155;
        public const int CB_GETEXTENDEDUI = 0x0156;
        public const int CB_GETDROPPEDSTATE = 0x0157;
        public const int CB_FINDSTRINGEXACT = 0x0158;
        public const int CB_SETLOCALE = 345;
        public const int CB_GETLOCALE = 346;
        public const int CB_GETTOPINDEX = 347;
        public const int CB_SETTOPINDEX = 348;
        public const int CB_GETHORIZONTALEXTENT = 349;
        public const int CB_SETHORIZONTALEXTENT = 350;
        public const int CB_GETDROPPEDWIDTH = 351;
        public const int CB_SETDROPPEDWIDTH = 352;
        public const int CB_INITSTORAGE = 353;
        public const int CB_MSGMAX = 354;
        
        public const uint CERT_REQUEST_V1 = 0;

        public const Guid CLSID_TF_LangBarMgr = new Guid("EBB08C45-6C4A-4FDC-AE53-4EB8C4C7DB8E");

        public const int COLOR_SCROLLBAR = 0;
        public const int COLOR_BACKGROUND = 1;
        public const int COLOR_DESKTOP = 1;
        public const int COLOR_ACTIVECAPTION = 2;
        public const int COLOR_INACTIVECAPTION = 3;
        public const int COLOR_MENU = 4;
        public const int COLOR_WINDOW = 5;
        public const int COLOR_WINDOWFRAME = 6;
        public const int COLOR_MENUTEXT = 7;
        public const int COLOR_WINDOWTEXT = 8;
        public const int COLOR_CAPTIONTEXT = 9;
        public const int COLOR_ACTIVEBORDER = 10;
        public const int COLOR_INACTIVEBORDER = 11;
        public const int COLOR_APPWORKSPACE = 12;
        public const int COLOR_HIGHLIGHT = 13;
        public const int COLOR_HIGHLIGHTTEXT = 14;
        public const int COLOR_BTNFACE = 15;
        public const int COLOR_3DFACE = 15;
        public const int COLOR_BTNSHADOW = 16;
        public const int COLOR_3DSHADOW = 16;
        public const int COLOR_GRAYTEXT = 17;
        public const int COLOR_BTNTEXT = 18;
        public const int COLOR_INACTIVECAPTIONTEXT = 19;
        public const int COLOR_BTNHIGHLIGHT = 20;
        public const int COLOR_3DHIGHLIGHT = 20;
        public const int COLOR_3DHILIGHT = 20;
        public const int COLOR_BTNHILIGHT = 20;
        public const int COLOR_3DDKSHADOW = 21;
        public const int COLOR_3DLIGHT = 22;
        public const int COLOR_INFOTEXT = 23;
        public const int COLOR_INFOBK = 24;

        public static  readonly int CRED_TYPE_GENERIC = 1;
        public static  readonly int CRED_TYPE_DOMAIN_PASSWORD = 2;
        public static  readonly int CRED_TYPE_DOMAIN_CERTIFICATE = 3;
        public static  readonly int CRED_TYPE_DOMAIN_VISIBLE_PASSWORD = 4;
        public const int CRED_TYPE_MAXIMUM = 5; // Maximum supported cred type

        // Crypt32
        /// <summary>
        /// Specifies X.509 certificate encoding.
        /// </summary>
        public const int X509_ASN_ENCODING = 0x00000001;
        /// <summary>
        /// Specifies PKCS 7 message encoding
        /// </summary>
        public const int PKCS_7_ASN_ENCODING = 0x00010000;

        // for CertStrToName
        public const int CERT_SIMPLE_NAME_STR = 1;
        public const int CERT_OID_NAME_STR = 2;
        public const int CERT_X500_NAME_STR = 3;

        const int DACL_SECURITY_INFORMATION = 0x00000004;

        const Int32 DRIVER_PACKAGE_REPAIR = 0x00000001;
        const Int32 DRIVER_PACKAGE_SILENT = 0x00000002;
        const Int32 DRIVER_PACKAGE_FORCE = 0x00000004;
        const Int32 DRIVER_PACKAGE_ONLY_IF_DEVICE_PRESENT = 0x00000008;
        const Int32 DRIVER_PACKAGE_LEGACY_MODE = 0x00000010;
        const Int32 DRIVER_PACKAGE_DELETE_FILES = 0x00000020;

        /// <summary>
        /// Draws the icon or cursor using the mask.
        /// </summary>
        public const int DI_MASK = 0x0001;

        /// <summary>
        /// Draws the icon or cursor using the image.
        /// </summary>
        public const int DI_IMAGE = 0x0002;

        /// <summary>
        /// Combination of DI_IMAGE and DI_MASK.
        /// </summary>
        public const int DI_NORMAL = 0x0003;

        /// <summary>
        /// Draws the icon or cursor using the system default image rather than the user-specified image.
        /// For more information, see About Cursors. Windows NT4.0 and later: This flag is ignored.
        /// </summary>
        public const int DI_COMPAT = 0x0004;

        /// <summary>
        /// Draws the icon or cursor using the width and height specified by the system metric values for cursors or icons,
        /// if the cxWidth and cyWidth parameters are set to zero. If this flag is not specified and cxWidth and cyWidth are set to zero,
        /// the function uses the actual resource size.
        /// </summary>
        public const int DI_DEFAULTSIZE = 0x0008;

        /// <summary>
        /// Windows XP: Draws the icon as an unmirrored icon. By default, the icon is drawn as a mirrored icon if hdc is mirrored.
        /// </summary>
        public const int DI_NOMIRROR = 0x0010;

            // constants for Enhanced Metafile records
        public const int EMR_HEADER = 1;
        public const int EMR_POLYBEZIER = 2;
        public const int EMR_POLYGON = 3;
        public const int EMR_POLYLINE = 4;
        public const int EMR_POLYBEZIERTO = 5;
        public const int EMR_POLYLINETO = 6;
        public const int EMR_POLYPOLYLINE = 7;
        public const int EMR_POLYPOLYGON = 8;
        public const int EMR_SETWINDOWEXTEX = 9;
        public const int EMR_SETWINDOWORGEX= 10;
        public const int EMR_SETVIEWPORTEXTEX = 11;
        public const int EMR_SETVIEWPORTORGEX = 12;
        public const int EMR_SETBRUSHORGEX = 13;
        public const int EMR_EOF = 14;
        public const int EMR_SETPIXELV = 15;
        public const int EMR_SETMAPPERFLAGS = 16;
        public const int EMR_SETMAPMODE = 17;
        public const int EMR_SETBKMODE = 18;
        public const int EMR_SETPOLYFILLMODE = 19;
        public const int EMR_SETROP2 = 20;
        public const int EMR_SETSTRETCHBLTMODE = 21;
        public const int EMR_SETTEXTALIGN = 22;
        public const int EMR_SETCOLORADJUSTMENT = 23;
        public const int EMR_SETTEXTCOLOR = 24;
        public const int EMR_SETBKCOLOR = 25;
        public const int EMR_OFFSETCLIPRGN = 26;
        public const int EMR_MOVETOEX = 27;
        public const int EMR_SETMETARGN = 28;
        public const int EMR_EXCLUDECLIPRECT = 29;
        public const int EMR_INTERSECTCLIPRECT = 30;
        public const int EMR_SCALEVIEWPORTEXTEX = 31;
        public const int EMR_SCALEWINDOWEXTEX = 32;
        public const int EMR_SAVEDC = 33;
        public const int EMR_RESTOREDC = 34;
        public const int EMR_SETWORLDTRANSFORM = 35;
        public const int EMR_MODIFYWORLDTRANSFORM = 36;
        public const int EMR_SELECTOBJECT = 37;
        public const int EMR_CREATEPEN = 38;
        public const int EMR_CREATEBRUSHINDIRECT = 39;
        public const int EMR_DELETEOBJECT = 40;
        public const int EMR_ANGLEARC = 41;
        public const int EMR_ELLIPSE = 42;
        public const int EMR_RECTANGLE = 43;
        public const int EMR_ROUNDRECT = 44;
        public const int EMR_ARC = 45;
        public const int EMR_CHORD = 46;
        public const int EMR_PIE = 47;
        public const int EMR_SELECTPALETTE = 48;
        public const int EMR_CREATEPALETTE = 49;
        public const int EMR_SETPALETTEENTRIES = 50;
        public const int EMR_RESIZEPALETTE = 51;
        public const int EMR_REALIZEPALETTE = 52;
        public const int EMR_EXTFLOODFILL = 53;
        public const int EMR_LINETO = 54;
        public const int EMR_ARCTO = 55;
        public const int EMR_POLYDRAW = 56;
        public const int EMR_SETARCDIRECTION = 57;
        public const int EMR_SETMITERLIMIT = 58;
        public const int EMR_BEGINPATH = 59;
        public const int EMR_ENDPATH = 60;
        public const int EMR_CLOSEFIGURE = 61;
        public const int EMR_FILLPATH = 62;
        public const int EMR_STROKEANDFILLPATH = 63;
        public const int EMR_STROKEPATH = 64;
        public const int EMR_FLATTENPATH = 65;
        public const int EMR_WIDENPATH = 66;
        public const int EMR_SELECTCLIPPATH = 67;
        public const int EMR_ABORTPATH = 68;
        public const int EMR_GDICOMMENT = 70;
        public const int EMR_FILLRGN = 71;
        public const int EMR_FRAMERGN = 72;
        public const int EMR_INVERTRGN = 73;
        public const int EMR_PAINTRGN = 74;
        public const int EMR_EXTSELECTCLIPRGN = 75;
        public const int EMR_BITBLT = 76;
        public const int EMR_STRETCHBLT = 77;
        public const int EMR_MASKBLT = 78;
        public const int EMR_PLGBLT = 79;
        public const int EMR_SETDIBITSTODEVICE = 80;
        public const int EMR_STRETCHDIBITS = 81;
        public const int EMR_EXTCREATEFONTINDIRECTW = 82;
        public const int EMR_EXTTEXTOUTA = 83;
        public const int EMR_EXTTEXTOUTW = 84;
        public const int EMR_POLYBEZIER16 = 85;
        public const int EMR_POLYGON16 = 86;
        public const int EMR_POLYLINE16 = 87;
        public const int EMR_POLYBEZIERTO16 = 88;
        public const int EMR_POLYLINETO16 = 89;
        public const int EMR_POLYPOLYLINE16 = 90;
        public const int EMR_POLYPOLYGON16 = 91;
        public const int EMR_POLYDRAW16 = 92;
        public const int EMR_CREATEMONOBRUSH = 93;
        public const int EMR_CREATEDIBPATTERNBRUSHPT = 94;
        public const int EMR_EXTCREATEPEN = 95;
        public const int EMR_POLYTEXTOUTA = 96;
        public const int EMR_POLYTEXTOUTW = 97;
        public const int EMR_SETICMMODE = 98;
        public const int EMR_CREATECOLORSPACE = 99;
        public const int EMR_SETCOLORSPACE = 100;
        public const int EMR_DELETECOLORSPACE = 101;
        public const int EMR_GLSRECORD = 102;
        public const int EMR_GLSBOUNDEDRECORD = 103;
        public const int EMR_PIXELFORMAT = 104;
        public const int EMR_RESERVED_105 = 105;
        public const int EMR_RESERVED_106 = 106;
        public const int EMR_RESERVED_107 = 107;
        public const int EMR_RESERVED_108 = 108;
        public const int EMR_RESERVED_109 = 109;
        public const int EMR_RESERVED_110 = 110;
        public const int EMR_COLORCORRECTPALETTE = 111;
        public const int EMR_SETICMPROFILEA = 112;
        public const int EMR_SETICMPROFILEW = 113;
        public const int EMR_ALPHABLEND = 114;
        public const int EMR_SETLAYOUT = 115;
        public const int EMR_TRANSPARENTBLT = 116;
        public const int EMR_RESERVED_117 = 117;
        public const int EMR_GRADIENTFILL = 118;
        public const int EMR_RESERVED_119 = 119;
        public const int EMR_RESERVED_120 = 120;
        public const int EMR_COLORMATCHTOTARGETW = 121;
        public const int EMR_CREATECOLORSPACEW = 122;

        public const uint EM_EXGETSEL = WM_USER + 52;
        public const uint EM_EXSETSEL = WM_USER + 55;
        public const uint EM_GETCHARFORMAT = WM_USER + 58;
        public const uint EM_GETOPTIONS = WM_USER + 78;
        public const uint EM_GETSCROLLPOS = WM_USER + 221;
        public const uint EM_GETSEL = 0x00B0;
        public const uint EM_GETTEXTEX = WM_USER + 94;
        public const uint EM_GETTEXTLENGTHEX = WM_USER + 95;
        public const uint EM_SETCHARFORMAT = WM_USER + 68;
        public const uint EM_SETOPTIONS = WM_USER + 77;
        public const uint EM_SETSCROLLPOS = WM_USER + 222;
        public const uint EM_SETSEL = 0x00B1;
        public const uint EM_SETTEXTEX = WM_USER + 97;
        public const uint EM_SHOWSCROLLBAR = WM_USER + 96;

        /// <summary>
        /// Access Denied, in context of AttachConsole, it means that the
        /// console is attached elsewhere. It may have other meaning to
        /// other API functions.
        /// </summary>
        public const int ERROR_ACCESS_DENIED = 5;

        public const UInt32 EWX_LOGOFF          = 0x00000000;
        public const UInt32 EWX_SHUTDOWN        = 0x00000001;
        public const UInt32 EWX_FORCE           = 0x00000004;
        public const UInt32 EWX_POWEROFF        = 0x00000008;
        public const UInt32 EWX_FORCEIFHUNG    = 0x00000010; // Supported on Windows 2000 and larger

        public const int E_FAIL = unchecked((int) 0x80004005);

        public const int E_NOINTERFACE = unchecked((int) 0x80004002);

        public const int FILE_ATTRIBUTE_DIRECTORY = 0x10;
        public const int FILE_ATTRIBUTE_NORMAL = 0x80;
        /// <summary>
        /// This constant indicates the offset of the beginning of a file.
        /// </summary>
        public const int FILE_BEGIN = 0;
        /// <summary>
        /// This constant indicates the offset of the current position of a file pointer in a file.
        /// </summary>
        public const int FILE_CURRENT = 1;
        /// <summary>
        /// This constant indicates the offset of the end of a file.
        /// </summary>
        public const int FILE_END = 2;
        public const int FILE_SHARE_DELETE = 4;
        public const int FILE_SHARE_READ = 1;
        public const int FILE_SHARE_WRITE = 2;

        /// <summary>
        /// Indicates access rights of executing.
        /// </summary>
        public const uint GENERIC_EXECUTE = 0x10000000;
        /// <summary>
        /// Indicates access rights of reading.
        /// </summary>
        public const uint GENERIC_READ = 0x80000000;
        /// <summary>
        /// Indicates access rights of writing.
        /// </summary>
        public const uint GENERIC_WRITE = 0x40000000;

        /// <summary>
        /// constants used by the GradientFill function
        /// </summary>
        public const uint GRADIENT_FILL_RECT_H = 0x00000000;
        public const uint GRADIENT_FILL_RECT_V = 0x00000001;
        public const uint GRADIENT_FILL_TRIANGLE = 0x00000002;
        public const uint GRADIENT_FILL_OP_FLAG = 0x000000ff;

        public static Guid IID_IContextMenu  = new Guid( 0x000214E4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 );
        public static Guid IID_IContextMenu2 = new Guid( 0x000214F4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 );
        public static Guid IID_IContextMenu3 = new Guid( 0xbcfce0a0, 0xec17, 0x11d0, 0x8d, 0x10, 0x0, 0xa0, 0xc9, 0xf, 0x27, 0x19);

        /// <summary>
        /// Defines GUIDs for device classes used in Plug & Play.
        /// </summary>
        public const Guid GUID_DEVCLASS_1394 = new Guid("{0x6bdd1fc1, 0x810f, 0x11d0, {0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f}}");
        public const Guid GUID_DEVCLASS_1394DEBUG = new Guid("{0x66f250d6, 0x7801, 0x4a64, {0xb1, 0x39, 0xee, 0xa8, 0x0a, 0x45, 0x0b, 0x24}}");
        public const Guid GUID_DEVCLASS_61883 = new Guid("{0x7ebefbc0, 0x3200, 0x11d2, {0xb4, 0xc2, 0x00, 0xa0, 0xc9, 0x69, 0x7d, 0x07}}");
        public const Guid GUID_DEVCLASS_ADAPTER = new Guid("{0x4d36e964, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_APMSUPPORT = new Guid("{0xd45b1c18, 0xc8fa, 0x11d1, {0x9f, 0x77, 0x00, 0x00, 0xf8, 0x05, 0xf5, 0x30}}");
        public const Guid GUID_DEVCLASS_AVC = new Guid("{0xc06ff265, 0xae09, 0x48f0, {0x81, 0x2c, 0x16, 0x75, 0x3d, 0x7c, 0xba, 0x83}}");
        public const Guid GUID_DEVCLASS_BATTERY = new Guid("{0x72631e54, 0x78a4, 0x11d0, {0xbc, 0xf7, 0x00, 0xaa, 0x00, 0xb7, 0xb3, 0x2a}}");
        public const Guid GUID_DEVCLASS_BIOMETRIC = new Guid("{0x53d29ef7, 0x377c, 0x4d14, {0x86, 0x4b, 0xeb, 0x3a, 0x85, 0x76, 0x93, 0x59}}");
        public const Guid GUID_DEVCLASS_BLUETOOTH = new Guid("{0xe0cbf06c, 0xcd8b, 0x4647, {0xbb, 0x8a, 0x26, 0x3b, 0x43, 0xf0, 0xf9, 0x74}}");
        public const Guid GUID_DEVCLASS_CDROM = new Guid("{0x4d36e965, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_COMPUTER = new Guid("{0x4d36e966, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_DECODER = new Guid("{0x6bdd1fc2, 0x810f, 0x11d0, {0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f}}");
        public const Guid GUID_DEVCLASS_DISKDRIVE = new Guid("{0x4d36e967, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_DISPLAY = new Guid("{0x4d36e968, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_DOT4 = new Guid("{0x48721b56, 0x6795, 0x11d2, {0xb1, 0xa8, 0x00, 0x80, 0xc7, 0x2e, 0x74, 0xa2}}");
        public const Guid GUID_DEVCLASS_DOT4PRINT = new Guid("{0x49ce6ac8, 0x6f86, 0x11d2, {0xb1, 0xe5, 0x00, 0x80, 0xc7, 0x2e, 0x74, 0xa2}}");
        public const Guid GUID_DEVCLASS_ENUM1394 = new Guid("{0xc459df55, 0xdb08, 0x11d1, {0xb0, 0x09, 0x00, 0xa0, 0xc9, 0x08, 0x1f, 0xf6}}");
        public const Guid GUID_DEVCLASS_FDC = new Guid("{0x4d36e969, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_FLOPPYDISK = new Guid("{0x4d36e980, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_GPS = new Guid("{0x6bdd1fc3, 0x810f, 0x11d0, {0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f}}");
        public const Guid GUID_DEVCLASS_HDC = new Guid("{0x4d36e96a, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_HIDCLASS = new Guid("{0x745a17a0, 0x74d3, 0x11d0, {0xb6, 0xfe, 0x00, 0xa0, 0xc9, 0x0f, 0x57, 0xda}}");
        public const Guid GUID_DEVCLASS_IMAGE = new Guid("{0x6bdd1fc6, 0x810f, 0x11d0, {0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f}}");
        public const Guid GUID_DEVCLASS_INFINIBAND = new Guid("{0x30ef7132, 0xd858, 0x4a0c, {0xac, 0x24, 0xb9, 0x02, 0x8a, 0x5c, 0xca, 0x3f}}");
        public const Guid GUID_DEVCLASS_INFRARED = new Guid("{0x6bdd1fc5, 0x810f, 0x11d0, {0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f}}");
        public const Guid GUID_DEVCLASS_KEYBOARD = new Guid("{0x4d36e96b, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_LEGACYDRIVER = new Guid("{0x8ecc055d, 0x047f, 0x11d1, {0xa5, 0x37, 0x00, 0x00, 0xf8, 0x75, 0x3e, 0xd1}}");
        public const Guid GUID_DEVCLASS_MEDIA = new Guid("{0x4d36e96c, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_MEDIUM_CHANGER = new Guid("{0xce5939ae, 0xebde, 0x11d0, {0xb1, 0x81, 0x00, 0x00, 0xf8, 0x75, 0x3e, 0xc4}}");
        public const Guid GUID_DEVCLASS_MODEM = new Guid("{0x4d36e96d, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_MONITOR = new Guid("{0x4d36e96e, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_MOUSE = new Guid("{0x4d36e96f, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_MTD = new Guid("{0x4d36e970, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_MULTIFUNCTION = new Guid("{0x4d36e971, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_MULTIPORTSERIAL = new Guid("{0x50906cb8, 0xba12, 0x11d1, {0xbf, 0x5d, 0x00, 0x00, 0xf8, 0x05, 0xf5, 0x30}}");
        public const Guid GUID_DEVCLASS_NET = new Guid("{0x4d36e972, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_NETCLIENT = new Guid("{0x4d36e973, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_NETSERVICE = new Guid("{0x4d36e974, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_NETTRANS = new Guid("{0x4d36e975, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_NODRIVER = new Guid("{0x4d36e976, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_PCMCIA = new Guid("{0x4d36e977, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_PNPPRINTERS = new Guid("{0x4658ee7e, 0xf050, 0x11d1, {0xb6, 0xbd, 0x00, 0xc0, 0x4f, 0xa3, 0x72, 0xa7}}");
        public const Guid GUID_DEVCLASS_PORTS = new Guid("{0x4d36e978, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_PRINTER = new Guid("{0x4d36e979, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_PRINTERUPGRADE = new Guid("{0x4d36e97a, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_PROCESSOR = new Guid("{0x50127dc3, 0x0f36, 0x415e, {0xa6, 0xcc, 0x4c, 0xb3, 0xbe, 0x91, 0x0B, 0x65}}");
        public const Guid GUID_DEVCLASS_SBP2 = new Guid("{0xd48179be, 0xec20, 0x11d1, {0xb6, 0xb8, 0x00, 0xc0, 0x4f, 0xa3, 0x72, 0xa7}}");
        public const Guid GUID_DEVCLASS_SCSIADAPTER = new Guid("{0x4d36e97b, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_SECURITYACCELERATOR = new Guid("{0x268c95a1, 0xedfe, 0x11d3, {0x95, 0xc3, 0x00, 0x10, 0xdc, 0x40, 0x50, 0xa5}}");
        public const Guid GUID_DEVCLASS_SMARTCARDREADER = new Guid("{0x50dd5230, 0xba8a, 0x11d1, {0xbf, 0x5d, 0x00, 0x00, 0xf8, 0x05, 0xf5, 0x30}}");
        public const Guid GUID_DEVCLASS_SOUND = new Guid("{0x4d36e97c, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_SYSTEM = new Guid("{0x4d36e97d, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_TAPEDRIVE = new Guid("{0x6d807884, 0x7d21, 0x11cf, {0x80, 0x1c, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_UNKNOWN = new Guid("{0x4d36e97e, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public const Guid GUID_DEVCLASS_USB = new Guid("{0x36fc9e60, 0xc465, 0x11cf, {0x80, 0x56, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00}}");
        public const Guid GUID_DEVCLASS_VOLUME = new Guid("{0x71a27cdd, 0x812a, 0x11d0, {0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f}}");
        public const Guid GUID_DEVCLASS_VOLUMESNAPSHOT = new Guid("{0x533c5b84, 0xec70, 0x11d2, {0x95, 0x05, 0x00, 0xc0, 0x4f, 0x79, 0xde, 0xaf}}");
        public const Guid GUID_DEVCLASS_WCEUSBS = new Guid("{0x25dbce51, 0x6c8f, 0x4a72, {0x8a, 0x6d, 0xb5, 0x4c, 0x2b, 0x4f, 0xc8, 0x35}}");
        public const Guid GUID_DEVCLASS_FSFILTER_ACTIVITYMONITOR = new Guid("{0xb86dff51, 0xa31e, 0x4bac, {0xb3, 0xcf, 0xe8, 0xcf, 0xe7, 0x5c, 0x9f, 0xc2}}");
        public const Guid GUID_DEVCLASS_FSFILTER_UNDELETE = new Guid("{0xfe8f1572, 0xc67a, 0x48c0, {0xbb, 0xac, 0x0b, 0x5c, 0x6d, 0x66, 0xca, 0xfb}}");
        public const Guid GUID_DEVCLASS_FSFILTER_ANTIVIRUS = new Guid("{0xb1d1a169, 0xc54f, 0x4379, {0x81, 0xdb, 0xbe, 0xe7, 0xd8, 0x8d, 0x74, 0x54}}");
        public const Guid GUID_DEVCLASS_FSFILTER_REPLICATION = new Guid("{0x48d3ebc4, 0x4cf8, 0x48ff, {0xb8, 0x69, 0x9c, 0x68, 0xad, 0x42, 0xeb, 0x9f}}");
        public const Guid GUID_DEVCLASS_FSFILTER_CONTINUOUSBACKUP = new Guid("{0x71aa14f8, 0x6fad, 0x4622, {0xad, 0x77, 0x92, 0xbb, 0x9d, 0x7e, 0x69, 0x47}}");
        public const Guid GUID_DEVCLASS_FSFILTER_CONTENTSCREENER = new Guid("{0x3e3f0674, 0xc83c, 0x4558, {0xbb, 0x26, 0x98, 0x20, 0xe1, 0xeb, 0xa5, 0xc5}}");
        public const Guid GUID_DEVCLASS_FSFILTER_QUOTAMANAGEMENT = new Guid("{0x8503c911, 0xa6c7, 0x4919, {0x8f, 0x79, 0x50, 0x28, 0xf5, 0x86, 0x6b, 0x0c}}");
        public const Guid GUID_DEVCLASS_FSFILTER_SYSTEMRECOVERY = new Guid("{0x2db15374, 0x706e, 0x4131, {0xa0, 0xc7, 0xd7, 0xc7, 0x8e, 0xb0, 0x28, 0x9a}}");
        public const Guid GUID_DEVCLASS_FSFILTER_CFSMETADATASERVER = new Guid("{0xcdcf0939, 0xb75b, 0x4630, {0xbf, 0x76, 0x80, 0xf7, 0xba, 0x65, 0x58, 0x84}}");
        public const Guid GUID_DEVCLASS_FSFILTER_HSM = new Guid("{0xd546500a, 0x2aeb, 0x45f6, {0x94, 0x82, 0xf4, 0xb1, 0x79, 0x9c, 0x31, 0x77}}");
        public const Guid GUID_DEVCLASS_FSFILTER_COMPRESSION = new Guid("{0xf3586baf, 0xb5aa, 0x49b5, {0x8d, 0x6c, 0x05, 0x69, 0x28, 0x4c, 0x63, 0x9f}}");
        public const Guid GUID_DEVCLASS_FSFILTER_ENCRYPTION = new Guid("{0xa0a701c0, 0xa511, 0x42ff, {0xaa, 0x6c, 0x06, 0xdc, 0x03, 0x95, 0x57, 0x6f}}");
        public const Guid GUID_DEVCLASS_FSFILTER_PHYSICALQUOTAMANAGEMENT = new Guid("{0x6a0a8e78, 0xbba6, 0x4fc4, {0xa7, 0x09, 0x1e, 0x33, 0xcd, 0x09, 0xd6, 0x7e}}");
        public const Guid GUID_DEVCLASS_FSFILTER_OPENFILEBACKUP = new Guid("{0xf8ecafa6, 0x66d1, 0x41a5, {0x89, 0x9b, 0x66, 0x58, 0x5d, 0x72, 0x16, 0xb7}}");
        public const Guid GUID_DEVCLASS_FSFILTER_SECURITYENHANCER = new Guid("{0xd02bc3da, 0x0c8e, 0x4945, {0x9b, 0xd5, 0xf1, 0x88, 0x3c, 0x22, 0x6c, 0x8c}}");
        public const Guid GUID_DEVCLASS_FSFILTER_COPYPROTECTION = new Guid("{0x89786ff1, 0x9c12, 0x402f, {0x9c, 0x9e, 0x17, 0x75, 0x3c, 0x7f, 0x43, 0x75}}");
        public const Guid GUID_DEVCLASS_FSFILTER_SYSTEM = new Guid("{0x5d1b9aaa, 0x01e2, 0x46af, {0x84, 0x9f, 0x27, 0x2b, 0x3f, 0x32, 0x4c, 0x46}}");
        public const Guid GUID_DEVCLASS_FSFILTER_INFRASTRUCTURE = new Guid("{0xe55fa6f9, 0x128c, 0x4d04, {0xab, 0xab, 0x63, 0x0c, 0x74, 0xb1, 0x45, 0x3a}}");

        /// <summary>
        /// System-Defined Device Interface Classes (Windows Drivers)
        /// </summary>
        public static Guid BUS1394_CLASS_GUID = new Guid("6BDD1FC1-810F-11d0-BEC7-08002BE2092F");
        public static Guid GUID_61883_CLASS = new Guid("7EBEFBC0-3200-11d2-B4C2-00A0C9697D07");
        public static Guid GUID_DEVICE_APPLICATIONLAUNCH_BUTTON = new Guid("629758EE-986E-4D9E-8E47-DE27F8AB054D");
        public static Guid GUID_DEVICE_BATTERY = new Guid("72631E54-78A4-11D0-BCF7-00AA00B7B32A");
        public static Guid GUID_DEVICE_LID = new Guid("4AFA3D52-74A7-11d0-be5e-00A0C9062857");
        public static Guid GUID_DEVICE_MEMORY = new Guid("3FD0F03D-92E0-45FB-B75C-5ED8FFB01021");
        public static Guid GUID_DEVICE_MESSAGE_INDICATOR = new Guid("CD48A365-FA94-4CE2-A232-A1B764E5D8B4");
        public static Guid GUID_DEVICE_PROCESSOR = new Guid("97FADB10-4E33-40AE-359C-8BEF029DBDD0");
        public static Guid GUID_DEVICE_SYS_BUTTON = new Guid("4AFA3D53-74A7-11d0-be5e-00A0C9062857");
        public static Guid GUID_DEVICE_THERMAL_ZONE = new Guid("4AFA3D51-74A7-11d0-be5e-00A0C9062857");
        public static Guid GUID_BTHPORT_DEVICE_INTERFACE = new Guid("0850302A-B344-4fda-9BE9-90576B8D46F0");
        public static Guid GUID_DEVINTERFACE_BRIGHTNESS = new Guid("FDE5BBA4-B3F9-46FB-BDAA-0728CE3100B4");
        public static Guid GUID_DEVINTERFACE_DISPLAY_ADAPTER = new Guid("5B45201D-F2F2-4F3B-85BB-30FF1F953599");
        public static Guid GUID_DEVINTERFACE_I2C = new Guid("2564AA4F-DDDB-4495-B497-6AD4A84163D7");
        public static Guid GUID_DEVINTERFACE_IMAGE = new Guid("6BDD1FC6-810F-11D0-BEC7-08002BE2092F");
        public static Guid GUID_DEVINTERFACE_MONITOR = new Guid("E6F07B5F-EE97-4a90-B076-33F57BF4EAA7");
        public static Guid GUID_DEVINTERFACE_OPM = new Guid("BF4672DE-6B4E-4BE4-A325-68A91EA49C09");
        public static Guid GUID_DEVINTERFACE_VIDEO_OUTPUT_ARRIVAL = new Guid("1AD9E4F0-F88D-4360-BAB9-4C2D55E564CD");
        public static Guid GUID_DISPLAY_DEVICE_ARRIVAL = new Guid("1CA05180-A699-450A-9A0C-DE4FBE3DDD89");
        public static Guid GUID_DEVINTERFACE_HID = new Guid("4D1E55B2-F16F-11CF-88CB-001111000030");
        public static Guid GUID_DEVINTERFACE_KEYBOARD = new Guid("884b96c3-56ef-11d1-bc8c-00a0c91405dd");
        public static Guid GUID_DEVINTERFACE_MOUSE = new Guid("378DE44C-56EF-11D1-BC8C-00A0C91405DD");
        public static Guid GUID_DEVINTERFACE_MODEM = new Guid("2C7089AA-2E0E-11D1-B114-00C04FC2AAE4");
        public static Guid GUID_DEVINTERFACE_NET = new Guid("CAC88484-7515-4C03-82E6-71A87ABAC361");
        public static Guid GUID_DEVINTERFACE_SENSOR = new Guid(0XBA1BB692, 0X9B7A, 0X4833, 0X9A, 0X1E, 0X52, 0X5E, 0XD1, 0X34, 0XE7, 0XE2);
        public static Guid GUID_DEVINTERFACE_COMPORT = new Guid("86E0D1E0-8089-11D0-9CE4-08003E301F73");
        public static Guid GUID_DEVINTERFACE_PARALLEL = new Guid("97F76EF0-F883-11D0-AF1F-0000F800845C");
        public static Guid GUID_DEVINTERFACE_PARCLASS = new Guid("811FC6A5-F728-11D0-A537-0000F8753ED1");
        public static Guid GUID_DEVINTERFACE_SERENUM_BUS_ENUMERATOR = new Guid("4D36E978-E325-11CE-BFC1-08002BE10318");
        public static Guid GUID_DEVINTERFACE_CDCHANGER = new Guid("53F56312-B6BF-11D0-94F2-00A0C91EFB8B");
        public static Guid GUID_DEVINTERFACE_CDROM = new Guid("53F56308-B6BF-11D0-94F2-00A0C91EFB8B");
        public static Guid GUID_DEVINTERFACE_DISK = new Guid("53F56307-B6BF-11D0-94F2-00A0C91EFB8B");
        public static Guid GUID_DEVINTERFACE_FLOPPY = new Guid("53F56311-B6BF-11D0-94F2-00A0C91EFB8B");
        public static Guid GUID_DEVINTERFACE_MEDIUMCHANGER = new Guid("53F56310-B6BF-11D0-94F2-00A0C91EFB8B");
        public static Guid GUID_DEVINTERFACE_PARTITION = new Guid("53F5630A-B6BF-11D0-94F2-00A0C91EFB8B");
        public static Guid GUID_DEVINTERFACE_STORAGEPORT = new Guid("2ACCFE60-C130-11D2-B082-00A0C91EFB8B");
        public static Guid GUID_DEVINTERFACE_TAPE = new Guid("53F5630B-B6BF-11D0-94F2-00A0C91EFB8B");
        public static Guid GUID_DEVINTERFACE_VOLUME = new Guid("53F5630D-B6BF-11D0-94F2-00A0C91EFB8B");
        public static Guid GUID_DEVINTERFACE_WRITEONCEDISK = new Guid("53F5630C-B6BF-11D0-94F2-00A0C91EFB8B");
        public static Guid GUID_IO_VOLUME_DEVICE_INTERFACE = new Guid("53F5630D-B6BF-11D0-94F2-00A0C91EFB8B");
        public static Guid MOUNTDEV_MOUNTED_DEVICE_GUID = new Guid("53F5630D-B6BF-11D0-94F2-00A0C91EFB8B");
        public static Guid GUID_AVC_CLASS = new Guid("095780C3-48A1-4570-BD95-46707F78C2DC");
        public static Guid GUID_VIRTUAL_AVC_CLASS = new Guid("616EF4D0-23CE-446D-A568-C31EB01913D0");
        public static Guid KSCATEGORY_ACOUSTIC_ECHO_CANCEL = new Guid("BF963D80-C559-11D0-8A2B-00A0C9255AC1");
        public static Guid KSCATEGORY_AUDIO = new Guid("6994AD04-93EF-11D0-A3CC-00A0C9223196");
        public static Guid KSCATEGORY_AUDIO_DEVICE = new Guid("FBF6F530-07B9-11D2-A71E-0000F8004788");
        public static Guid KSCATEGORY_AUDIO_GFX = new Guid("9BAF9572-340C-11D3-ABDC-00A0C90AB16F");
        public static Guid KSCATEGORY_AUDIO_SPLITTER = new Guid("9EA331FA-B91B-45F8-9285-BD2BC77AFCDE");
        public static Guid KSCATEGORY_BDA_IP_SINK = new Guid("71985F4A-1CA1-11d3-9CC8-00C04F7971E0");
        public static Guid KSCATEGORY_BDA_NETWORK_EPG = new Guid("71985F49-1CA1-11d3-9CC8-00C04F7971E0");
        public static Guid KSCATEGORY_BDA_NETWORK_PROVIDER = new Guid("71985F4B-1CA1-11d3-9CC8-00C04F7971E0");
        public static Guid KSCATEGORY_BDA_NETWORK_TUNER = new Guid("71985F48-1CA1-11d3-9CC8-00C04F7971E0");
        public static Guid KSCATEGORY_BDA_RECEIVER_COMPONENT = new Guid("FD0A5AF4-B41D-11d2-9C95-00C04F7971E0");
        public static Guid KSCATEGORY_BDA_TRANSPORT_INFORMATION = new Guid("A2E3074F-6C3D-11d3-B653-00C04F79498E");
        public static Guid KSCATEGORY_BRIDGE = new Guid("085AFF00-62CE-11CF-A5D6-28DB04C10000");
        public static Guid KSCATEGORY_CAPTURE = new Guid("65E8773D-8F56-11D0-A3B9-00A0C9223196");
        public static Guid KSCATEGORY_CLOCK = new Guid("53172480-4791-11D0-A5D6-28DB04C10000");
        public static Guid KSCATEGORY_COMMUNICATIONSTRANSFORM = new Guid("CF1DDA2C-9743-11D0-A3EE-00A0C9223196");
        public static Guid KSCATEGORY_CROSSBAR = new Guid("A799A801-A46D-11D0-A18C-00A02401DCD4");
        public static Guid KSCATEGORY_DATACOMPRESSOR = new Guid("1E84C900-7E70-11D0-A5D6-28DB04C10000");
        public static Guid KSCATEGORY_DATADECOMPRESSOR = new Guid("2721AE20-7E70-11D0-A5D6-28DB04C10000");
        public static Guid KSCATEGORY_DATATRANSFORM = new Guid("2EB07EA0-7E70-11D0-A5D6-28DB04C10000");
        public static Guid KSCATEGORY_DRM_DESCRAMBLE = new Guid("FFBB6E3F-CCFE-4D84-90D9-421418B03A8E");
        public static Guid KSCATEGORY_ENCODER = new Guid("19689BF6-C384-48fd-AD51-90E58C79F70B");
        public static Guid KSCATEGORY_ESCALANTE_PLATFORM_DRIVER = new Guid("74F3AEA8-9768-11D1-8E07-00A0C95EC22E");
        public static Guid KSCATEGORY_FILESYSTEM = new Guid("760FED5E-9357-11D0-A3CC-00A0C9223196");
        public static Guid KSCATEGORY_INTERFACETRANSFORM = new Guid("CF1DDA2D-9743-11D0-A3EE-00A0C9223196");
        public static Guid KSCATEGORY_MEDIUMTRANSFORM = new Guid("CF1DDA2E-9743-11D0-A3EE-00A0C9223196");
        public static Guid KSCATEGORY_MICROPHONE_ARRAY_PROCESSOR = new Guid("830A44F2-A32D-476B-BE97-42845673B35A");
        public static Guid KSCATEGORY_MIXER = new Guid("AD809C00-7B88-11D0-A5D6-28DB04C10000");
        public static Guid KSCATEGORY_MULTIPLEXER = new Guid("7A5DE1D3-01A1-452c-B481-4FA2B96271E8");
        public static Guid KSCATEGORY_NETWORK = new Guid("67C9CC3C-69C4-11D2-8759-00A0C9223196");
        public static Guid KSCATEGORY_PREFERRED_MIDIOUT_DEVICE = new Guid("D6C50674-72C1-11D2-9755-0000F8004788");
        public static Guid KSCATEGORY_PREFERRED_WAVEIN_DEVICE = new Guid("D6C50671-72C1-11D2-9755-0000F8004788");
        public static Guid KSCATEGORY_PREFERRED_WAVEOUT_DEVICE = new Guid("D6C5066E-72C1-11D2-9755-0000F8004788");
        public static Guid KSCATEGORY_PROXY = new Guid("97EBAACA-95BD-11D0-A3EA-00A0C9223196");
        public static Guid KSCATEGORY_QUALITY = new Guid("97EBAACB-95BD-11D0-A3EA-00A0C9223196");
        public static Guid KSCATEGORY_REALTIME = new Guid("EB115FFC-10C8-4964-831D-6DCB02E6F23F");
        public static Guid KSCATEGORY_RENDER = new Guid("65E8773E-8F56-11D0-A3B9-00A0C9223196");
        public static Guid KSCATEGORY_SPLITTER = new Guid("0A4252A0-7E70-11D0-A5D6-28DB04C10000");
        public static Guid KSCATEGORY_SYNTHESIZER = new Guid("DFF220F3-F70F-11D0-B917-00A0C9223196");
        public static Guid KSCATEGORY_SYSAUDIO = new Guid("A7C7A5B1-5AF3-11D1-9CED-00A024BF0407");
        public static Guid KSCATEGORY_TEXT = new Guid("6994AD06-93EF-11D0-A3CC-00A0C9223196");
        public static Guid KSCATEGORY_TOPOLOGY = new Guid("DDA54A40-1E4C-11D1-A050-405705C10000");
        public static Guid KSCATEGORY_TVAUDIO = new Guid("A799A802-A46D-11D0-A18C-00A02401DCD4");
        public static Guid KSCATEGORY_TVTUNER = new Guid("A799A800-A46D-11D0-A18C-00A02401DCD4");
        public static Guid KSCATEGORY_VBICODEC = new Guid("07DAD660-22F1-11D1-A9F4-00C04FBBDE8F");
        public static Guid KSCATEGORY_VIDEO = new Guid("6994AD05-93EF-11D0-A3CC-00A0C9223196");
        public static Guid KSCATEGORY_VIRTUAL = new Guid("3503EAC4-1F26-11D1-8AB0-00A0C9223196");
        public static Guid KSCATEGORY_VPMUX = new Guid("A799A803-A46D-11D0-A18C-00A02401DCD4");
        public static Guid KSCATEGORY_WDMAUD = new Guid("3E227E76-690D-11D2-8161-0000F8775BF1");
        public static Guid KSMFT_CATEGORY_AUDIO_DECODER = new Guid("9ea73fb4-ef7a-4559-8d5d-719d8f0426c7");
        public static Guid KSMFT_CATEGORY_AUDIO_EFFECT = new Guid("11064c48-3648-4ed0-932e-05ce8ac811b7");
        public static Guid KSMFT_CATEGORY_AUDIO_ENCODER = new Guid("91c64bd0-f91e-4d8c-9276-db248279d975");
        public static Guid KSMFT_CATEGORY_DEMULTIPLEXER = new Guid("a8700a7a-939b-44c5-99d7-76226b23b3f1");
        public static Guid KSMFT_CATEGORY_MULTIPLEXER = new Guid("059c561e-05ae-4b61-b69d-55b61ee54a7b");
        public static Guid KSMFT_CATEGORY_OTHER = new Guid("90175d57-b7ea-4901-aeb3-933a8747756f");
        public static Guid KSMFT_CATEGORY_VIDEO_DECODER = new Guid("d6c02d4b-6833-45b4-971a-05a4b04bab91");
        public static Guid KSMFT_CATEGORY_VIDEO_EFFECT = new Guid("12e17c21-532c-4a6e-8a1c-40825a736397");
        public static Guid KSMFT_CATEGORY_VIDEO_ENCODER = new Guid("f79eac7d-e545-4387-bdee-d647d7bde42a");
        public static Guid KSMFT_CATEGORY_VIDEO_PROCESSOR = new Guid("302ea3fc-aa5f-47f9-9f7a-c2188bb16302");
        public static Guid GUID_DEVINTERFACE_USB_DEVICE = new Guid("A5DCBF10-6530-11D2-901F-00C04FB951ED");
        public static Guid GUID_DEVINTERFACE_USB_HOST_CONTROLLER = new Guid("3ABF6F2D-71C4-462A-8A92-1E6861E6AF27");
        public static Guid GUID_DEVINTERFACE_USB_HUB = new Guid("F18A0E88-C30C-11D0-8815-00A0C906BED8");
        public static Guid GUID_DEVINTERFACE_WPD = new Guid("6AC27878-A6FA-4155-BA85-F98F491D4F33");
        public static Guid GUID_DEVINTERFACE_WPD_PRIVATE = new Guid("BA0C718F-4DED-49B7-BDD3-FABE28661211");
        public static Guid GUID_DEVINTERFACE_SIDESHOW = new Guid("152E5811-FEB9-4B00-90F4-D32947AE1681");

        /// <summary>
        /// The Globally Unique Identifier (GUID) for the
        /// "Interface" for a USB Host Controller
        /// </summary>
        public const string GUID_DEVINTERFACE_HUBCONTROLLER = "3abf6f2d-71c4-462a-8a92-1e6861e6af27";

        /// <summary>
        /// Specifies the relationship between the specified window
        /// and the window whose handle is to be retrieved.
        /// </summary>
        public const uint GW_HWNDFIRST = 0;
        public const uint GW_HWNDLAST = 1;
        public const uint GW_HWNDNEXT = 2;
        public const uint GW_HWNDPREV = 3;
        public const uint GW_OWNER = 4;
        public const uint GW_CHILD = 5;
        public const uint GW_ENABLEDPOPUP = 6;
        public const uint GW_MAX = 6;
        //Windows version <= 0x0400
#if WIN_VER
        public const uint GW_HWNDFIRST = 0;
        public const uint GW_HWNDLAST = 1;
        public const uint GW_HWNDNEXT = 2;
        public const uint GW_HWNDPREV = 3;
        public const uint GW_OWNER = 4;
        public const uint GW_CHILD = 5;
        public const uint GW_MAX = 5;
#endif

        public const int GWL_WNDPROC =(-4);
        public const int GWL_HINSTANCE =(-6);
        public const int GWL_HWNDPARENT =(-8);
        public const int GWL_STYLE =(-16);
        public const int GWL_EXSTYLE =(-20);
        public const int GWL_USERDATA =(-21);
        public const int GWL_ID =(-12);

        public const IntPtr HKEY_LOCAL_MACHINE = new IntPtr(-2147483646);

        /// <summary>
        /// Perform initialization for applications that use the HTTP
        /// configuration functions, HttpSetServiceConfiguration,
        /// HttpQueryServiceConfiguration and HttpDeleteServiceConfiguration.
        /// </summary>
        public const uint HTTP_INITIALIZE_CONFIG = 0x00000002;

        /// <summary>
        /// Perform initialization for applications that use the HTTP API.
        /// </summary>
        public const uint HTTP_INITIALIZE_SERVER = 0x00000001;

        /// <summary>
        /// HWND constants (from winuser.h)
        /// </summary>
        public const IntPtr HWND_BROADCAST = new IntPtr(0xffff);
        public const IntPtr HWND_TOP       = new IntPtr(0);
        public const IntPtr HWND_BOTTOM    = new IntPtr(1);
        public const IntPtr HWND_TOPMOST   = new IntPtr(-1);
        public const IntPtr HWND_NOTOPMOST = new IntPtr(-2);

        /// <summary>
        /// To create a message-only window, use the SetParent function
        /// to set the parent of a window to HWND_MESSAGE, or use
        /// HWND_MESSAGE as the parent in the CreateWindow or
        /// CreateWindowEx function.
        /// </summary>
        public const IntPtr HWND_MESSAGE = new IntPtr(-3);

        /// IDANI_ - DrawAnimatedRects constants
        /// <summary>
        /// This constant is not implemented on any Windows platform!
        /// </summary>
        public const Int32 IDANI_OPEN = 1;

        /// <summary>
        /// The window caption will animate from lprcFrom to lprcTo.
        /// </summary>
        public const Int32 IDANI_CAPTION = 3;

        /// <summary>
        /// Defines some of the default system cursors.
        /// </summary>
        public const int IDC_ARROW = 32512;
        public const int IDC_IBEAM = 32513;
        public const int IDC_WAIT = 32514;
        public const int IDC_CROSS = 32515;
        public const int IDC_UPARROW = 32516;
        public const int IDC_SIZE = 32640;
        public const int IDC_ICON = 32641;
        public const int IDC_SIZENWSE = 32642;
        public const int IDC_SIZENESW = 32643;
        public const int IDC_SIZEWE = 32644;
        public const int IDC_SIZENS = 32645;
        public const int IDC_SIZEALL = 32646;
        public const int IDC_NO = 32648;
        public const int IDC_HAND = 32649;
        public const int IDC_APPSTARTING = 32650;
        public const int IDC_HELP = 32651;

        public const Guid IID_IDispatch = new Guid("{00020400-0000-0000-C000-000000000046}");
        public const Guid IID_IDispatchEx = new Guid("{a6ef9860-c720-11d0-9337-00a0c90dcaa9}");
        public const Guid IID_IPersistPropertyBag = new Guid("{37D84F60-42CB-11CE-8135-00AA004BB851}");
        public const Guid IID_IPersistStorage = new Guid("{0000010A-0000-0000-C000-000000000046}");
        public const Guid IID_IPersistStream = new Guid("{00000109-0000-0000-C000-000000000046}");
        public const Guid IID_ITfLangBarMgr = new Guid("87955690-e627-11d2-8ddb-00105a2799b5");
        public const Guid IID_TopLevelBrowser = new Guid("4C96BE40-915C-11CF-99D3-00AA004AE837");
        public const Guid IID_WebBrowserApp = new Guid("0002DF05-0000-0000-C000-000000000046");

        /// constants used by CopyImage and LoadImage.
        /// <summary>
        /// Loads a bitmap.
        /// </summary>
        public const int IMAGE_BITMAP = 0;

        /// <summary>
        /// Loads an icon.
        /// </summary>
        public const int IMAGE_ICON = 1;

        /// <summary>
        /// Loads a cursor.
        /// </summary>
        public const int IMAGE_CURSOR = 2;

        /// <summary>
        /// Loads an enhanced metafile.
        /// </summary>
        public const int IMAGE_ENHMETAFILE = 3;

        /// <summary>
        /// Specifies that the style of the INF file is unrecognized or nonexistent.
        /// </summary>
        public const Int32 INF_STYLE_NONE = 0x00000000;

        /// <summary>
        /// A legacy INF file format.
        /// </summary>
        public const Int32 INF_STYLE_OLDNT = 0x00000001;

        /// <summary>
        /// A Windows INF file format.
        /// </summary>
        public const Int32 INF_STYLE_WIN4 = 0x00000002;

        public const int INTERFACESAFE_FOR_UNTRUSTED_CALLER = 0x00000001;
        public const int INTERFACESAFE_FOR_UNTRUSTED_DATA = 0x00000002;

        /// <summary>
        /// This is returned by GetFileAttributes if the function fails
        /// </summary>
        public const Int64 INVALID_FILE_ATTRIBUTES = -1;
        public const IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

        /// <summary>
        /// Used with DeviceIoControl and DRIVE_LAYOUT_INFORMATION_EX to
        /// retetrieve extended information for each entry in the partition tables for a disk.
        /// </summary>
        public const uint IOCTL_DISK_GET_DRIVE_LAYOUT_EX = 0x00070050;

        public const long WS_MINIMIZE = 0x20000000L;
        public const long WS_VISIBLE = 0x10000000L;
        public const long WS_EX_APPWINDOW = 0x00040000L;
        public const long WS_EX_TOOLWINDOW = 0x00000080L;
        public const short SWP_NOMOVE = 0X2;
        public const short SWP_NOSIZE = 1;
        public const short SWP_NOZORDER = 0X4;
        public const int SWP_SHOWWINDOW = 0x0040;

        public const UInt32 WM_ACTIVATE = 0x0006;
        public const UInt32 WM_ACTIVATEAPP = 0x001C;
        public const UInt32 WM_AFXFIRST = 0x0360;
        public const UInt32 WM_AFXLAST = 0x037F;
        public const UInt32 WM_APP = 0x8000;
        public const UInt32 WM_ASKCBFORMATNAME = 0x030C;
        public const UInt32 WM_CANCELJOURNAL = 0x004B;
        public const UInt32 WM_CANCELMODE = 0x001F;
        public const UInt32 WM_CAPTURECHANGED = 0x0215;
        public const UInt32 WM_CHANGECBCHAIN = 0x030D;
        public const UInt32 WM_CHANGEUISTATE = 0x0127;
        public const UInt32 WM_CHAR = 0x0102;
        public const UInt32 WM_CHARTOITEM = 0x002F;
        public const UInt32 WM_CHILDACTIVATE = 0x0022;
        public const UInt32 WM_CLEAR = 0x0303;
        public const UInt32 WM_CLOSE = 0x0010;
        public const UInt32 WM_COMMAND = 0x0111;
        public const UInt32 WM_COMPACTING = 0x0041;
        public const UInt32 WM_COMPAREITEM = 0x0039;
        public const UInt32 WM_CONTEXTMENU = 0x007B;
        public const UInt32 WM_COPY = 0x0301;
        public const UInt32 WM_COPYDATA = 0x004A;
        public const UInt32 WM_CREATE = 0x0001;
        public const UInt32 WM_CTLCOLORBTN = 0x0135;
        public const UInt32 WM_CTLCOLORDLG = 0x0136;
        public const UInt32 WM_CTLCOLOREDIT = 0x0133;
        public const UInt32 WM_CTLCOLORLISTBOX = 0x0134;
        public const UInt32 WM_CTLCOLORMSGBOX = 0x0132;
        public const UInt32 WM_CTLCOLORSCROLLBAR = 0x0137;
        public const UInt32 WM_CTLCOLORSTATIC = 0x0138;
        public const UInt32 WM_CUT = 0x0300;
        public const UInt32 WM_DEADCHAR = 0x0103;
        public const UInt32 WM_DELETEITEM = 0x002D;
        public const UInt32 WM_DESTROY = 0x0002;
        public const UInt32 WM_DESTROYCLIPBOARD = 0x0307;
        public const UInt32 WM_DEVICECHANGE = 0x0219;
        public const UInt32 WM_DEVMODECHANGE = 0x001B;
        public const UInt32 WM_DISPLAYCHANGE = 0x007E;
        public const UInt32 WM_DRAWCLIPBOARD = 0x0308;
        public const UInt32 WM_DRAWITEM = 0x002B;
        public const UInt32 WM_DROPFILES = 0x0233;
        public const UInt32 WM_ENABLE = 0x000A;
        public const UInt32 WM_ENDSESSION = 0x0016;
        public const UInt32 WM_ENTERIDLE = 0x0121;
        public const UInt32 WM_ENTERMENULOOP = 0x0211;
        public const UInt32 WM_ENTERSIZEMOVE = 0x0231;
        public const UInt32 WM_ERASEBKGND = 0x0014;
        public const UInt32 WM_EXITMENULOOP = 0x0212;
        public const UInt32 WM_EXITSIZEMOVE = 0x0232;
        public const UInt32 WM_FONTCHANGE = 0x001D;
        public const UInt32 WM_GETDLGCODE = 0x0087;
        public const UInt32 WM_GETFONT = 0x0031;
        public const UInt32 WM_GETHOTKEY = 0x0033;
        public const UInt32 WM_GETICON = 0x007F;
        public const UInt32 WM_GETMINMAXINFO = 0x0024;
        public const UInt32 WM_GETOBJECT = 0x003D;
        public const UInt32 WM_GETTEXT = 0x000D;
        public const UInt32 WM_GETTEXTLENGTH = 0x000E;
        public const UInt32 WM_HANDHELDFIRST = 0x0358;
        public const UInt32 WM_HANDHELDLAST = 0x035F;
        public const UInt32 WM_HELP = 0x0053;
        public const UInt32 WM_HOTKEY = 0x0312;
        public const UInt32 WM_HSCROLL = 0x0114;
        public const UInt32 WM_HSCROLLCLIPBOARD = 0x030E;
        public const UInt32 WM_ICONERASEBKGND = 0x0027;
        public const UInt32 WM_IME_CHAR = 0x0286;
        public const UInt32 WM_IME_COMPOSITION = 0x010F;
        public const UInt32 WM_IME_COMPOSITIONFULL = 0x0284;
        public const UInt32 WM_IME_CONTROL = 0x0283;
        public const UInt32 WM_IME_ENDCOMPOSITION = 0x010E;
        public const UInt32 WM_IME_KEYDOWN = 0x0290;
        public const UInt32 WM_IME_KEYLAST = 0x010F;
        public const UInt32 WM_IME_KEYUP = 0x0291;
        public const UInt32 WM_IME_NOTIFY = 0x0282;
        public const UInt32 WM_IME_REQUEST = 0x0288;
        public const UInt32 WM_IME_SELECT = 0x0285;
        public const UInt32 WM_IME_SETCONTEXT = 0x0281;
        public const UInt32 WM_IME_STARTCOMPOSITION = 0x010D;
        public const UInt32 WM_INITDIALOG = 0x0110;
        public const UInt32 WM_INITMENU = 0x0116;
        public const UInt32 WM_INITMENUPOPUP = 0x0117;
        public const UInt32 WM_INPUTLANGCHANGE = 0x0051;
        public const UInt32 WM_INPUTLANGCHANGEREQUEST = 0x0050;
        public const UInt32 WM_KEYDOWN = 0x0100;
        public const UInt32 WM_KEYFIRST = 0x0100;
        public const UInt32 WM_KEYLAST = 0x0108;
        public const UInt32 WM_KEYUP = 0x0101;
        public const UInt32 WM_KILLFOCUS = 0x0008;
        public const UInt32 WM_LBUTTONDBLCLK = 0x0203;
        public const UInt32 WM_LBUTTONDOWN = 0x0201;
        public const UInt32 WM_LBUTTONUP = 0x0202;
        public const UInt32 WM_MBUTTONDBLCLK = 0x0209;
        public const UInt32 WM_MBUTTONDOWN = 0x0207;
        public const UInt32 WM_MBUTTONUP = 0x0208;
        public const UInt32 WM_MDIACTIVATE = 0x0222;
        public const UInt32 WM_MDICASCADE = 0x0227;
        public const UInt32 WM_MDICREATE = 0x0220;
        public const UInt32 WM_MDIDESTROY = 0x0221;
        public const UInt32 WM_MDIGETACTIVE = 0x0229;
        public const UInt32 WM_MDIICONARRANGE = 0x0228;
        public const UInt32 WM_MDIMAXIMIZE = 0x0225;
        public const UInt32 WM_MDINEXT = 0x0224;
        public const UInt32 WM_MDIREFRESHMENU = 0x0234;
        public const UInt32 WM_MDIRESTORE = 0x0223;
        public const UInt32 WM_MDISETMENU = 0x0230;
        public const UInt32 WM_MDITILE = 0x0226;
        public const UInt32 WM_MEASUREITEM = 0x002C;
        public const UInt32 WM_MENUCHAR = 0x0120;
        public const UInt32 WM_MENUCOMMAND = 0x0126;
        public const UInt32 WM_MENUDRAG = 0x0123;
        public const UInt32 WM_MENUGETOBJECT = 0x0124;
        public const UInt32 WM_MENURBUTTONUP = 0x0122;
        public const UInt32 WM_MENUSELECT = 0x011F;
        public const UInt32 WM_MOUSEACTIVATE = 0x0021;
        public const UInt32 WM_MOUSEFIRST = 0x0200;
        public const UInt32 WM_MOUSEHOVER = 0x02A1;
        public const UInt32 WM_MOUSELAST = 0x020D;
        public const UInt32 WM_MOUSELEAVE = 0x02A3;
        public const UInt32 WM_MOUSEMOVE = 0x0200;
        public const UInt32 WM_MOUSEWHEEL = 0x020A;
        public const UInt32 WM_MOUSEHWHEEL = 0x020E;
        public const UInt32 WM_MOVE = 0x0003;
        public const UInt32 WM_MOVING = 0x0216;
        public const UInt32 WM_NCACTIVATE = 0x0086;
        public const UInt32 WM_NCCALCSIZE = 0x0083;
        public const UInt32 WM_NCCREATE = 0x0081;
        public const UInt32 WM_NCDESTROY = 0x0082;
        public const UInt32 WM_NCHITTEST = 0x0084;
        public const UInt32 WM_NCLBUTTONDBLCLK = 0x00A3;
        public const UInt32 WM_NCLBUTTONDOWN = 0x00A1;
        public const UInt32 WM_NCLBUTTONUP = 0x00A2;
        public const UInt32 WM_NCMBUTTONDBLCLK = 0x00A9;
        public const UInt32 WM_NCMBUTTONDOWN = 0x00A7;
        public const UInt32 WM_NCMBUTTONUP = 0x00A8;
        public const UInt32 WM_NCMOUSEHOVER = 0x02A0;
        public const UInt32 WM_NCMOUSELEAVE = 0x02A2;
        public const UInt32 WM_NCMOUSEMOVE = 0x00A0;
        public const UInt32 WM_NCPAINT = 0x0085;
        public const UInt32 WM_NCRBUTTONDBLCLK = 0x00A6;
        public const UInt32 WM_NCRBUTTONDOWN = 0x00A4;
        public const UInt32 WM_NCRBUTTONUP = 0x00A5;
        public const UInt32 WM_NCXBUTTONDBLCLK = 0x00AD;
        public const UInt32 WM_NCXBUTTONDOWN = 0x00AB;
        public const UInt32 WM_NCXBUTTONUP = 0x00AC;
        public const UInt32 WM_NCUAHDRAWCAPTION = 0x00AE;
        public const UInt32 WM_NCUAHDRAWFRAME = 0x00AF;
        public const UInt32 WM_NEXTDLGCTL = 0x0028;
        public const UInt32 WM_NEXTMENU = 0x0213;
        public const UInt32 WM_NOTIFY = 0x004E;
        public const UInt32 WM_NOTIFYFORMAT = 0x0055;
        public const UInt32 WM_NULL = 0x0000;
        public const UInt32 WM_PAINT = 0x000F;
        public const UInt32 WM_PAINTCLIPBOARD = 0x0309;
        public const UInt32 WM_PAINTICON = 0x0026;
        public const UInt32 WM_PALETTECHANGED = 0x0311;
        public const UInt32 WM_PALETTEISCHANGING = 0x0310;
        public const UInt32 WM_PARENTNOTIFY = 0x0210;
        public const UInt32 WM_PASTE = 0x0302;
        public const UInt32 WM_PENWINFIRST = 0x0380;
        public const UInt32 WM_PENWINLAST = 0x038F;
        public const UInt32 WM_POWER = 0x0048;
        public const UInt32 WM_POWERBROADCAST = 0x0218;
        public const UInt32 WM_PRINT = 0x0317;
        public const UInt32 WM_PRINTCLIENT = 0x0318;
        public const UInt32 WM_QUERYDRAGICON = 0x0037;
        public const UInt32 WM_QUERYENDSESSION = 0x0011;
        public const UInt32 WM_QUERYNEWPALETTE = 0x030F;
        public const UInt32 WM_QUERYOPEN = 0x0013;
        public const UInt32 WM_QUEUESYNC = 0x0023;
        public const UInt32 WM_QUIT = 0x0012;
        public const UInt32 WM_RBUTTONDBLCLK = 0x0206;
        public const UInt32 WM_RBUTTONDOWN = 0x0204;
        public const UInt32 WM_RBUTTONUP = 0x0205;
        public const UInt32 WM_RENDERALLFORMATS = 0x0306;
        public const UInt32 WM_RENDERFORMAT = 0x0305;
        public const UInt32 WM_SETCURSOR = 0x0020;
        public const UInt32 WM_SETFOCUS = 0x0007;
        public const UInt32 WM_SETFONT = 0x0030;
        public const UInt32 WM_SETHOTKEY = 0x0032;
        public const UInt32 WM_SETICON = 0x0080;
        public const UInt32 WM_SETREDRAW = 0x000B;
        public const UInt32 WM_SETTEXT = 0x000C;
        public const UInt32 WM_SETTINGCHANGE = 0x001A;
        public const UInt32 WM_SHOWWINDOW = 0x0018;
        public const UInt32 WM_SIZE = 0x0005;
        public const UInt32 WM_SIZECLIPBOARD = 0x030B;
        public const UInt32 WM_SIZING = 0x0214;
        public const UInt32 WM_SPOOLERSTATUS = 0x002A;
        public const UInt32 WM_STYLECHANGED = 0x007D;
        public const UInt32 WM_STYLECHANGING = 0x007C;
        public const UInt32 WM_SYNCPAINT = 0x0088;
        public const UInt32 WM_SYSCHAR = 0x0106;
        public const UInt32 WM_SYSCOLORCHANGE = 0x0015;
        public const UInt32 WM_SYSCOMMAND = 0x0112;
        public const UInt32 WM_SYSDEADCHAR = 0x0107;
        public const UInt32 WM_SYSKEYDOWN = 0x0104;
        public const UInt32 WM_SYSKEYUP = 0x0105;
        public const UInt32 WM_TCARD = 0x0052;
        public const UInt32 WM_TIMECHANGE = 0x001E;
        public const UInt32 WM_TIMER = 0x0113;
        public const UInt32 WM_UNDO = 0x0304;
        public const UInt32 WM_UNINITMENUPOPUP = 0x0125;
        public const UInt32 WM_USER = 0x0400;
        public const UInt32 WM_USERCHANGED = 0x0054;
        public const UInt32 WM_VKEYTOITEM = 0x002E;
        public const UInt32 WM_VSCROLL = 0x0115;
        public const UInt32 WM_VSCROLLCLIPBOARD = 0x030A;
        public const UInt32 WM_WINDOWPOSCHANGED = 0x0047;
        public const UInt32 WM_WINDOWPOSCHANGING = 0x0046;
        public const UInt32 WM_WININICHANGE = 0x001A;
        public const UInt32 WM_XBUTTONDBLCLK = 0x020D;
        public const UInt32 WM_XBUTTONDOWN = 0x020B;
        public const UInt32 WM_XBUTTONUP = 0x020C;

        public const int LOGON32_LOGON_INTERACTIVE = 2;
        public const int LOGON32_PROVIDER_DEFAULT = 0;


        /// <summary>
        /// The object is stored in a structure in memory.
        /// </summary>
        public const Int32 CERT_QUERY_OBJECT_BLOB = 2;
        /// <summary>
        /// The object is stored in a file.
        /// </summary>
        public const Int32 CERT_QUERY_OBJECT_FILE = 1;
        /// <summary>
        /// The content is a single certificate.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_FLAG_CERT = 1 << CERT_QUERY_CONTENT_CERT;
        /// <summary>
        /// The content is an Abstract Syntax Notation One (ASN.1) encoded X509_CERT_PAIR
        /// (an encoded certificate pair that contains either forward, reverse, or forward
        /// and reverse cross certificates).
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_FLAG_CERT_PAIR = 1 << CERT_QUERY_CONTENT_CERT_PAIR;
        /// <summary>
        /// The content is a single CRL.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_FLAG_CRL = 1 << CERT_QUERY_CONTENT_CRL;
        /// <summary>
        /// The content is a single CTL.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_FLAG_CTL = 1 << CERT_QUERY_CONTENT_CTL;
        /// <summary>
        /// The content is a PFX (PKCS #12) packet, but it will not be loaded by
        /// this function. You can use the PFXImportCertStore function to load this
        /// into a store.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_FLAG_PFX = 1 << CERT_QUERY_CONTENT_PFX;
        /// <summary>
        /// The content is a PFX (PKCS #12) packet and will be loaded by this function subject
        /// to the conditions specified in the following note.
        /// 
        /// Note  
        /// 
        /// If the PFX packet contains an embedded password that is not an empty string or NULL,
        /// and the password was not protected to an Active Directory (AD) principal that
        /// includes the calling user, this function will not be able to decrypt the PFX packet.
        /// The packet can be decrypted, however, if the password used when the PFX packet was
        /// created was encrypted to an AD principal and the user, as part of that principal,
        /// has permission to decrypt the password. For more information, see the pvPara parameter
        /// and the PKCS12_PROTECT_TO_DOMAIN_SIDS flag of the PFXExportCertStoreEx function.
        /// 
        /// You can protect PFX passwords to an AD principal beginning in Windows 8 and
        /// Windows Server 2012.
        /// 
        /// Windows Server 2003 and Windows XP:  This value is not supported.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_FLAG_PFX_AND_LOAD = 1 << CERT_QUERY_CONTENT_PFX_AND_LOAD;
        /// <summary>
        /// The content is a PKCS #7 signed message.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED = 1 << CERT_QUERY_CONTENT_PKCS7_SIGNED;
        /// <summary>
        /// The content is an embedded PKCS #7 signed message.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED_EMBED = 1 << CERT_QUERY_CONTENT_PKCS7_SIGNED_EMBED;
        /// <summary>
        /// The content is a PKCS #7 unsigned message.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_FLAG_PKCS7_UNSIGNED = 1 << CERT_QUERY_CONTENT_PKCS7_UNSIGNED;
        /// <summary>
        /// The content is a PKCS #10 message.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_FLAG_PKCS10 = 1 << CERT_QUERY_CONTENT_PKCS10;
        /// <summary>
        /// The content is a serialized single certificate.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_FLAG_SERIALIZED_CERT = 1 << CERT_QUERY_CONTENT_SERIALIZED_CERT;
        /// <summary>
        /// The content is a serialized single CRL.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_FLAG_SERIALIZED_CRL = 1 << CERT_QUERY_CONTENT_SERIALIZED_CRL;
        /// <summary>
        /// The content is serialized single CTL.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_FLAG_SERIALIZED_CTL = 1 << CERT_QUERY_CONTENT_SERIALIZED_CTL;
        /// <summary>
        /// The content is a serialized store.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_FLAG_SERIALIZED_STORE = 1 << CERT_QUERY_CONTENT_SERIALIZED_STORE;
        /// <summary>
        /// The content can be any type. This does not include the CERT_QUERY_CONTENT_FLAG_PFX_AND_LOAD flag.
        /// If this flag is specified, this function will attempt to obtain information about the object,
        /// trying different content types until the proper content type is found or the content types are
        /// exhausted. This is obviously inefficient, so this flag should only be used if the content type
        /// is not known.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_FLAG_ALL = CERT_QUERY_CONTENT_FLAG_CERT | CERT_QUERY_CONTENT_FLAG_CERT_PAIR | CERT_QUERY_CONTENT_FLAG_CRL | CERT_QUERY_CONTENT_FLAG_CTL | CERT_QUERY_CONTENT_FLAG_PFX | CERT_QUERY_CONTENT_FLAG_PFX_AND_LOAD | CERT_QUERY_CONTENT_FLAG_PKCS10 | CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED | CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED_EMBED | CERT_QUERY_CONTENT_FLAG_PKCS7_UNSIGNED | CERT_QUERY_CONTENT_FLAG_SERIALIZED_CERT | CERT_QUERY_CONTENT_FLAG_SERIALIZED_CRL | CERT_QUERY_CONTENT_FLAG_SERIALIZED_CTL | CERT_QUERY_CONTENT_FLAG_SERIALIZED_STORE;
        /// <summary>
        /// The content can be returned in any format.
        /// </summary>
        public const Int32 CERT_QUERY_FORMAT_FLAG_ALL = CERT_QUERY_FORMAT_FLAG_BINARY | CERT_QUERY_FORMAT_FLAG_BASE64_ENCODED | CERT_QUERY_FORMAT_FLAG_ASN_ASCII_HEX_ENCODED;
        /// <summary>
        /// The content should be returned in ASCII hex-encoded format with a "{ASN}" prefix.
        /// </summary>
        public const Int32 CERT_QUERY_FORMAT_FLAG_ASN_ASCII_HEX_ENCODED = 1 << CERT_QUERY_FORMAT_ASN_ASCII_HEX_ENCODED;
        /// <summary>
        /// The content should be returned in Base64 encoded format.
        /// </summary>
        public const Int32 CERT_QUERY_FORMAT_FLAG_BASE64_ENCODED = 1 << CERT_QUERY_FORMAT_BASE64_ENCODED;
        /// <summary>
        /// The content should be returned in binary format.
        /// </summary>
        public const Int32 CERT_QUERY_FORMAT_FLAG_BINARY = 1 << CERT_QUERY_FORMAT_BINARY;
        /// <summary>
        /// The content is a single certificate.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_CERT = 1;
        /// <summary>
        /// The content is an ASN.1 encoded X509_CERT_pair.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_CERT_PAIR = 13;
        /// <summary>
        /// The content is a single CRL.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_CRL = 3;
        /// <summary>
        /// The content is a single CTL.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_CTL = 2;
        /// <summary>
        /// The content is a PFX (PKCS #12) packet. This function only verifies that the object is 
        /// a PKCS #12 packet. The PKCS #12 packet is not loaded into a certificate store.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_PFX = 12;
        /// <summary>
        /// The content is a PFX (PKCS #12) packet, and it has been loaded into a certificate store.
        /// 
        /// Windows Server 2003 and Windows XP:  This value is not supported.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_PFX_AND_LOAD = 14;
        /// <summary>
        /// The content is a PKCS #7 signed message.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_PKCS7_SIGNED = 8;
        /// <summary>
        /// The content is an embedded PKCS #7 signed message.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_PKCS7_SIGNED_EMBED = 10;
        /// <summary>
        /// The content is a PKCS #7 unsigned message.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_PKCS7_UNSIGNED = 9;
        /// <summary>
        /// The content is a PKCS #10 message.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_PKCS10 = 11;
        /// <summary>
        /// The content is a serialized single certificate.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_SERIALIZED_CERT = 5;
        /// <summary>
        /// The content is a serialized single CRL.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_SERIALIZED_CRL = 7;
        /// <summary>
        /// The content is a serialized single CTL.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_SERIALIZED_CTL = 6;
        /// <summary>
        /// The content is a serialized store.
        /// </summary>
        public const Int32 CERT_QUERY_CONTENT_SERIALIZED_STORE = 4;
        /// <summary>
        /// The content is in ASCII hex-encoded format with an "{ASN}" prefix.
        /// </summary>
        public const Int32 CERT_QUERY_FORMAT_ASN_ASCII_HEX_ENCODED = 3;
        /// <summary>
        /// The content is in Base64 encoded format.
        /// </summary>
        public const Int32 CERT_QUERY_FORMAT_BASE64_ENCODED = 2;
        /// <summary>
        /// The content is in binary format.
        /// </summary>
        public const Int32 CERT_QUERY_FORMAT_BINARY = 1;

        /// <summary>
        /// pvData data type: pointer to a DWORD
        /// Returns the count of the attribute certificates in a SIGNED or ENVELOPED message.
        /// </summary>
        public const uint CMSG_ATTR_CERT_COUNT_PARAM = 31;
        /// <summary>
        /// pvData data type: pointer to a BYTE array
        /// Retrieves an attribute certificate. To get all the attribute certificates, call
        /// CryptMsgGetParam varying dwIndex set to 0 the number of attributes minus one.
        /// </summary>
        public const uint CMSG_ATTR_CERT_PARAM = 32;
        /// <summary>
        /// pvData data type: pointer to a BYTE array
        /// Retrieves the encoded content of an encoded cryptographic message, without the outer 
        /// layer of the CONTENT_INFO structure. That is, only the encoding of the PKCS #7 defined
        /// ContentInfo.content field is returned.
        /// </summary>
        public const uint CMSG_BARE_CONTENT_PARAM = 3;
        /// <summary>
        /// pvData data type: pointer to DWORD
        /// Returns the number of certificates in a received SIGNED or ENVELOPED message.
        /// </summary>
        public const uint CMSG_CERT_COUNT_PARAM = 11;
        /// <summary>
        /// pvData data type: pointer to a BYTE array
        /// Returns a signer's certificate. To get all of the signer's certificates, call
        /// CryptMsgGetParam, varying dwIndex from 0 to the number of available certificates
        /// minus one.
        /// </summary>
        public const uint CMSG_CERT_PARAM = 12;
        /// <summary>
        /// pvData data type: pointer to a BYTE array
        /// Returns the hash calculated of the data in the message. This type is applicable to both
        /// encode and decode.
        /// </summary>
        public const uint CMSG_COMPUTED_HASH_PARAM = 22;
        /// <summary>
        /// pvData data type: pointer to a BYTE array
        /// Returns the whole PKCS #7 message from a message opened to encode. Retrieves the inner
        /// content of a message opened to decode. If the message is enveloped, the inner type is data,
        /// and CryptMsgControl has been called to decrypt the message, the decrypted content is returned.
        /// If the inner type is not data, the encoded BLOB that requires further decoding is returned.
        /// If the message is not enveloped and the inner content is DATA, the returned data is the
        /// octets of the inner content. This type is applicable to both encode and decode.
        /// 
        /// For decoding, if the type is CMSG_DATA, the content's octets are returned; else, the encoded
        /// inner content is returned.
        /// </summary>
        public const uint CMSG_CONTENT_PARAM = 2;
        /// <summary>
        /// pvData data type: pointer to DWORD
        /// Returns the count of CRLs in a received, SIGNED or ENVELOPED message.
        /// </summary>
        public const uint CMSG_CRL_COUNT_PARAM = 13;
        /// <summary>
        /// pvData data type: pointer to a BYTE array
        /// Returns a CRL. To get all the CRLs, call CryptMsgGetParam, varying dwIndex from 0 to the
        /// number of available CRLs minus one.
        /// </summary>
        public const uint CMSG_CRL_PARAM = 14;
        /// <summary>
        /// pvData data type: pointer to a BYTE array
        /// Changes the contents of an already encoded message. The message must first be decoded
        /// with a call to CryptMsgOpenToDecode. Then the change to the message is made through a
        /// call to CryptMsgControl, CryptMsgCountersign, or CryptMsgCountersignEncoded. The message
        /// is then encoded again with a call to CryptMsgGetParam, specifying CMSG_ENCODED_MESSAGE
        /// to get a new encoding that reflects the changes made. This can be used, for instance, to
        /// add a time-stamp attribute to a message.
        /// </summary>
        public const uint CMSG_ENCODED_MESSAGE = 29;
        /// <summary>
        /// pvData data type: pointer to a BYTE array
        /// Returns the encoded CMSG_SIGNER_INFO signer information for a message signer.
        /// </summary>
        public const uint CMSG_ENCODED_SIGNER = 28;
        /// <summary>
        /// pvData data type: pointer to a BYTE array
        /// Returns the encrypted hash of a signature. Typically used for performing time-stamping.
        /// </summary>
        public const uint CMSG_ENCRYPTED_DIGEST = 27;
        /// <summary>
        /// pvData data type: pointer to a BYTE array for a CRYPT_ALGORITHM_IDENTIFIER structure.
        /// Returns the encryption algorithm used to encrypted the message.
        /// </summary>
        public const uint CMSG_ENCRYPT_PARAM = 26;
        /// <summary>
        /// pvData data type: pointer to a BYTE array for a CRYPT_ALGORITHM_IDENTIFIER structure.
        /// Returns the encryption algorithm used to encrypt an ENVELOPED message.
        /// </summary>
        public const uint CMSG_ENVELOPE_ALGORITHM_PARAM = 15;
        /// <summary>
        /// pvData data type: pointer to a BYTE array for a CRYPT_ALGORITHM_IDENTIFIER structure.
        /// Returns the hash algorithm used to hash the message when it was created.
        /// </summary>
        public const uint CMSG_HASH_ALGORITHM_PARAM = 20;
        /// <summary>
        /// pvData data type: pointer to a BYTE array
        /// Returns the hash value stored in the message when it was created.
        /// </summary>
        public const uint CMSG_HASH_DATA_PARAM = 21;
        /// <summary>
        /// pvData data type: pointer to a BYTE array to receive a null-terminated object identifier
        /// (OID) string.
        /// Returns the inner content type of a received message. This type is not applicable to
        /// messages of type DATA.
        /// </summary>
        public const uint CMSG_INNER_CONTENT_TYPE_PARAM = 4;
        /// <summary>
        /// pvData data type: pointer to a DWORD
        /// Returns the number of key transport recipients of an ENVELOPED received message.
        /// </summary>
        public const uint CMSG_RECIPIENT_COUNT_PARAM = 17;
        /// <summary>
        /// pvData data type: pointer to DWORD
        /// Returns the total count of all message recipients including key agreement and mail list
        /// recipients.
        /// </summary>
        public const uint CMSG_CMS_RECIPIENT_COUNT_PARAM = 33;
        /// <summary>
        /// pvData data type: pointer to a DWORD
        /// Returns the index of the key transport recipient used to decrypt an ENVELOPED message.
        /// This value is available only after a message has been decrypted.
        /// </summary>
        public const uint CMSG_RECIPIENT_INDEX_PARAM = 18;
        /// <summary>
        /// pvData data type: pointer to a DWORD
        /// Returns the index of the key transport, key agreement, or mail list recipient used to
        /// decrypt an ENVELOPED message.
        /// </summary>
        public const uint CMSG_CMS_RECIPIENT_INDEX_PARAM = 34;
        /// <summary>
        /// pvData data type: pointer to a DWORD
        /// Returns the index of the encrypted key of a key agreement recipient used to decrypt an
        /// ENVELOPED message.
        /// </summary>
        public const uint CMSG_CMS_RECIPIENT_ENCRYPTED_KEY_INDEX_PARAM = 35;
        /// <summary>
        /// pvData data type: pointer to a BYTE array to receive a CERT_INFO structure.
        /// Returns certificate information about a key transport message's recipient. To get
        /// certificate information on all key transport message's recipients, repetitively call
        /// CryptMsgGetParam, varying dwIndex from 0 to the number of recipients minus one. Only
        /// the Issuer, SerialNumber, and PublicKeyAlgorithm members of the CERT_INFO structure
        /// returned are available and valid.
        /// </summary>
        public const uint CMSG_RECIPIENT_INFO_PARAM = 19;
        /// <summary>
        /// pvData data type: pointer to a BYTE array to receive a CMSG_CMS_RECIPIENT_INFO structure.
        /// Returns information about a key transport, key agreement, or mail list recipient. It is
        /// not limited to key transport message recipients. To get information on all of a message's
        /// recipients, repetitively call CryptMsgGetParam, varying dwIndex from 0 to the number of
        /// recipients minus one.
        /// </summary>
        public const uint CMSG_CMS_RECIPIENT_INFO_PARAM = 36;
        /// <summary>
        /// pvData data type: pointer to a BYTE array to receive a CRYPT_ATTRIBUTES structure.
        /// Returns the authenticated attributes of a message signer. To retrieve the authenticated
        /// attributes for a specified signer, call CryptMsgGetParam with dwIndex equal to that
        /// signer's index.
        /// </summary>
        public const uint CMSG_SIGNER_AUTH_ATTR_PARAM = 9;
        /// <summary>
        /// pvData data type: pointer to a BYTE array to receive the CERT_INFO structure.
        /// Returns information on a message signer needed to identify the signer's certificate. A
        /// certificate's Issuer and SerialNumber can be used to uniquely identify a certificate
        /// for retrieval. To retrieve information for all the signers, repetitively call
        /// CryptMsgGetParam varying dwIndex from 0 to the number of signers minus one. Only the
        /// Issuer and SerialNumber fields in the CERT_INFO structure returned contain available,
        /// valid data.
        /// </summary>
        public const uint CMSG_SIGNER_CERT_INFO_PARAM = 7;
        /// <summary>
        /// pvData data type: pointer to a BYTE array to receive a CERT_ID structure.
        /// Returns information on a message signer needed to identify the signer's public key. This
        /// could be a certificate's Issuer and SerialNumber, a KeyID, or a HashId. To retrieve
        /// information for all the signers, call CryptMsgGetParam varying dwIndex from 0 to the
        /// number of signers minus one.
        /// </summary>
        public const uint CMSG_SIGNER_CERT_ID_PARAM = 38;
        /// <summary>
        /// pvData data type: pointer to a DWORD
        /// Returns the number of signers of a received SIGNED message.
        /// </summary>
        public const uint CMSG_SIGNER_COUNT_PARAM = 5;
        /// <summary>
        /// pvData data type: pointer to a BYTE array to receive the CRYPT_ALGORITHM_IDENTIFIER structure.
        /// Returns the hash algorithm used by a signer of the message. To get the hash algorithm for
        /// a specified signer, call CryptMsgGetParam with dwIndex equal to that signer's index.
        /// </summary>
        public const uint CMSG_SIGNER_HASH_ALGORITHM_PARAM = 8;
        /// <summary>
        /// pvData data type: pointer to a BYTE array to receive a CMSG_SIGNER_INFO structure.
        /// Returns information on a message signer. This includes the issuer and serial number of
        /// the signer's certificate and authenticated and unauthenticated attributes of the
        /// signer's certificate. To retrieve signer information on all of the signers of a message,
        /// call CryptMsgGetParam varying dwIndex from 0 to the number of signers minus one.
        /// </summary>
        public const uint CMSG_SIGNER_INFO_PARAM = 6;
        /// <summary>
        /// pvData data type: pointer to a BYTE array to receive a CMSG_CMS_SIGNER_INFO structure.
        /// Returns information on a message signer. This includes a signerId and authenticated and
        /// unauthenticated attributes. To retrieve signer information on all of the signers of a
        /// message, call CryptMsgGetParam varying dwIndex from 0 to the number of signers minus one.
        /// </summary>
        public const uint CMSG_CMS_SIGNER_INFO_PARAM = 39;
        /// <summary>
        /// pvData data type: pointer to a BYTE array to receive a CRYPT_ATTRIBUTES structure.
        /// Returns a message signer's unauthenticated attributes. To retrieve the unauthenticated
        /// attributes for a specified signer, call CryptMsgGetParam with dwIndex equal to that
        /// signer's index.
        /// </summary>
        public const uint CMSG_SIGNER_UNAUTH_ATTR_PARAM = 10;
        /// <summary>
        /// pvData data type: pointer to a DWORD
        /// Returns the message type of a decoded message of unknown type. The retrieved message
        /// type can be compared to supported types to determine whether processing can continued.
        /// For supported message types, see the dwMessageType parameter of CryptMsgOpenToDecode.
        /// </summary>
        public const uint CMSG_TYPE_PARAM = 1;
        /// <summary>
        /// pvData data type: pointer to a BYTE array to receive a CMSG_ATTR structure.
        /// Returns the unprotected attributes in an enveloped message.
        /// </summary>
        public const uint CMSG_UNPROTECTED_ATTR_PARAM = 37;
        /// <summary>
        /// pvData data type: pointer to a DWORD
        /// Returns the version of the decoded message. For more information, see the table in the
        /// Remarks section.
        /// </summary>
        public const uint CMSG_VERSION_PARAM = 30;

        /// <summary>
        /// The message does not contain the requested attributes.
        /// </summary>
        public const uint CRYPT_E_ATTRIBUTES_MISSING = 0x80091004;
        /// <summary>
        /// The index value is not valid.
        /// </summary>
        public const uint CRYPT_E_INVALID_INDEX = 0x80091008;
        /// <summary>
        /// The message type is not valid.
        /// </summary>
        public const uint CRYPT_E_INVALID_MSG_TYPE = 0x80091004;
        /// <summary>
        /// The message content has not been decrypted yet.
        /// </summary>
        public const uint CRYPT_E_NOT_DECRYPTED = 0x8009100A;
        /// <summary>
        /// The object identifier is badly formatted.
        /// </summary>
        public const uint CRYPT_E_OID_FORMAT = 0x80091003;
        /// <summary>
        /// The message is not encoded as expected.
        /// </summary>
        public const uint CRYPT_E_UNEXPECTED_ENCODING = 0x80091005;
        /// <summary>
        /// No certificate was found matching the search criteria. This can happen
        /// if the store is empty or the end of the store's list is reached.
        /// </summary>
        public const uint CRYPT_E_NOT_FOUND = 0x80092004;
        /// <summary>
        /// One or more arguments are not valid.
        /// </summary>
        public const uint E_INVALIDARG = 0x80070057;
        /// <summary>
        /// The specified buffer is not large enough to hold the returned data.
        /// </summary>
        public const uint ERROR_MORE_DATA = 0xEA;

        /// <summary>
        /// Data type of pvFindPara: NULL, not used.
        /// No search criteria used. Returns the next certificate in the store.
        /// Note  The order of the certificate context may not be preserved within
        /// the store. To access a specific certificate you must iterate across the
        /// certificates in the store.
        /// </summary>
        public const uint CERT_FIND_ANY = CERT_COMPARE_ANY << CERT_COMPARE_SHIFT;
        /// <summary>
        /// Data type of pvFindPara: CERT_ID structure.
        /// Find the certificate identified by the specified CERT_ID.
        /// </summary>
        public const uint CERT_FIND_CERT_ID = CERT_COMPARE_CERT_ID << CERT_COMPARE_SHIFT;
        /// <summary>
        /// Data type of pvFindPara: CTL_USAGE structure.
        /// Searches for a certificate that has a szOID_ENHANCED_KEY_USAGE extension or
        /// a CERT_CTL_PROP_ID that matches the pszUsageIdentifier member of the CTL_USAGE
        /// structure.
        /// </summary>
        public const uint CERT_FIND_CTL_USAGE = CERT_FIND_ENHKEY_USAGE;
        /// <summary>
        /// Data type of pvFindPara: CERT_ENHKEY_USAGE structure.
        /// Searches for a certificate in the store that has either an enhanced key usage extension
        /// or an enhanced key usage property and a usage identifier that matches the
        /// cUsageIdentifier member in the CERT_ENHKEY_USAGE structure.
        /// A certificate has an enhanced key usage extension if it has a CERT_EXTENSION structure
        /// with the pszObjId member set to szOID_ENHANCED_KEY_USAGE.
        /// A certificate has an enhanced key usage property if its CERT_ENHKEY_USAGE_PROP_ID
        /// identifier is set.
        /// If CERT_FIND_OPTIONAL_ENHKEY_USAGE_FLAG is set in dwFindFlags, certificates without the
        /// key usage extension or property are also matches. Setting this flag takes precedence
        /// over passing NULL in pvFindPara.
        /// If CERT_FIND_EXT_ONLY_ENHKEY_USAGE_FLAG is set, a match is done only on the key usage
        /// extension.
        /// For information about flag modifications to search criteria, see Remarks.
        /// </summary>
        public const uint CERT_FIND_ENHKEY_USAGE = CERT_COMPARE_ENHKEY_USAGE << CERT_COMPARE_SHIFT;
        /// <summary>
        /// Data type of pvFindPara: CERT_CONTEXT structure.
        /// Searches for a certificate that is an exact match of the specified certificate context.
        /// </summary>
        public const uint CERT_FIND_EXISTING = CERT_COMPARE_EXISTING << CERT_COMPARE_SHIFT;
        /// <summary>
        /// Data type of pvFindPara: CRYPT_HASH_BLOB structure.
        /// Searches for a certificate with a SHA1 hash that matches the hash in the CRYPT_HASH_BLOB structure.
        /// </summary>
        public const uint CERT_FIND_HASH = CERT_FIND_SHA1_HASH;
        /// <summary>
        /// Data type of pvFindPara: NULL, not used.
        /// Searches for a certificate that has a private key. The key can be ephemeral or saved
        /// on disk. The key can be a legacy Cryptography API (CAPI) key or a CNG key.
        /// Note  The order of the certificate context may not be preserved within the store.
        /// Therefore, to access a specific certificate, you must iterate across all certificates.
        /// Windows 8 and Windows Server 2012:  Support for this flag begins.
        /// </summary>
        public const uint CERT_FIND_HAS_PRIVATE_KEY = (CERT_COMPARE_HAS_PRIVATE_KEY << CERT_COMPARE_SHIFT);
        /// <summary>
        /// Data type of pvFindPara: CERT_RDN structure.
        /// Searches for a certificate with specified issuer attributes that match attributes in the
        /// CERT_RDN structure. If these values are set, the function compares attributes of the
        /// issuer in a certificate with elements of the CERT_RDN_ATTR array in this CERT_RDN structure.
        /// Comparisons iterate through the CERT_RDN_ATTR attributes looking for a match with the
        /// certificate's issuer attributes.
        /// If the pszObjId member of CERT_RDN_ATTR is NULL, the attribute object identifier is ignored.
        /// If the dwValueType member of CERT_RDN_ATTR is CERT_RDN_ANY_TYPE, the value type is ignored.
        /// If the pbData member of CERT_RDN_VALUE_BLOB is NULL, any value is a match.
        /// Currently only an exact, case-sensitive match is supported. For information about Unicode
        /// options, see Remarks. When these values are set, the search is restricted to certificates
        /// whose encoding type matches dwCertEncodingType.
        /// </summary>
        public const uint CERT_FIND_ISSUER_ATTR = CERT_COMPARE_ATTR << CERT_COMPARE_SHIFT | CERT_INFO_ISSUER_FLAG;
        /// <summary>
        /// Data type of pvFindPara: CERT_NAME_BLOB structure.
        /// Search for a certificate with an exact match of the entire issuer name with the name
        /// in CERT_NAME_BLOB The search is restricted to certificates that match the
        /// dwCertEncodingType.
        /// </summary>
        public const uint CERT_FIND_ISSUER_NAME = CERT_COMPARE_NAME << CERT_COMPARE_SHIFT | CERT_INFO_ISSUER_FLAG;
        /// <summary>
        /// Data type of pvFindPara: CERT_CONTEXT structure.
        /// Searches for a certificate with an subject that matches the issuer in CERT_CONTEXT.
        /// Instead of using CertFindCertificateInStore with this value, use the
        /// CertGetCertificateChain function.
        /// </summary>
        public const uint CERT_FIND_ISSUER_OF = CERT_COMPARE_ISSUER_OF << CERT_COMPARE_SHIFT;
        /// <summary>
        /// Data type of pvFindPara: Null-terminated Unicode string.
        /// Searches for a certificate that contains the specified issuer name string. The
        /// certificate's issuer member is converted to a name string of the appropriate
        /// type using the appropriate form of CertNameToStr formatted as CERT_SIMPLE_NAME_STR.
        /// Then a case-insensitive substring-within-a-string match is performed. When this
        /// value is set, the search is restricted to certificates whose encoding type
        /// matches dwCertEncodingType.
        /// If the substring match fails and the subject contains an email RDN with Punycode
        /// encoded string, CERT_NAME_STR_ENABLE_PUNYCODE_FLAG is used to convert the subject
        /// to a Unicode string and the substring match is performed again.
        /// </summary>
        public const uint CERT_FIND_ISSUER_STR = CERT_FIND_ISSUER_STR_W;
        /// <summary>
        /// Data type of pvFindPara: CRYPT_HASH_BLOB structure.
        /// Searches for a certificate with a CERT_KEY_IDENTIFIER_PROP_ID property that
        /// matches the key identifier in CRYPT_HASH_BLOB.
        /// </summary>
        public const uint CERT_FIND_KEY_IDENTIFIER = CERT_COMPARE_KEY_IDENTIFIER << CERT_COMPARE_SHIFT;
        /// <summary>
        /// Data type of pvFindPara: DWORD variable that contains a key specification.
        /// Searches for a certificate that has a CERT_KEY_SPEC_PROP_ID property that matches the
        /// key specification in pvFindPara.
        /// </summary>
        public const uint CERT_FIND_KEY_SPEC = CERT_COMPARE_KEY_SPEC << CERT_COMPARE_SHIFT;
        /// <summary>
        /// Data type of pvFindPara: CRYPT_HASH_BLOB structure.
        /// Searches for a certificate with an MD5 hash that matches the hash in CRYPT_HASH_BLOB.
        /// </summary>
        public const uint CERT_FIND_MD5_HASH = CERT_COMPARE_MD5_HASH << CERT_COMPARE_SHIFT;
        /// <summary>
        /// Data type of pvFindPara: DWORD variable that contains a property identifier.
        /// Searches for a certificate with a property that matches the property identifier specified by
        /// the DWORD value in pvFindPara.
        /// </summary>
        public const uint CERT_FIND_PROPERTY = CERT_COMPARE_PROPERTY << CERT_COMPARE_SHIFT;
        /// <summary>
        /// Data type of pvFindPara: CERT_PUBLIC_KEY_INFO structure.
        /// Searches for a certificate with a public key that matches the public key in
        /// the CERT_PUBLIC_KEY_INFO structure.
        /// </summary>
        public const uint CERT_FIND_PUBLIC_KEY = CERT_COMPARE_PUBLIC_KEY << CERT_COMPARE_SHIFT;
        /// <summary>
        /// Data type of pvFindPara: CRYPT_HASH_BLOB structure.
        /// Searches for a certificate with a SHA1 hash that matches the hash in the
        /// CRYPT_HASH_BLOB structure.
        /// </summary>
        public const uint CERT_FIND_SHA1_HASH = CERT_COMPARE_SHA1_HASH << CERT_COMPARE_SHIFT;
        /// <summary>
        /// Data type of pvFindPara: CRYPT_HASH_BLOB structure.
        /// Searches for a certificate with a signature hash that matches the signature hash
        /// in the CRYPT_HASH_BLOB structure.
        /// </summary>
        public const uint CERT_FIND_SIGNATURE_HASH = CERT_COMPARE_SIGNATURE_HASH << CERT_COMPARE_SHIFT;
        /// <summary>
        /// Data type of pvFindPara: CERT_RDN structure.
        /// Searches for a certificate with specified subject attributes that match attributes in
        /// the CERT_RDN structure. If RDN values are set, the function compares attributes of
        /// the subject in a certificate with elements of the CERT_RDN_ATTR array in this CERT_RDN
        /// structure. Comparisons iterate through the CERT_RDN_ATTR attributes looking for a
        /// match with the certificate's subject's attributes.
        /// If the pszObjId member of CERT_RDN_ATTR is NULL, the attribute object identifier is ignored.
        /// If the dwValueType member of CERT_RDN_ATTR is CERT_RDN_ANY_TYPE, the value type is ignored.
        /// If the pbData member of CERT_RDN_VALUE_BLOB is NULL, any value is a match.
        /// Currently only an exact, case-sensitive match is supported.
        /// For information about Unicode options, see Remarks. When these values are set, the search
        /// is restricted to certificates whose encoding type matches dwCertEncodingType.
        /// </summary>
        public const uint CERT_FIND_SUBJECT_ATTR = CERT_COMPARE_ATTR << CERT_COMPARE_SHIFT | CERT_INFO_SUBJECT_FLAG;
        /// <summary>
        /// Data type of pvFindPara: CERT_INFO structure.
        /// Searches for a certificate with both an issuer and a serial number that match the
        /// issuer and serial number in the CERT_INFO structure.
        /// </summary>
        public const uint CERT_FIND_SUBJECT_CERT = CERT_COMPARE_SUBJECT_CERT << CERT_COMPARE_SHIFT;
        /// <summary>
        /// Data type of pvFindPara: CERT_NAME_BLOB structure.
        /// Searches for a certificate with an exact match of the entire subject name with the
        /// name in the CERT_NAME_BLOB structure. The search is restricted to certificates that
        /// match the value of dwCertEncodingType.
        /// </summary>
        public const uint CERT_FIND_SUBJECT_NAME = CERT_COMPARE_NAME << CERT_COMPARE_SHIFT | CERT_INFO_SUBJECT_FLAG;
        /// <summary>
        /// Data type of pvFindPara: Null-terminated Unicode string.
        /// Searches for a certificate that contains the specified subject name string. The
        /// certificate's subject member is converted to a name string of the appropriate
        /// type using the appropriate form of CertNameToStr formatted as CERT_SIMPLE_NAME_STR.
        /// Then a case-insensitive substring-within-a-string match is performed. When this
        /// value is set, the search is restricted to certificates whose encoding type matches
        /// dwCertEncodingType.
        /// </summary>
        public const uint CERT_FIND_SUBJECT_STR = CERT_FIND_SUBJECT_STR_W;
        /// <summary>
        /// Data type of pvFindPara: Not used.
        /// Find a certificate that has either a cross certificate distribution point extension or property.
        /// </summary>
        public const uint CERT_FIND_CROSS_CERT_DIST_POINTS = (CERT_COMPARE_CROSS_CERT_DIST_POINTS << CERT_COMPARE_SHIFT);
        /// <summary>
        /// Data type of pvFindPara: CRYPT_HASH_BLOB structure.
        /// Find a certificate whose MD5-hashed public key matches the specified hash.
        /// </summary>
        public const uint CERT_FIND_PUBKEY_MD5_HASH = (CERT_COMPARE_PUBKEY_MD5_HASH << CERT_COMPARE_SHIFT);
        public const int CERT_COMPARE_SHIFT = 16;
        public const int CERT_COMPARE_PUBKEY_MD5_HASH = 18;
        public const int CERT_COMPARE_CROSS_CERT_DIST_POINTS = 17;
        public const int CERT_FIND_SUBJECT_STR_W = CERT_COMPARE_NAME_STR_W << CERT_COMPARE_SHIFT | CERT_INFO_SUBJECT_FLAG;
        public const int CERT_COMPARE_NAME_STR_W = 8;
        public const int CERT_INFO_SUBJECT_FLAG = 7;
        public const int CERT_COMPARE_NAME = 2;
        public const int CERT_COMPARE_SUBJECT_CERT = 11;
        public const int CERT_COMPARE_ATTR = 3;
        public const int CERT_COMPARE_SIGNATURE_HASH = 14;
        public const int CERT_COMPARE_SHA1_HASH = 1;
        public const int CERT_COMPARE_PUBLIC_KEY = 6;
        public const int CERT_COMPARE_PROPERTY = 5;
        public const int CERT_COMPARE_MD5_HASH = 4;
        public const int CERT_COMPARE_KEY_SPEC = 9;
        public const int CERT_COMPARE_KEY_IDENTIFIER = 15;
        public const int CERT_FIND_ISSUER_STR_W = CERT_COMPARE_NAME_STR_W << CERT_COMPARE_SHIFT | CERT_INFO_ISSUER_FLAG;
        public const int CERT_INFO_ISSUER_FLAG = 4;
        public const int CERT_COMPARE_ISSUER_OF = 12;
        public const int CERT_COMPARE_EXISTING = 13;
        public const int CERT_COMPARE_ENHKEY_USAGE = 10;
        public const int CERT_COMPARE_CERT_ID = 16;
        public const int CERT_COMPARE_ANY = 0;
        public const int CERT_COMPARE_HAS_PRIVATE_KEY = 21;

        /// <summary>
        /// Forces the freeing of memory for all contexts associated with the store. This
        /// flag can be safely used only when the store is opened in a function and neither
        /// the store handle nor any of its contexts are passed to any called functions.
        /// For details, see Remarks.
        /// </summary>
        public const int CERT_CLOSE_STORE_FORCE_FLAG = 0x00000001;
        /// <summary>
        /// Checks for nonfreed certificate, CRL, and CTL contexts. A returned error code
        /// indicates that one or more store elements is still in use. This flag should
        /// only be used as a diagnostic tool in the development of applications.
        /// </summary>
        public const int CERT_CLOSE_STORE_CHECK_FLAG = 0x00000002;

        /// <summary>
        /// If the certificate has a Subject Alternative Name extension or Issuer
        /// Alternative Name, uses the first rfc822Name choice. If no rfc822Name
        /// choice is found in the extension, uses the Subject Name field for the 
        /// Email OID. If either rfc822Name or the Email OID is found, uses the string.
        /// Otherwise, returns an empty string (returned character count is 1).
        /// pvTypePara is not used and is set to NULL.
        /// </summary>
        public const int CERT_NAME_EMAIL_TYPE = 1;
        /// <summary>
        /// Converts the Subject Name BLOB by calling CertNameToStr. pvTypePara points
        /// to a DWORD containing the dwStrType passed to CertNameToStr. If the Subject
        /// Name field is empty and the certificate has a Subject Alternative Name
        /// extension, uses the first directory Name choice from CertNameToStr.
        /// </summary>
        public const int CERT_NAME_RDN_TYPE = 2;
        /// <summary>
        /// pvTypePara points to an object identifier (OID) specifying the name attribute
        /// to be returned. For example, if pvTypePara is szOID_COMMON_NAME, uses the
        /// Subject Name member. If the Subject Name member is empty and the certificate
        /// has a Subject Alternative Name extension, uses the first directoryName choice.
        /// </summary>
        public const int CERT_NAME_ATTR_TYPE = 3;
        /// <summary>
        /// Iterates through the following list of name attributes and uses the Subject Name or the
        /// Subject Alternative Name extension for the first occurrence of:
        /// szOID_COMMON_NAME, szOID_ORGANIZATIONAL_UNIT_NAME, szOID_ORGANIZATION_NAME, or szOID_RSA_emailAddr.
        /// 
        /// If one of these attributes is not found, uses the Subject Alternative Name extension for
        /// a rfc822Name choice. If there is still no match, uses the first attribute.
        /// pvTypePara is not used and is set to NULL.
        /// </summary>
        public const int CERT_NAME_SIMPLE_DISPLAY_TYPE = 4;
        /// <summary>
        /// Checks the certificate for a CERT_FRIENDLY_NAME_PROP_ID property. If the
        /// certificate has this property, it is returned. If the certificate does not
        /// have the property, the CERT_NAME_SIMPLE_DISPLAY_TYPE is returned.
        /// </summary>
        public const int CERT_NAME_FRIENDLY_DISPLAY_TYPE = 5;
        /// <summary>
        /// If the certificate has a Subject Alternative Name extension for issuer,
        /// Issuer Alternative Name, search for first DNSName choice.
        /// If the DNSName choice is not found in the extension, search the Subject
        /// Name field for the CN OID, "2.5.4.3".
        /// If the DNSName or CN OID is found, return the string. Otherwise, return
        /// an empty string.
        /// </summary>
        public const int CERT_NAME_DNS_TYPE = 6;
        /// <summary>
        /// If the certificate has a Subject Alternative Name extension for issuer,
        /// Issuer Alternative Name, search for first URL choice. If the URL choice
        /// is found, return the string. Otherwise, return an empty string.
        /// </summary>
        public const int CERT_NAME_URL_TYPE = 7;
        /// <summary>
        /// If the certificate has a Subject Alternative Name extension, search the
        /// OtherName choices looking for a
        /// pszObjId == szOID_NT_PRINCIPAL_NAME, ("1.3.6.1.4.1.311.20.2.3").
        /// If the UPN OID is found, decode the BLOB as a X509_UNICODE_ANY_STRING and
        /// return the decoded string. Otherwise, return an empty string.
        /// </summary>
        public const int CERT_NAME_UPN_TYPE = 8;

        /// <summary>
        /// Acquires the issuer's name. If not set, acquires the subject's name.
        /// </summary>
        public const int CERT_NAME_ISSUER_FLAG = 1;
        /// <summary>
        /// Skips the default initial attempt to decode the value as UTF8 and decodes
        /// as 8-bit characters.
        /// </summary>
        public const int CERT_NAME_DISABLE_IE4_UTF8_FLAG = 0x00010000;
        /// <summary>
        /// If the dwType parameter is set to CERT_NAME_DNS_TYPE, all applicable
        /// names are returned for the specified DNS value. If there is no DNS name
        /// but there is a CN component in the subject, the CN is returned instead.
        /// If there is a CN and a DNS name, only the DNS names are returned. This
        /// mimics the SSL chain building policy. If you set this flag for a name
        /// type other than CERT_NAME_DNS_TYPE, this function returns a
        /// null-terminated empty string.
        /// Windows 8 and Windows Server 2012:  Support for this flag begins.
        /// </summary>
        public const int CERT_NAME_SEARCH_ALL_NAMES_FLAG = 2;
        /// <summary>
        /// This flag enables decoding of IA5String strings to Unicode string values
        /// based on the dwType parameter value.
        /// Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP:
        /// This value is not supported.
        /// </summary>
        public const int CERT_NAME_STR_ENABLE_PUNYCODE_FLAG = 0x00200000;

        /// <summary>
        /// This flag can be set to indicate that "no copy" optimization is enabled. This
        /// optimization, where applicable, updates the pvStructInfo parameter to point to
        /// content residing within pbEncoded instead of making a copy of the content and
        /// appending it to pvStructInfo. For applicable cases, less memory needs to be
        /// allocated by the calling application and execution is faster because a copy is
        /// not being made. Note that the trade-off when performing a "no copy" decoding is
        /// that pbEncoded cannot be freed until pvStructInfo is freed.
        /// </summary>
        public const int CRYPT_DECODE_NOCOPY_FLAG = 0x1;
        /// <summary>
        /// This flag is applicable when decoding X509_UNICODE_NAME, X509_UNICODE_NAME_VALUE,
        /// or X509_UNICODE_ANY_STRING. By default, CERT_RDN_T61_STRING encoded values are
        /// initially decoded as UTF8. If the UTF8 decoding fails, then the value is decoded
        /// as eight-bit characters. If this flag is set, it skips the initial attempt to
        /// decode the value as UTF8 and decodes the value as eight-bit characters.
        /// </summary>
        public const int CRYPT_UNICODE_NAME_DECODE_DISABLE_IE4_UTF8_FLAG = CERT_RDN_DISABLE_IE4_UTF8_FLAG;
        /// <summary>
        /// By default, the contents of the buffer pointed to by pbEncoded included the
        /// signed content and the signature. If this flag is set, the buffer includes
        /// only the "to be signed" content. This flag is applicable to X509_CERT_TO_BE_SIGNED,
        /// X509_CERT_CRL_TO_BE_SIGNED, X509_CRT_REQUEST_TO_BE_SIGNED, and X509_KEYGEN_REQUEST_TO_BE_SIGNED objects.
        /// </summary>
        public const int CRYPT_DECODE_TO_BE_SIGNED_FLAG = 0x2;
        /// <summary>
        /// When this flag is set, the OID stings are allocated in Crypt32.dll and
        /// shared instead of being copied into the returned data structure. This
        /// flag can be set if Crypt32.dll is not unloaded before the caller is unloaded.
        /// </summary>
        public const int CRYPT_DECODE_SHARE_OID_STRING_FLAG = 0x4;
        /// <summary>
        /// By default, the signature bytes are reversed. If this flag is set, this
        /// byte reversal is inhibited.
        /// </summary>
        public const int CRYPT_DECODE_NO_SIGNATURE_BYTE_REVERSAL_FLAG = 0x8;
        public const int CERT_RDN_DISABLE_IE4_UTF8_FLAG = 0x01000000;

        /// <summary>
        /// An error was encountered while decoding.
        /// </summary>
        public const int CRYPT_E_BAD_ENCODE = 0x80092002;
        /// <summary>
        /// A decoding function could not be found for the specified dwCertEncodingType
        /// and lpszStructType
        /// </summary>
        public const int ERROR_FILE_NOT_FOUND = 2;
    }
}