using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 State                                    ModelEnumType SonicboomDownloadState SonicboomDownloadState SonicboomDownloadState Int32
    // 014 ErrorFlag                                ModelEnumType SonicboomDownloadErrorFlag SonicboomDownloadErrorFlag SonicboomDownloadErrorFlag Int32
    // 018 ErrorCode                                ModelPrimitiveType int int int Int32
    // 020 DownloadedBytes                          ModelPrimitiveType ulong ulong ulong UInt64
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

            value.State                                     = (SonicboomDownloadState)GetInt32(new IntPtr(p + 0x010)); // 0x10 State                       ( ModelEnumType SonicboomDownloadState SonicboomDownloadState SonicboomDownloadState Int32 )
            value.ErrorFlag                                 = (SonicboomDownloadErrorFlag)GetInt32(new IntPtr(p + 0x014)); // 0x14 ErrorFlag                   ( ModelEnumType SonicboomDownloadErrorFlag SonicboomDownloadErrorFlag SonicboomDownloadErrorFlag Int32 )
            value.ErrorCode                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 ErrorCode                   ( ModelPrimitiveType int int int Int32 )
            value.DownloadedBytes                           = GetUInt64(new IntPtr(p + 0x020)); // 0x20 DownloadedBytes             ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
