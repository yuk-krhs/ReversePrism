using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 State                                    00018652CC00 ModelEnumType SonicboomDownloadState SonicboomDownloadState SonicboomDownloadState Int32
    // 014 ErrorFlag                                00018652C4A0 ModelEnumType SonicboomDownloadErrorFlag SonicboomDownloadErrorFlag SonicboomDownloadErrorFlag Int32
    // 018 ErrorCode                                0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 DownloadedBytes                          00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class NativeDownloadProgress : DataModel
    {
        public SonicboomDownloadState                   State                                   { get; set; }
        public SonicboomDownloadErrorFlag               ErrorFlag                               { get; set; }
        public int                                      ErrorCode                               { get; set; }
        public ulong                                    DownloadedBytes                         { get; set; }

        public static NativeDownloadProgress? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeDownloadProgress() { Pointer= p0 };

            value.State                                     = (SonicboomDownloadState)GetInt32(new IntPtr(p + 0x010)); // 02466B5757A8 0x10 State                       ( 00018652CC00 ModelEnumType SonicboomDownloadState SonicboomDownloadState SonicboomDownloadState Int32 )
            value.ErrorFlag                                 = (SonicboomDownloadErrorFlag)GetInt32(new IntPtr(p + 0x014)); // 02466B5757C8 0x14 ErrorFlag                   ( 00018652C4A0 ModelEnumType SonicboomDownloadErrorFlag SonicboomDownloadErrorFlag SonicboomDownloadErrorFlag Int32 )
            value.ErrorCode                                 = GetInt32(new IntPtr(p + 0x018)); // 02466B5757E8 0x18 ErrorCode                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.DownloadedBytes                           = GetUInt64(new IntPtr(p + 0x020)); // 02466B575808 0x20 DownloadedBytes             ( 00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
