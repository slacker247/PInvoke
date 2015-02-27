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
        static readonly uint ATTACH_PARENT_PROCESS = 0x0ffffffff;

        /// <summary>
        /// Messages you can send to combo boxes, either in an enum or defined as a series of static readonlyants
        /// </summary>
        public static readonly int CB_GETEDITSEL = 0x0140;
        public static readonly int CB_LIMITTEXT = 0x0141;
        public static readonly int CB_SETEDITSEL = 0x0142;
        public static readonly int CB_ADDSTRING = 0x0143;
        public static readonly int CB_DELETESTRING = 0x0144;
        public static readonly int CB_DIR = 0x0145;
        public static readonly int CB_GETCOUNT = 0x0146;
        public static readonly int CB_GETCURSEL = 0x0147;
        public static readonly int CB_GETLBTEXT = 0x0148;
        public static readonly int CB_GETLBTEXTLEN = 0x0149;
        public static readonly int CB_INSERTSTRING = 0x014A;
        public static readonly int CB_RESETCONTENT = 0x014B;
        public static readonly int CB_FINDSTRING = 0x014C;
        public static readonly int CB_SELECTSTRING = 0x014D;
        public static readonly int CB_SETCURSEL = 0x014E;
        public static readonly int CB_SHOWDROPDOWN = 0x014F;
        public static readonly int CB_GETITEMDATA = 0x0150;
        public static readonly int CB_SETITEMDATA = 0x0151;
        public static readonly int CB_GETDROPPEDCONTROLRECT = 0x0152;
        public static readonly int CB_SETITEMHEIGHT = 0x0153;
        public static readonly int CB_GETITEMHEIGHT = 0x0154;
        public static readonly int CB_SETEXTENDEDUI = 0x0155;
        public static readonly int CB_GETEXTENDEDUI = 0x0156;
        public static readonly int CB_GETDROPPEDSTATE = 0x0157;
        public static readonly int CB_FINDSTRINGEXACT = 0x0158;
        public static readonly int CB_SETLOCALE = 345;
        public static readonly int CB_GETLOCALE = 346;
        public static readonly int CB_GETTOPINDEX = 347;
        public static readonly int CB_SETTOPINDEX = 348;
        public static readonly int CB_GETHORIZONTALEXTENT = 349;
        public static readonly int CB_SETHORIZONTALEXTENT = 350;
        public static readonly int CB_GETDROPPEDWIDTH = 351;
        public static readonly int CB_SETDROPPEDWIDTH = 352;
        public static readonly int CB_INITSTORAGE = 353;
        public static readonly int CB_MSGMAX = 354;
        
        public static readonly uint CERT_REQUEST_V1 = 0;

        public static readonly Guid CLSID_TF_LangBarMgr = new Guid("EBB08C45-6C4A-4FDC-AE53-4EB8C4C7DB8E");

        public static readonly int COLOR_SCROLLBAR = 0;
        public static readonly int COLOR_BACKGROUND = 1;
        public static readonly int COLOR_DESKTOP = 1;
        public static readonly int COLOR_ACTIVECAPTION = 2;
        public static readonly int COLOR_INACTIVECAPTION = 3;
        public static readonly int COLOR_MENU = 4;
        public static readonly int COLOR_WINDOW = 5;
        public static readonly int COLOR_WINDOWFRAME = 6;
        public static readonly int COLOR_MENUTEXT = 7;
        public static readonly int COLOR_WINDOWTEXT = 8;
        public static readonly int COLOR_CAPTIONTEXT = 9;
        public static readonly int COLOR_ACTIVEBORDER = 10;
        public static readonly int COLOR_INACTIVEBORDER = 11;
        public static readonly int COLOR_APPWORKSPACE = 12;
        public static readonly int COLOR_HIGHLIGHT = 13;
        public static readonly int COLOR_HIGHLIGHTTEXT = 14;
        public static readonly int COLOR_BTNFACE = 15;
        public static readonly int COLOR_3DFACE = 15;
        public static readonly int COLOR_BTNSHADOW = 16;
        public static readonly int COLOR_3DSHADOW = 16;
        public static readonly int COLOR_GRAYTEXT = 17;
        public static readonly int COLOR_BTNTEXT = 18;
        public static readonly int COLOR_INACTIVECAPTIONTEXT = 19;
        public static readonly int COLOR_BTNHIGHLIGHT = 20;
        public static readonly int COLOR_3DHIGHLIGHT = 20;
        public static readonly int COLOR_3DHILIGHT = 20;
        public static readonly int COLOR_BTNHILIGHT = 20;
        public static readonly int COLOR_3DDKSHADOW = 21;
        public static readonly int COLOR_3DLIGHT = 22;
        public static readonly int COLOR_INFOTEXT = 23;
        public static readonly int COLOR_INFOBK = 24;

        public static  readonly int CRED_TYPE_GENERIC = 1;
        public static  readonly int CRED_TYPE_DOMAIN_PASSWORD = 2;
        public static  readonly int CRED_TYPE_DOMAIN_CERTIFICATE = 3;
        public static  readonly int CRED_TYPE_DOMAIN_VISIBLE_PASSWORD = 4;
        public static readonly int CRED_TYPE_MAXIMUM = 5; // Maximum supported cred type

        // Crypt32
        public static readonly int X509_ASN_ENCODING = 0x00000001;
        public static readonly int PKCS_7_ASN_ENCODING = 0x00010000;

        // for CertStrToName
        public static readonly int CERT_SIMPLE_NAME_STR = 1;
        public static readonly int CERT_OID_NAME_STR = 2;
        public static readonly int CERT_X500_NAME_STR = 3;

        static readonly int DACL_SECURITY_INFORMATION = 0x00000004;

        static readonly Int32 DRIVER_PACKAGE_REPAIR = 0x00000001;
        static readonly Int32 DRIVER_PACKAGE_SILENT = 0x00000002;
        static readonly Int32 DRIVER_PACKAGE_FORCE = 0x00000004;
        static readonly Int32 DRIVER_PACKAGE_ONLY_IF_DEVICE_PRESENT = 0x00000008;
        static readonly Int32 DRIVER_PACKAGE_LEGACY_MODE = 0x00000010;
        static readonly Int32 DRIVER_PACKAGE_DELETE_FILES = 0x00000020;

        /// <summary>
        /// Draws the icon or cursor using the mask.
        /// </summary>
        public static readonly int DI_MASK = 0x0001;

        /// <summary>
        /// Draws the icon or cursor using the image.
        /// </summary>
        public static readonly int DI_IMAGE = 0x0002;

        /// <summary>
        /// Combination of DI_IMAGE and DI_MASK.
        /// </summary>
        public static readonly int DI_NORMAL = 0x0003;

        /// <summary>
        /// Draws the icon or cursor using the system default image rather than the user-specified image.
        /// For more information, see About Cursors. Windows NT4.0 and later: This flag is ignored.
        /// </summary>
        public static readonly int DI_COMPAT = 0x0004;

        /// <summary>
        /// Draws the icon or cursor using the width and height specified by the system metric values for cursors or icons,
        /// if the cxWidth and cyWidth parameters are set to zero. If this flag is not specified and cxWidth and cyWidth are set to zero,
        /// the function uses the actual resource size.
        /// </summary>
        public static readonly int DI_DEFAULTSIZE = 0x0008;

        /// <summary>
        /// Windows XP: Draws the icon as an unmirrored icon. By default, the icon is drawn as a mirrored icon if hdc is mirrored.
        /// </summary>
        public static readonly int DI_NOMIRROR = 0x0010;

            // static readonlyants for Enhanced Metafile records
        public static readonly int EMR_HEADER = 1;
        public static readonly int EMR_POLYBEZIER = 2;
        public static readonly int EMR_POLYGON = 3;
        public static readonly int EMR_POLYLINE = 4;
        public static readonly int EMR_POLYBEZIERTO = 5;
        public static readonly int EMR_POLYLINETO = 6;
        public static readonly int EMR_POLYPOLYLINE = 7;
        public static readonly int EMR_POLYPOLYGON = 8;
        public static readonly int EMR_SETWINDOWEXTEX = 9;
        public static readonly int EMR_SETWINDOWORGEX= 10;
        public static readonly int EMR_SETVIEWPORTEXTEX = 11;
        public static readonly int EMR_SETVIEWPORTORGEX = 12;
        public static readonly int EMR_SETBRUSHORGEX = 13;
        public static readonly int EMR_EOF = 14;
        public static readonly int EMR_SETPIXELV = 15;
        public static readonly int EMR_SETMAPPERFLAGS = 16;
        public static readonly int EMR_SETMAPMODE = 17;
        public static readonly int EMR_SETBKMODE = 18;
        public static readonly int EMR_SETPOLYFILLMODE = 19;
        public static readonly int EMR_SETROP2 = 20;
        public static readonly int EMR_SETSTRETCHBLTMODE = 21;
        public static readonly int EMR_SETTEXTALIGN = 22;
        public static readonly int EMR_SETCOLORADJUSTMENT = 23;
        public static readonly int EMR_SETTEXTCOLOR = 24;
        public static readonly int EMR_SETBKCOLOR = 25;
        public static readonly int EMR_OFFSETCLIPRGN = 26;
        public static readonly int EMR_MOVETOEX = 27;
        public static readonly int EMR_SETMETARGN = 28;
        public static readonly int EMR_EXCLUDECLIPRECT = 29;
        public static readonly int EMR_INTERSECTCLIPRECT = 30;
        public static readonly int EMR_SCALEVIEWPORTEXTEX = 31;
        public static readonly int EMR_SCALEWINDOWEXTEX = 32;
        public static readonly int EMR_SAVEDC = 33;
        public static readonly int EMR_RESTOREDC = 34;
        public static readonly int EMR_SETWORLDTRANSFORM = 35;
        public static readonly int EMR_MODIFYWORLDTRANSFORM = 36;
        public static readonly int EMR_SELECTOBJECT = 37;
        public static readonly int EMR_CREATEPEN = 38;
        public static readonly int EMR_CREATEBRUSHINDIRECT = 39;
        public static readonly int EMR_DELETEOBJECT = 40;
        public static readonly int EMR_ANGLEARC = 41;
        public static readonly int EMR_ELLIPSE = 42;
        public static readonly int EMR_RECTANGLE = 43;
        public static readonly int EMR_ROUNDRECT = 44;
        public static readonly int EMR_ARC = 45;
        public static readonly int EMR_CHORD = 46;
        public static readonly int EMR_PIE = 47;
        public static readonly int EMR_SELECTPALETTE = 48;
        public static readonly int EMR_CREATEPALETTE = 49;
        public static readonly int EMR_SETPALETTEENTRIES = 50;
        public static readonly int EMR_RESIZEPALETTE = 51;
        public static readonly int EMR_REALIZEPALETTE = 52;
        public static readonly int EMR_EXTFLOODFILL = 53;
        public static readonly int EMR_LINETO = 54;
        public static readonly int EMR_ARCTO = 55;
        public static readonly int EMR_POLYDRAW = 56;
        public static readonly int EMR_SETARCDIRECTION = 57;
        public static readonly int EMR_SETMITERLIMIT = 58;
        public static readonly int EMR_BEGINPATH = 59;
        public static readonly int EMR_ENDPATH = 60;
        public static readonly int EMR_CLOSEFIGURE = 61;
        public static readonly int EMR_FILLPATH = 62;
        public static readonly int EMR_STROKEANDFILLPATH = 63;
        public static readonly int EMR_STROKEPATH = 64;
        public static readonly int EMR_FLATTENPATH = 65;
        public static readonly int EMR_WIDENPATH = 66;
        public static readonly int EMR_SELECTCLIPPATH = 67;
        public static readonly int EMR_ABORTPATH = 68;
        public static readonly int EMR_GDICOMMENT = 70;
        public static readonly int EMR_FILLRGN = 71;
        public static readonly int EMR_FRAMERGN = 72;
        public static readonly int EMR_INVERTRGN = 73;
        public static readonly int EMR_PAINTRGN = 74;
        public static readonly int EMR_EXTSELECTCLIPRGN = 75;
        public static readonly int EMR_BITBLT = 76;
        public static readonly int EMR_STRETCHBLT = 77;
        public static readonly int EMR_MASKBLT = 78;
        public static readonly int EMR_PLGBLT = 79;
        public static readonly int EMR_SETDIBITSTODEVICE = 80;
        public static readonly int EMR_STRETCHDIBITS = 81;
        public static readonly int EMR_EXTCREATEFONTINDIRECTW = 82;
        public static readonly int EMR_EXTTEXTOUTA = 83;
        public static readonly int EMR_EXTTEXTOUTW = 84;
        public static readonly int EMR_POLYBEZIER16 = 85;
        public static readonly int EMR_POLYGON16 = 86;
        public static readonly int EMR_POLYLINE16 = 87;
        public static readonly int EMR_POLYBEZIERTO16 = 88;
        public static readonly int EMR_POLYLINETO16 = 89;
        public static readonly int EMR_POLYPOLYLINE16 = 90;
        public static readonly int EMR_POLYPOLYGON16 = 91;
        public static readonly int EMR_POLYDRAW16 = 92;
        public static readonly int EMR_CREATEMONOBRUSH = 93;
        public static readonly int EMR_CREATEDIBPATTERNBRUSHPT = 94;
        public static readonly int EMR_EXTCREATEPEN = 95;
        public static readonly int EMR_POLYTEXTOUTA = 96;
        public static readonly int EMR_POLYTEXTOUTW = 97;
        public static readonly int EMR_SETICMMODE = 98;
        public static readonly int EMR_CREATECOLORSPACE = 99;
        public static readonly int EMR_SETCOLORSPACE = 100;
        public static readonly int EMR_DELETECOLORSPACE = 101;
        public static readonly int EMR_GLSRECORD = 102;
        public static readonly int EMR_GLSBOUNDEDRECORD = 103;
        public static readonly int EMR_PIXELFORMAT = 104;
        public static readonly int EMR_RESERVED_105 = 105;
        public static readonly int EMR_RESERVED_106 = 106;
        public static readonly int EMR_RESERVED_107 = 107;
        public static readonly int EMR_RESERVED_108 = 108;
        public static readonly int EMR_RESERVED_109 = 109;
        public static readonly int EMR_RESERVED_110 = 110;
        public static readonly int EMR_COLORCORRECTPALETTE = 111;
        public static readonly int EMR_SETICMPROFILEA = 112;
        public static readonly int EMR_SETICMPROFILEW = 113;
        public static readonly int EMR_ALPHABLEND = 114;
        public static readonly int EMR_SETLAYOUT = 115;
        public static readonly int EMR_TRANSPARENTBLT = 116;
        public static readonly int EMR_RESERVED_117 = 117;
        public static readonly int EMR_GRADIENTFILL = 118;
        public static readonly int EMR_RESERVED_119 = 119;
        public static readonly int EMR_RESERVED_120 = 120;
        public static readonly int EMR_COLORMATCHTOTARGETW = 121;
        public static readonly int EMR_CREATECOLORSPACEW = 122;

        public static readonly uint EM_EXGETSEL = WM_USER + 52;
        public static readonly uint EM_EXSETSEL = WM_USER + 55;
        public static readonly uint EM_GETCHARFORMAT = WM_USER + 58;
        public static readonly uint EM_GETOPTIONS = WM_USER + 78;
        public static readonly uint EM_GETSCROLLPOS = WM_USER + 221;
        public static readonly uint EM_GETSEL = 0x00B0;
        public static readonly uint EM_GETTEXTEX = WM_USER + 94;
        public static readonly uint EM_GETTEXTLENGTHEX = WM_USER + 95;
        public static readonly uint EM_SETCHARFORMAT = WM_USER + 68;
        public static readonly uint EM_SETOPTIONS = WM_USER + 77;
        public static readonly uint EM_SETSCROLLPOS = WM_USER + 222;
        public static readonly uint EM_SETSEL = 0x00B1;
        public static readonly uint EM_SETTEXTEX = WM_USER + 97;
        public static readonly uint EM_SHOWSCROLLBAR = WM_USER + 96;

        /// <summary>
        /// Access Denied, in context of AttachConsole, it means that the
        /// console is attached elsewhere. It may have other meaning to
        /// other API functions.
        /// </summary>
        public static readonly int ERROR_ACCESS_DENIED = 5;

        public static readonly UInt32 EWX_LOGOFF          = 0x00000000;
        public static readonly UInt32 EWX_SHUTDOWN        = 0x00000001;
        public static readonly UInt32 EWX_FORCE           = 0x00000004;
        public static readonly UInt32 EWX_POWEROFF        = 0x00000008;
        public static readonly UInt32 EWX_FORCEIFHUNG    = 0x00000010; // Supported on Windows 2000 and larger

        public static readonly int E_FAIL = unchecked((int) 0x80004005);

        public static readonly int E_NOINTERFACE = unchecked((int) 0x80004002);

        public static readonly int FILE_ATTRIBUTE_DIRECTORY = 0x10;
        public static readonly int FILE_ATTRIBUTE_NORMAL = 0x80;
        /// <summary>
        /// This static readonlyant indicates the offset of the beginning of a file.
        /// </summary>
        public static readonly int FILE_BEGIN = 0;
        /// <summary>
        /// This static readonlyant indicates the offset of the current position of a file pointer in a file.
        /// </summary>
        public static readonly int FILE_CURRENT = 1;
        /// <summary>
        /// This static readonlyant indicates the offset of the end of a file.
        /// </summary>
        public static readonly int FILE_END = 2;
        public static readonly int FILE_SHARE_DELETE = 4;
        public static readonly int FILE_SHARE_READ = 1;
        public static readonly int FILE_SHARE_WRITE = 2;

        /// <summary>
        /// Indicates access rights of executing.
        /// </summary>
        public static readonly uint GENERIC_EXECUTE = 0x10000000;
        /// <summary>
        /// Indicates access rights of reading.
        /// </summary>
        public static readonly uint GENERIC_READ = 0x80000000;
        /// <summary>
        /// Indicates access rights of writing.
        /// </summary>
        public static readonly uint GENERIC_WRITE = 0x40000000;

        /// <summary>
        /// static readonlyants used by the GradientFill function
        /// </summary>
        public static readonly uint GRADIENT_FILL_RECT_H = 0x00000000;
        public static readonly uint GRADIENT_FILL_RECT_V = 0x00000001;
        public static readonly uint GRADIENT_FILL_TRIANGLE = 0x00000002;
        public static readonly uint GRADIENT_FILL_OP_FLAG = 0x000000ff;

        public static Guid IID_IContextMenu  = new Guid( 0x000214E4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 );
        public static Guid IID_IContextMenu2 = new Guid( 0x000214F4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 );
        public static Guid IID_IContextMenu3 = new Guid( 0xbcfce0a0, 0xec17, 0x11d0, 0x8d, 0x10, 0x0, 0xa0, 0xc9, 0xf, 0x27, 0x19);

        /// <summary>
        /// Defines GUIDs for device classes used in Plug & Play.
        /// </summary>
        public static readonly Guid GUID_DEVCLASS_1394 = new Guid("{0x6bdd1fc1, 0x810f, 0x11d0, {0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f}}");
        public static readonly Guid GUID_DEVCLASS_1394DEBUG = new Guid("{0x66f250d6, 0x7801, 0x4a64, {0xb1, 0x39, 0xee, 0xa8, 0x0a, 0x45, 0x0b, 0x24}}");
        public static readonly Guid GUID_DEVCLASS_61883 = new Guid("{0x7ebefbc0, 0x3200, 0x11d2, {0xb4, 0xc2, 0x00, 0xa0, 0xc9, 0x69, 0x7d, 0x07}}");
        public static readonly Guid GUID_DEVCLASS_ADAPTER = new Guid("{0x4d36e964, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_APMSUPPORT = new Guid("{0xd45b1c18, 0xc8fa, 0x11d1, {0x9f, 0x77, 0x00, 0x00, 0xf8, 0x05, 0xf5, 0x30}}");
        public static readonly Guid GUID_DEVCLASS_AVC = new Guid("{0xc06ff265, 0xae09, 0x48f0, {0x81, 0x2c, 0x16, 0x75, 0x3d, 0x7c, 0xba, 0x83}}");
        public static readonly Guid GUID_DEVCLASS_BATTERY = new Guid("{0x72631e54, 0x78a4, 0x11d0, {0xbc, 0xf7, 0x00, 0xaa, 0x00, 0xb7, 0xb3, 0x2a}}");
        public static readonly Guid GUID_DEVCLASS_BIOMETRIC = new Guid("{0x53d29ef7, 0x377c, 0x4d14, {0x86, 0x4b, 0xeb, 0x3a, 0x85, 0x76, 0x93, 0x59}}");
        public static readonly Guid GUID_DEVCLASS_BLUETOOTH = new Guid("{0xe0cbf06c, 0xcd8b, 0x4647, {0xbb, 0x8a, 0x26, 0x3b, 0x43, 0xf0, 0xf9, 0x74}}");
        public static readonly Guid GUID_DEVCLASS_CDROM = new Guid("{0x4d36e965, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_COMPUTER = new Guid("{0x4d36e966, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_DECODER = new Guid("{0x6bdd1fc2, 0x810f, 0x11d0, {0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f}}");
        public static readonly Guid GUID_DEVCLASS_DISKDRIVE = new Guid("{0x4d36e967, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_DISPLAY = new Guid("{0x4d36e968, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_DOT4 = new Guid("{0x48721b56, 0x6795, 0x11d2, {0xb1, 0xa8, 0x00, 0x80, 0xc7, 0x2e, 0x74, 0xa2}}");
        public static readonly Guid GUID_DEVCLASS_DOT4PRINT = new Guid("{0x49ce6ac8, 0x6f86, 0x11d2, {0xb1, 0xe5, 0x00, 0x80, 0xc7, 0x2e, 0x74, 0xa2}}");
        public static readonly Guid GUID_DEVCLASS_ENUM1394 = new Guid("{0xc459df55, 0xdb08, 0x11d1, {0xb0, 0x09, 0x00, 0xa0, 0xc9, 0x08, 0x1f, 0xf6}}");
        public static readonly Guid GUID_DEVCLASS_FDC = new Guid("{0x4d36e969, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_FLOPPYDISK = new Guid("{0x4d36e980, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_GPS = new Guid("{0x6bdd1fc3, 0x810f, 0x11d0, {0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f}}");
        public static readonly Guid GUID_DEVCLASS_HDC = new Guid("{0x4d36e96a, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_HIDCLASS = new Guid("{0x745a17a0, 0x74d3, 0x11d0, {0xb6, 0xfe, 0x00, 0xa0, 0xc9, 0x0f, 0x57, 0xda}}");
        public static readonly Guid GUID_DEVCLASS_IMAGE = new Guid("{0x6bdd1fc6, 0x810f, 0x11d0, {0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f}}");
        public static readonly Guid GUID_DEVCLASS_INFINIBAND = new Guid("{0x30ef7132, 0xd858, 0x4a0c, {0xac, 0x24, 0xb9, 0x02, 0x8a, 0x5c, 0xca, 0x3f}}");
        public static readonly Guid GUID_DEVCLASS_INFRARED = new Guid("{0x6bdd1fc5, 0x810f, 0x11d0, {0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f}}");
        public static readonly Guid GUID_DEVCLASS_KEYBOARD = new Guid("{0x4d36e96b, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_LEGACYDRIVER = new Guid("{0x8ecc055d, 0x047f, 0x11d1, {0xa5, 0x37, 0x00, 0x00, 0xf8, 0x75, 0x3e, 0xd1}}");
        public static readonly Guid GUID_DEVCLASS_MEDIA = new Guid("{0x4d36e96c, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_MEDIUM_CHANGER = new Guid("{0xce5939ae, 0xebde, 0x11d0, {0xb1, 0x81, 0x00, 0x00, 0xf8, 0x75, 0x3e, 0xc4}}");
        public static readonly Guid GUID_DEVCLASS_MODEM = new Guid("{0x4d36e96d, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_MONITOR = new Guid("{0x4d36e96e, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_MOUSE = new Guid("{0x4d36e96f, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_MTD = new Guid("{0x4d36e970, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_MULTIFUNCTION = new Guid("{0x4d36e971, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_MULTIPORTSERIAL = new Guid("{0x50906cb8, 0xba12, 0x11d1, {0xbf, 0x5d, 0x00, 0x00, 0xf8, 0x05, 0xf5, 0x30}}");
        public static readonly Guid GUID_DEVCLASS_NET = new Guid("{0x4d36e972, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_NETCLIENT = new Guid("{0x4d36e973, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_NETSERVICE = new Guid("{0x4d36e974, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_NETTRANS = new Guid("{0x4d36e975, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_NODRIVER = new Guid("{0x4d36e976, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_PCMCIA = new Guid("{0x4d36e977, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_PNPPRINTERS = new Guid("{0x4658ee7e, 0xf050, 0x11d1, {0xb6, 0xbd, 0x00, 0xc0, 0x4f, 0xa3, 0x72, 0xa7}}");
        public static readonly Guid GUID_DEVCLASS_PORTS = new Guid("{0x4d36e978, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_PRINTER = new Guid("{0x4d36e979, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_PRINTERUPGRADE = new Guid("{0x4d36e97a, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_PROCESSOR = new Guid("{0x50127dc3, 0x0f36, 0x415e, {0xa6, 0xcc, 0x4c, 0xb3, 0xbe, 0x91, 0x0B, 0x65}}");
        public static readonly Guid GUID_DEVCLASS_SBP2 = new Guid("{0xd48179be, 0xec20, 0x11d1, {0xb6, 0xb8, 0x00, 0xc0, 0x4f, 0xa3, 0x72, 0xa7}}");
        public static readonly Guid GUID_DEVCLASS_SCSIADAPTER = new Guid("{0x4d36e97b, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_SECURITYACCELERATOR = new Guid("{0x268c95a1, 0xedfe, 0x11d3, {0x95, 0xc3, 0x00, 0x10, 0xdc, 0x40, 0x50, 0xa5}}");
        public static readonly Guid GUID_DEVCLASS_SMARTCARDREADER = new Guid("{0x50dd5230, 0xba8a, 0x11d1, {0xbf, 0x5d, 0x00, 0x00, 0xf8, 0x05, 0xf5, 0x30}}");
        public static readonly Guid GUID_DEVCLASS_SOUND = new Guid("{0x4d36e97c, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_SYSTEM = new Guid("{0x4d36e97d, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_TAPEDRIVE = new Guid("{0x6d807884, 0x7d21, 0x11cf, {0x80, 0x1c, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_UNKNOWN = new Guid("{0x4d36e97e, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");
        public static readonly Guid GUID_DEVCLASS_USB = new Guid("{0x36fc9e60, 0xc465, 0x11cf, {0x80, 0x56, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00}}");
        public static readonly Guid GUID_DEVCLASS_VOLUME = new Guid("{0x71a27cdd, 0x812a, 0x11d0, {0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f}}");
        public static readonly Guid GUID_DEVCLASS_VOLUMESNAPSHOT = new Guid("{0x533c5b84, 0xec70, 0x11d2, {0x95, 0x05, 0x00, 0xc0, 0x4f, 0x79, 0xde, 0xaf}}");
        public static readonly Guid GUID_DEVCLASS_WCEUSBS = new Guid("{0x25dbce51, 0x6c8f, 0x4a72, {0x8a, 0x6d, 0xb5, 0x4c, 0x2b, 0x4f, 0xc8, 0x35}}");
        public static readonly Guid GUID_DEVCLASS_FSFILTER_ACTIVITYMONITOR = new Guid("{0xb86dff51, 0xa31e, 0x4bac, {0xb3, 0xcf, 0xe8, 0xcf, 0xe7, 0x5c, 0x9f, 0xc2}}");
        public static readonly Guid GUID_DEVCLASS_FSFILTER_UNDELETE = new Guid("{0xfe8f1572, 0xc67a, 0x48c0, {0xbb, 0xac, 0x0b, 0x5c, 0x6d, 0x66, 0xca, 0xfb}}");
        public static readonly Guid GUID_DEVCLASS_FSFILTER_ANTIVIRUS = new Guid("{0xb1d1a169, 0xc54f, 0x4379, {0x81, 0xdb, 0xbe, 0xe7, 0xd8, 0x8d, 0x74, 0x54}}");
        public static readonly Guid GUID_DEVCLASS_FSFILTER_REPLICATION = new Guid("{0x48d3ebc4, 0x4cf8, 0x48ff, {0xb8, 0x69, 0x9c, 0x68, 0xad, 0x42, 0xeb, 0x9f}}");
        public static readonly Guid GUID_DEVCLASS_FSFILTER_CONTINUOUSBACKUP = new Guid("{0x71aa14f8, 0x6fad, 0x4622, {0xad, 0x77, 0x92, 0xbb, 0x9d, 0x7e, 0x69, 0x47}}");
        public static readonly Guid GUID_DEVCLASS_FSFILTER_CONTENTSCREENER = new Guid("{0x3e3f0674, 0xc83c, 0x4558, {0xbb, 0x26, 0x98, 0x20, 0xe1, 0xeb, 0xa5, 0xc5}}");
        public static readonly Guid GUID_DEVCLASS_FSFILTER_QUOTAMANAGEMENT = new Guid("{0x8503c911, 0xa6c7, 0x4919, {0x8f, 0x79, 0x50, 0x28, 0xf5, 0x86, 0x6b, 0x0c}}");
        public static readonly Guid GUID_DEVCLASS_FSFILTER_SYSTEMRECOVERY = new Guid("{0x2db15374, 0x706e, 0x4131, {0xa0, 0xc7, 0xd7, 0xc7, 0x8e, 0xb0, 0x28, 0x9a}}");
        public static readonly Guid GUID_DEVCLASS_FSFILTER_CFSMETADATASERVER = new Guid("{0xcdcf0939, 0xb75b, 0x4630, {0xbf, 0x76, 0x80, 0xf7, 0xba, 0x65, 0x58, 0x84}}");
        public static readonly Guid GUID_DEVCLASS_FSFILTER_HSM = new Guid("{0xd546500a, 0x2aeb, 0x45f6, {0x94, 0x82, 0xf4, 0xb1, 0x79, 0x9c, 0x31, 0x77}}");
        public static readonly Guid GUID_DEVCLASS_FSFILTER_COMPRESSION = new Guid("{0xf3586baf, 0xb5aa, 0x49b5, {0x8d, 0x6c, 0x05, 0x69, 0x28, 0x4c, 0x63, 0x9f}}");
        public static readonly Guid GUID_DEVCLASS_FSFILTER_ENCRYPTION = new Guid("{0xa0a701c0, 0xa511, 0x42ff, {0xaa, 0x6c, 0x06, 0xdc, 0x03, 0x95, 0x57, 0x6f}}");
        public static readonly Guid GUID_DEVCLASS_FSFILTER_PHYSICALQUOTAMANAGEMENT = new Guid("{0x6a0a8e78, 0xbba6, 0x4fc4, {0xa7, 0x09, 0x1e, 0x33, 0xcd, 0x09, 0xd6, 0x7e}}");
        public static readonly Guid GUID_DEVCLASS_FSFILTER_OPENFILEBACKUP = new Guid("{0xf8ecafa6, 0x66d1, 0x41a5, {0x89, 0x9b, 0x66, 0x58, 0x5d, 0x72, 0x16, 0xb7}}");
        public static readonly Guid GUID_DEVCLASS_FSFILTER_SECURITYENHANCER = new Guid("{0xd02bc3da, 0x0c8e, 0x4945, {0x9b, 0xd5, 0xf1, 0x88, 0x3c, 0x22, 0x6c, 0x8c}}");
        public static readonly Guid GUID_DEVCLASS_FSFILTER_COPYPROTECTION = new Guid("{0x89786ff1, 0x9c12, 0x402f, {0x9c, 0x9e, 0x17, 0x75, 0x3c, 0x7f, 0x43, 0x75}}");
        public static readonly Guid GUID_DEVCLASS_FSFILTER_SYSTEM = new Guid("{0x5d1b9aaa, 0x01e2, 0x46af, {0x84, 0x9f, 0x27, 0x2b, 0x3f, 0x32, 0x4c, 0x46}}");
        public static readonly Guid GUID_DEVCLASS_FSFILTER_INFRASTRUCTURE = new Guid("{0xe55fa6f9, 0x128c, 0x4d04, {0xab, 0xab, 0x63, 0x0c, 0x74, 0xb1, 0x45, 0x3a}}");

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
        public static readonly string GUID_DEVINTERFACE_HUBCONTROLLER = "3abf6f2d-71c4-462a-8a92-1e6861e6af27";

        /// <summary>
        /// Specifies the relationship between the specified window
        /// and the window whose handle is to be retrieved.
        /// </summary>
        public static readonly uint GW_HWNDFIRST = 0;
        public static readonly uint GW_HWNDLAST = 1;
        public static readonly uint GW_HWNDNEXT = 2;
        public static readonly uint GW_HWNDPREV = 3;
        public static readonly uint GW_OWNER = 4;
        public static readonly uint GW_CHILD = 5;
        public static readonly uint GW_ENABLEDPOPUP = 6;
        public static readonly uint GW_MAX = 6;
        //Windows version <= 0x0400
#if WIN_VER
        public static readonly uint GW_HWNDFIRST = 0;
        public static readonly uint GW_HWNDLAST = 1;
        public static readonly uint GW_HWNDNEXT = 2;
        public static readonly uint GW_HWNDPREV = 3;
        public static readonly uint GW_OWNER = 4;
        public static readonly uint GW_CHILD = 5;
        public static readonly uint GW_MAX = 5;
#endif

        public static readonly int GWL_WNDPROC =(-4);
        public static readonly int GWL_HINSTANCE =(-6);
        public static readonly int GWL_HWNDPARENT =(-8);
        public static readonly int GWL_STYLE =(-16);
        public static readonly int GWL_EXSTYLE =(-20);
        public static readonly int GWL_USERDATA =(-21);
        public static readonly int GWL_ID =(-12);

        public static readonly IntPtr HKEY_LOCAL_MACHINE = new IntPtr(-2147483646);

        /// <summary>
        /// Perform initialization for applications that use the HTTP
        /// configuration functions, HttpSetServiceConfiguration,
        /// HttpQueryServiceConfiguration and HttpDeleteServiceConfiguration.
        /// </summary>
        public static readonly uint HTTP_INITIALIZE_CONFIG = 0x00000002;

        /// <summary>
        /// Perform initialization for applications that use the HTTP API.
        /// </summary>
        public static readonly uint HTTP_INITIALIZE_SERVER = 0x00000001;

        /// <summary>
        /// HWND static readonlyants (from winuser.h)
        /// </summary>
        public static readonly IntPtr HWND_BROADCAST = new IntPtr(0xffff);
        public static readonly IntPtr HWND_TOP       = new IntPtr(0);
        public static readonly IntPtr HWND_BOTTOM    = new IntPtr(1);
        public static readonly IntPtr HWND_TOPMOST   = new IntPtr(-1);
        public static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);

        /// <summary>
        /// To create a message-only window, use the SetParent function
        /// to set the parent of a window to HWND_MESSAGE, or use
        /// HWND_MESSAGE as the parent in the CreateWindow or
        /// CreateWindowEx function.
        /// </summary>
        public static readonly IntPtr HWND_MESSAGE = new IntPtr(-3);

        /// IDANI_ - DrawAnimatedRects static readonlyants
        /// <summary>
        /// This static readonlyant is not implemented on any Windows platform!
        /// </summary>
        public static readonly Int32 IDANI_OPEN = 1;

        /// <summary>
        /// The window caption will animate from lprcFrom to lprcTo.
        /// </summary>
        public static readonly Int32 IDANI_CAPTION = 3;

        /// <summary>
        /// Defines some of the default system cursors.
        /// </summary>
        public static readonly int IDC_ARROW = 32512;
        public static readonly int IDC_IBEAM = 32513;
        public static readonly int IDC_WAIT = 32514;
        public static readonly int IDC_CROSS = 32515;
        public static readonly int IDC_UPARROW = 32516;
        public static readonly int IDC_SIZE = 32640;
        public static readonly int IDC_ICON = 32641;
        public static readonly int IDC_SIZENWSE = 32642;
        public static readonly int IDC_SIZENESW = 32643;
        public static readonly int IDC_SIZEWE = 32644;
        public static readonly int IDC_SIZENS = 32645;
        public static readonly int IDC_SIZEALL = 32646;
        public static readonly int IDC_NO = 32648;
        public static readonly int IDC_HAND = 32649;
        public static readonly int IDC_APPSTARTING = 32650;
        public static readonly int IDC_HELP = 32651;

        public static readonly Guid IID_IDispatch = new Guid("{00020400-0000-0000-C000-000000000046}");
        public static readonly Guid IID_IDispatchEx = new Guid("{a6ef9860-c720-11d0-9337-00a0c90dcaa9}");
        public static readonly Guid IID_IPersistPropertyBag = new Guid("{37D84F60-42CB-11CE-8135-00AA004BB851}");
        public static readonly Guid IID_IPersistStorage = new Guid("{0000010A-0000-0000-C000-000000000046}");
        public static readonly Guid IID_IPersistStream = new Guid("{00000109-0000-0000-C000-000000000046}");
        public static readonly Guid IID_ITfLangBarMgr = new Guid("87955690-e627-11d2-8ddb-00105a2799b5");
        public static readonly Guid IID_TopLevelBrowser = new Guid("4C96BE40-915C-11CF-99D3-00AA004AE837");
        public static readonly Guid IID_WebBrowserApp = new Guid("0002DF05-0000-0000-C000-000000000046");

        /// static readonlyants used by CopyImage and LoadImage.
        /// <summary>
        /// Loads a bitmap.
        /// </summary>
        public static readonly int IMAGE_BITMAP = 0;

        /// <summary>
        /// Loads an icon.
        /// </summary>
        public static readonly int IMAGE_ICON = 1;

        /// <summary>
        /// Loads a cursor.
        /// </summary>
        public static readonly int IMAGE_CURSOR = 2;

        /// <summary>
        /// Loads an enhanced metafile.
        /// </summary>
        public static readonly int IMAGE_ENHMETAFILE = 3;

        /// <summary>
        /// Specifies that the style of the INF file is unrecognized or nonexistent.
        /// </summary>
        public static readonly Int32 INF_STYLE_NONE = 0x00000000;

        /// <summary>
        /// A legacy INF file format.
        /// </summary>
        public static readonly Int32 INF_STYLE_OLDNT = 0x00000001;

        /// <summary>
        /// A Windows INF file format.
        /// </summary>
        public static readonly Int32 INF_STYLE_WIN4 = 0x00000002;

        public static readonly int INTERFACESAFE_FOR_UNTRUSTED_CALLER = 0x00000001;
        public static readonly int INTERFACESAFE_FOR_UNTRUSTED_DATA = 0x00000002;

        /// <summary>
        /// This is returned by GetFileAttributes if the function fails
        /// </summary>
        public static readonly Int64 INVALID_FILE_ATTRIBUTES = -1;
        public static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

        /// <summary>
        /// Used with DeviceIoControl and DRIVE_LAYOUT_INFORMATION_EX to
        /// retetrieve extended information for each entry in the partition tables for a disk.
        /// </summary>
        public static readonly uint IOCTL_DISK_GET_DRIVE_LAYOUT_EX = 0x00070050;

        public static readonly long WS_MINIMIZE = 0x20000000L;
        public static readonly long WS_VISIBLE = 0x10000000L;
        public static readonly long WS_EX_APPWINDOW = 0x00040000L;
        public static readonly long WS_EX_TOOLWINDOW = 0x00000080L;
        public static readonly short SWP_NOMOVE = 0X2;
        public static readonly short SWP_NOSIZE = 1;
        public static readonly short SWP_NOZORDER = 0X4;
        public static readonly int SWP_SHOWWINDOW = 0x0040;

        public static readonly UInt32 WM_ACTIVATE = 0x0006;
        public static readonly UInt32 WM_ACTIVATEAPP = 0x001C;
        public static readonly UInt32 WM_AFXFIRST = 0x0360;
        public static readonly UInt32 WM_AFXLAST = 0x037F;
        public static readonly UInt32 WM_APP = 0x8000;
        public static readonly UInt32 WM_ASKCBFORMATNAME = 0x030C;
        public static readonly UInt32 WM_CANCELJOURNAL = 0x004B;
        public static readonly UInt32 WM_CANCELMODE = 0x001F;
        public static readonly UInt32 WM_CAPTURECHANGED = 0x0215;
        public static readonly UInt32 WM_CHANGECBCHAIN = 0x030D;
        public static readonly UInt32 WM_CHANGEUISTATE = 0x0127;
        public static readonly UInt32 WM_CHAR = 0x0102;
        public static readonly UInt32 WM_CHARTOITEM = 0x002F;
        public static readonly UInt32 WM_CHILDACTIVATE = 0x0022;
        public static readonly UInt32 WM_CLEAR = 0x0303;
        public static readonly UInt32 WM_CLOSE = 0x0010;
        public static readonly UInt32 WM_COMMAND = 0x0111;
        public static readonly UInt32 WM_COMPACTING = 0x0041;
        public static readonly UInt32 WM_COMPAREITEM = 0x0039;
        public static readonly UInt32 WM_CONTEXTMENU = 0x007B;
        public static readonly UInt32 WM_COPY = 0x0301;
        public static readonly UInt32 WM_COPYDATA = 0x004A;
        public static readonly UInt32 WM_CREATE = 0x0001;
        public static readonly UInt32 WM_CTLCOLORBTN = 0x0135;
        public static readonly UInt32 WM_CTLCOLORDLG = 0x0136;
        public static readonly UInt32 WM_CTLCOLOREDIT = 0x0133;
        public static readonly UInt32 WM_CTLCOLORLISTBOX = 0x0134;
        public static readonly UInt32 WM_CTLCOLORMSGBOX = 0x0132;
        public static readonly UInt32 WM_CTLCOLORSCROLLBAR = 0x0137;
        public static readonly UInt32 WM_CTLCOLORSTATIC = 0x0138;
        public static readonly UInt32 WM_CUT = 0x0300;
        public static readonly UInt32 WM_DEADCHAR = 0x0103;
        public static readonly UInt32 WM_DELETEITEM = 0x002D;
        public static readonly UInt32 WM_DESTROY = 0x0002;
        public static readonly UInt32 WM_DESTROYCLIPBOARD = 0x0307;
        public static readonly UInt32 WM_DEVICECHANGE = 0x0219;
        public static readonly UInt32 WM_DEVMODECHANGE = 0x001B;
        public static readonly UInt32 WM_DISPLAYCHANGE = 0x007E;
        public static readonly UInt32 WM_DRAWCLIPBOARD = 0x0308;
        public static readonly UInt32 WM_DRAWITEM = 0x002B;
        public static readonly UInt32 WM_DROPFILES = 0x0233;
        public static readonly UInt32 WM_ENABLE = 0x000A;
        public static readonly UInt32 WM_ENDSESSION = 0x0016;
        public static readonly UInt32 WM_ENTERIDLE = 0x0121;
        public static readonly UInt32 WM_ENTERMENULOOP = 0x0211;
        public static readonly UInt32 WM_ENTERSIZEMOVE = 0x0231;
        public static readonly UInt32 WM_ERASEBKGND = 0x0014;
        public static readonly UInt32 WM_EXITMENULOOP = 0x0212;
        public static readonly UInt32 WM_EXITSIZEMOVE = 0x0232;
        public static readonly UInt32 WM_FONTCHANGE = 0x001D;
        public static readonly UInt32 WM_GETDLGCODE = 0x0087;
        public static readonly UInt32 WM_GETFONT = 0x0031;
        public static readonly UInt32 WM_GETHOTKEY = 0x0033;
        public static readonly UInt32 WM_GETICON = 0x007F;
        public static readonly UInt32 WM_GETMINMAXINFO = 0x0024;
        public static readonly UInt32 WM_GETOBJECT = 0x003D;
        public static readonly UInt32 WM_GETTEXT = 0x000D;
        public static readonly UInt32 WM_GETTEXTLENGTH = 0x000E;
        public static readonly UInt32 WM_HANDHELDFIRST = 0x0358;
        public static readonly UInt32 WM_HANDHELDLAST = 0x035F;
        public static readonly UInt32 WM_HELP = 0x0053;
        public static readonly UInt32 WM_HOTKEY = 0x0312;
        public static readonly UInt32 WM_HSCROLL = 0x0114;
        public static readonly UInt32 WM_HSCROLLCLIPBOARD = 0x030E;
        public static readonly UInt32 WM_ICONERASEBKGND = 0x0027;
        public static readonly UInt32 WM_IME_CHAR = 0x0286;
        public static readonly UInt32 WM_IME_COMPOSITION = 0x010F;
        public static readonly UInt32 WM_IME_COMPOSITIONFULL = 0x0284;
        public static readonly UInt32 WM_IME_CONTROL = 0x0283;
        public static readonly UInt32 WM_IME_ENDCOMPOSITION = 0x010E;
        public static readonly UInt32 WM_IME_KEYDOWN = 0x0290;
        public static readonly UInt32 WM_IME_KEYLAST = 0x010F;
        public static readonly UInt32 WM_IME_KEYUP = 0x0291;
        public static readonly UInt32 WM_IME_NOTIFY = 0x0282;
        public static readonly UInt32 WM_IME_REQUEST = 0x0288;
        public static readonly UInt32 WM_IME_SELECT = 0x0285;
        public static readonly UInt32 WM_IME_SETCONTEXT = 0x0281;
        public static readonly UInt32 WM_IME_STARTCOMPOSITION = 0x010D;
        public static readonly UInt32 WM_INITDIALOG = 0x0110;
        public static readonly UInt32 WM_INITMENU = 0x0116;
        public static readonly UInt32 WM_INITMENUPOPUP = 0x0117;
        public static readonly UInt32 WM_INPUTLANGCHANGE = 0x0051;
        public static readonly UInt32 WM_INPUTLANGCHANGEREQUEST = 0x0050;
        public static readonly UInt32 WM_KEYDOWN = 0x0100;
        public static readonly UInt32 WM_KEYFIRST = 0x0100;
        public static readonly UInt32 WM_KEYLAST = 0x0108;
        public static readonly UInt32 WM_KEYUP = 0x0101;
        public static readonly UInt32 WM_KILLFOCUS = 0x0008;
        public static readonly UInt32 WM_LBUTTONDBLCLK = 0x0203;
        public static readonly UInt32 WM_LBUTTONDOWN = 0x0201;
        public static readonly UInt32 WM_LBUTTONUP = 0x0202;
        public static readonly UInt32 WM_MBUTTONDBLCLK = 0x0209;
        public static readonly UInt32 WM_MBUTTONDOWN = 0x0207;
        public static readonly UInt32 WM_MBUTTONUP = 0x0208;
        public static readonly UInt32 WM_MDIACTIVATE = 0x0222;
        public static readonly UInt32 WM_MDICASCADE = 0x0227;
        public static readonly UInt32 WM_MDICREATE = 0x0220;
        public static readonly UInt32 WM_MDIDESTROY = 0x0221;
        public static readonly UInt32 WM_MDIGETACTIVE = 0x0229;
        public static readonly UInt32 WM_MDIICONARRANGE = 0x0228;
        public static readonly UInt32 WM_MDIMAXIMIZE = 0x0225;
        public static readonly UInt32 WM_MDINEXT = 0x0224;
        public static readonly UInt32 WM_MDIREFRESHMENU = 0x0234;
        public static readonly UInt32 WM_MDIRESTORE = 0x0223;
        public static readonly UInt32 WM_MDISETMENU = 0x0230;
        public static readonly UInt32 WM_MDITILE = 0x0226;
        public static readonly UInt32 WM_MEASUREITEM = 0x002C;
        public static readonly UInt32 WM_MENUCHAR = 0x0120;
        public static readonly UInt32 WM_MENUCOMMAND = 0x0126;
        public static readonly UInt32 WM_MENUDRAG = 0x0123;
        public static readonly UInt32 WM_MENUGETOBJECT = 0x0124;
        public static readonly UInt32 WM_MENURBUTTONUP = 0x0122;
        public static readonly UInt32 WM_MENUSELECT = 0x011F;
        public static readonly UInt32 WM_MOUSEACTIVATE = 0x0021;
        public static readonly UInt32 WM_MOUSEFIRST = 0x0200;
        public static readonly UInt32 WM_MOUSEHOVER = 0x02A1;
        public static readonly UInt32 WM_MOUSELAST = 0x020D;
        public static readonly UInt32 WM_MOUSELEAVE = 0x02A3;
        public static readonly UInt32 WM_MOUSEMOVE = 0x0200;
        public static readonly UInt32 WM_MOUSEWHEEL = 0x020A;
        public static readonly UInt32 WM_MOUSEHWHEEL = 0x020E;
        public static readonly UInt32 WM_MOVE = 0x0003;
        public static readonly UInt32 WM_MOVING = 0x0216;
        public static readonly UInt32 WM_NCACTIVATE = 0x0086;
        public static readonly UInt32 WM_NCCALCSIZE = 0x0083;
        public static readonly UInt32 WM_NCCREATE = 0x0081;
        public static readonly UInt32 WM_NCDESTROY = 0x0082;
        public static readonly UInt32 WM_NCHITTEST = 0x0084;
        public static readonly UInt32 WM_NCLBUTTONDBLCLK = 0x00A3;
        public static readonly UInt32 WM_NCLBUTTONDOWN = 0x00A1;
        public static readonly UInt32 WM_NCLBUTTONUP = 0x00A2;
        public static readonly UInt32 WM_NCMBUTTONDBLCLK = 0x00A9;
        public static readonly UInt32 WM_NCMBUTTONDOWN = 0x00A7;
        public static readonly UInt32 WM_NCMBUTTONUP = 0x00A8;
        public static readonly UInt32 WM_NCMOUSEHOVER = 0x02A0;
        public static readonly UInt32 WM_NCMOUSELEAVE = 0x02A2;
        public static readonly UInt32 WM_NCMOUSEMOVE = 0x00A0;
        public static readonly UInt32 WM_NCPAINT = 0x0085;
        public static readonly UInt32 WM_NCRBUTTONDBLCLK = 0x00A6;
        public static readonly UInt32 WM_NCRBUTTONDOWN = 0x00A4;
        public static readonly UInt32 WM_NCRBUTTONUP = 0x00A5;
        public static readonly UInt32 WM_NCXBUTTONDBLCLK = 0x00AD;
        public static readonly UInt32 WM_NCXBUTTONDOWN = 0x00AB;
        public static readonly UInt32 WM_NCXBUTTONUP = 0x00AC;
        public static readonly UInt32 WM_NCUAHDRAWCAPTION = 0x00AE;
        public static readonly UInt32 WM_NCUAHDRAWFRAME = 0x00AF;
        public static readonly UInt32 WM_NEXTDLGCTL = 0x0028;
        public static readonly UInt32 WM_NEXTMENU = 0x0213;
        public static readonly UInt32 WM_NOTIFY = 0x004E;
        public static readonly UInt32 WM_NOTIFYFORMAT = 0x0055;
        public static readonly UInt32 WM_NULL = 0x0000;
        public static readonly UInt32 WM_PAINT = 0x000F;
        public static readonly UInt32 WM_PAINTCLIPBOARD = 0x0309;
        public static readonly UInt32 WM_PAINTICON = 0x0026;
        public static readonly UInt32 WM_PALETTECHANGED = 0x0311;
        public static readonly UInt32 WM_PALETTEISCHANGING = 0x0310;
        public static readonly UInt32 WM_PARENTNOTIFY = 0x0210;
        public static readonly UInt32 WM_PASTE = 0x0302;
        public static readonly UInt32 WM_PENWINFIRST = 0x0380;
        public static readonly UInt32 WM_PENWINLAST = 0x038F;
        public static readonly UInt32 WM_POWER = 0x0048;
        public static readonly UInt32 WM_POWERBROADCAST = 0x0218;
        public static readonly UInt32 WM_PRINT = 0x0317;
        public static readonly UInt32 WM_PRINTCLIENT = 0x0318;
        public static readonly UInt32 WM_QUERYDRAGICON = 0x0037;
        public static readonly UInt32 WM_QUERYENDSESSION = 0x0011;
        public static readonly UInt32 WM_QUERYNEWPALETTE = 0x030F;
        public static readonly UInt32 WM_QUERYOPEN = 0x0013;
        public static readonly UInt32 WM_QUEUESYNC = 0x0023;
        public static readonly UInt32 WM_QUIT = 0x0012;
        public static readonly UInt32 WM_RBUTTONDBLCLK = 0x0206;
        public static readonly UInt32 WM_RBUTTONDOWN = 0x0204;
        public static readonly UInt32 WM_RBUTTONUP = 0x0205;
        public static readonly UInt32 WM_RENDERALLFORMATS = 0x0306;
        public static readonly UInt32 WM_RENDERFORMAT = 0x0305;
        public static readonly UInt32 WM_SETCURSOR = 0x0020;
        public static readonly UInt32 WM_SETFOCUS = 0x0007;
        public static readonly UInt32 WM_SETFONT = 0x0030;
        public static readonly UInt32 WM_SETHOTKEY = 0x0032;
        public static readonly UInt32 WM_SETICON = 0x0080;
        public static readonly UInt32 WM_SETREDRAW = 0x000B;
        public static readonly UInt32 WM_SETTEXT = 0x000C;
        public static readonly UInt32 WM_SETTINGCHANGE = 0x001A;
        public static readonly UInt32 WM_SHOWWINDOW = 0x0018;
        public static readonly UInt32 WM_SIZE = 0x0005;
        public static readonly UInt32 WM_SIZECLIPBOARD = 0x030B;
        public static readonly UInt32 WM_SIZING = 0x0214;
        public static readonly UInt32 WM_SPOOLERSTATUS = 0x002A;
        public static readonly UInt32 WM_STYLECHANGED = 0x007D;
        public static readonly UInt32 WM_STYLECHANGING = 0x007C;
        public static readonly UInt32 WM_SYNCPAINT = 0x0088;
        public static readonly UInt32 WM_SYSCHAR = 0x0106;
        public static readonly UInt32 WM_SYSCOLORCHANGE = 0x0015;
        public static readonly UInt32 WM_SYSCOMMAND = 0x0112;
        public static readonly UInt32 WM_SYSDEADCHAR = 0x0107;
        public static readonly UInt32 WM_SYSKEYDOWN = 0x0104;
        public static readonly UInt32 WM_SYSKEYUP = 0x0105;
        public static readonly UInt32 WM_TCARD = 0x0052;
        public static readonly UInt32 WM_TIMECHANGE = 0x001E;
        public static readonly UInt32 WM_TIMER = 0x0113;
        public static readonly UInt32 WM_UNDO = 0x0304;
        public static readonly UInt32 WM_UNINITMENUPOPUP = 0x0125;
        public static readonly UInt32 WM_USER = 0x0400;
        public static readonly UInt32 WM_USERCHANGED = 0x0054;
        public static readonly UInt32 WM_VKEYTOITEM = 0x002E;
        public static readonly UInt32 WM_VSCROLL = 0x0115;
        public static readonly UInt32 WM_VSCROLLCLIPBOARD = 0x030A;
        public static readonly UInt32 WM_WINDOWPOSCHANGED = 0x0047;
        public static readonly UInt32 WM_WINDOWPOSCHANGING = 0x0046;
        public static readonly UInt32 WM_WININICHANGE = 0x001A;
        public static readonly UInt32 WM_XBUTTONDBLCLK = 0x020D;
        public static readonly UInt32 WM_XBUTTONDOWN = 0x020B;
        public static readonly UInt32 WM_XBUTTONUP = 0x020C;

        public static readonly int LOGON32_LOGON_INTERACTIVE = 2;
        public static readonly int LOGON32_PROVIDER_DEFAULT = 0;
    }
}