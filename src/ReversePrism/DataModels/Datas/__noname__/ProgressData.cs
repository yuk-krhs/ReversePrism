using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BytesSent                                0001865F79C0 ModelPrimitiveType long long long Int64
    // 018 TotalBytesToSend                         0001865F79C0 ModelPrimitiveType long long long Int64
    // 020 BytesReceived                            0001865F79C0 ModelPrimitiveType long long long Int64
    // 028 TotalBytesToReceive                      0001865F79C0 ModelPrimitiveType long long long Int64
    // 030 HasUploadPhase                           000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class ProgressData : DataModel
    {
        public long                                     BytesSent                               { get; set; }
        public long                                     TotalBytesToSend                        { get; set; }
        public long                                     BytesReceived                           { get; set; }
        public long                                     TotalBytesToReceive                     { get; set; }
        public bool                                     HasUploadPhase                          { get; set; }

        public static ProgressData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProgressData() { Pointer= p0 };

            value.BytesSent                                 = GetInt64(new IntPtr(p + 0x010)); // 024667A6E808 0x10 BytesSent                   ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.TotalBytesToSend                          = GetInt64(new IntPtr(p + 0x018)); // 024667A6E828 0x18 TotalBytesToSend            ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.BytesReceived                             = GetInt64(new IntPtr(p + 0x020)); // 024667A6E848 0x20 BytesReceived               ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.TotalBytesToReceive                       = GetInt64(new IntPtr(p + 0x028)); // 024667A6E868 0x28 TotalBytesToReceive         ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.HasUploadPhase                            = GetBool(new IntPtr(p + 0x030)); // 024667A6E888 0x30 HasUploadPhase              ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
