using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ActiveX5
{
    [Guid("CB5BDC81-93C1-11CF-8F20-00805F2CD064"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]

    public interface IObjectSafety
    {
        [PreserveSig]
        void GetInterfaceSafetyOptions(ref Guid riid,
                      [MarshalAs(UnmanagedType.U4)] ref int pdwSupportedOptions,
                      [MarshalAs(UnmanagedType.U4)] ref int pdwEnabledOptions);

        [PreserveSig()]
        void SetInterfaceSafetyOptions(ref Guid riid,
                      [MarshalAs(UnmanagedType.U4)] int dwOptionSetMask,
                      [MarshalAs(UnmanagedType.U4)] int dwEnabledOptions);
    }
}
