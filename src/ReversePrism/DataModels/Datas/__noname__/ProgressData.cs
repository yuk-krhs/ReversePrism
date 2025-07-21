using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BytesSent                                ModelPrimitiveType long long long Int64
    // 018 TotalBytesToSend                         ModelPrimitiveType long long long Int64
    // 020 BytesReceived                            ModelPrimitiveType long long long Int64
    // 028 TotalBytesToReceive                      ModelPrimitiveType long long long Int64
    // 030 HasUploadPhase                           ModelPrimitiveType bool bool bool Bool
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

            value.BytesSent                                 = GetInt64(new IntPtr(p + 0x010)); // 0x10 BytesSent                   ( ModelPrimitiveType long long long Int64 )
            value.TotalBytesToSend                          = GetInt64(new IntPtr(p + 0x018)); // 0x18 TotalBytesToSend            ( ModelPrimitiveType long long long Int64 )
            value.BytesReceived                             = GetInt64(new IntPtr(p + 0x020)); // 0x20 BytesReceived               ( ModelPrimitiveType long long long Int64 )
            value.TotalBytesToReceive                       = GetInt64(new IntPtr(p + 0x028)); // 0x28 TotalBytesToReceive         ( ModelPrimitiveType long long long Int64 )
            value.HasUploadPhase                            = GetBool(new IntPtr(p + 0x030)); // 0x30 HasUploadPhase              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
