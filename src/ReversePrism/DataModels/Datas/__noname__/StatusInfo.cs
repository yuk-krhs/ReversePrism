using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   ModelEnumType Status Status Status Int32
    // 014 Error                                    ModelEnumType Error Error Error Int32
    // 018 HttpStatusCode                           ModelPrimitiveType int int int Int32
    // 020 ContentsSize                             ModelPrimitiveType long long long Int64
    // 028 ReceivedSize                             ModelPrimitiveType long long long Int64
    public partial class StatusInfo : DataModel
    {
        public Status                                   Status                                  { get; set; }
        public Error                                    Error                                   { get; set; }
        public int                                      HttpStatusCode                          { get; set; }
        public long                                     ContentsSize                            { get; set; }
        public long                                     ReceivedSize                            { get; set; }

        public static StatusInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StatusInfo() { Pointer= p0 };

            value.Status                                    = (Status)GetInt32(new IntPtr(p + 0x010)); // 0x10 Status                      ( ModelEnumType Status Status Status Int32 )
            value.Error                                     = (Error)GetInt32(new IntPtr(p + 0x014)); // 0x14 Error                       ( ModelEnumType Error Error Error Int32 )
            value.HttpStatusCode                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 HttpStatusCode              ( ModelPrimitiveType int int int Int32 )
            value.ContentsSize                              = GetInt64(new IntPtr(p + 0x020)); // 0x20 ContentsSize                ( ModelPrimitiveType long long long Int64 )
            value.ReceivedSize                              = GetInt64(new IntPtr(p + 0x028)); // 0x28 ReceivedSize                ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
