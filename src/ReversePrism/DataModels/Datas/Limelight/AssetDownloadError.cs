using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reason                                   0001866BED70 ModelEnumType ErrorReason ErrorReason ErrorReason Int32
    // 014 ErrorCode                                0001865F4940 ModelPrimitiveType int int int Int32
    // 018 Exception                                0001865CB410 ModelClassType Exception Exception Exception Pointer
    public partial class AssetDownloadError : DataModel
    {
        public ErrorReason                              Reason                                  { get; set; }
        public int                                      ErrorCode                               { get; set; }
        public Exception?                               Exception                               { get; set; }

        public static AssetDownloadError? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetDownloadError() { Pointer= p0 };

            value.Reason                                    = (ErrorReason)GetInt32(new IntPtr(p + 0x010)); // 0245A3E672E0 0x10 Reason                      ( 0001866BED70 ModelEnumType ErrorReason ErrorReason ErrorReason Int32 )
            value.ErrorCode                                 = GetInt32(new IntPtr(p + 0x014)); // 0245A3E67300 0x14 ErrorCode                   ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Exception                                 = GetObject<Exception>(new IntPtr(p + 0x018), ReversePrism.DataModels.Exception.FromPointer); // 0245A3E67320 0x18 Exception                   ( 0001865CB410 ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
