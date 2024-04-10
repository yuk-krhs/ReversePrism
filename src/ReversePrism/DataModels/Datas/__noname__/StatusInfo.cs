using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   00018655C8C0 ModelEnumType Status Status Status Int32
    // 014 Error                                    00018655BC20 ModelEnumType Error Error Error Int32
    // 018 HttpStatusCode                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 ContentsSize                             0001865F7E40 ModelPrimitiveType long long long Int64
    // 028 ReceivedSize                             0001865F7E40 ModelPrimitiveType long long long Int64
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

            value.Status                                    = (Status)GetInt32(new IntPtr(p + 0x010)); // 02466AD25498 0x10 Status                      ( 00018655C8C0 ModelEnumType Status Status Status Int32 )
            value.Error                                     = (Error)GetInt32(new IntPtr(p + 0x014)); // 02466AD254B8 0x14 Error                       ( 00018655BC20 ModelEnumType Error Error Error Int32 )
            value.HttpStatusCode                            = GetInt32(new IntPtr(p + 0x018)); // 02466AD254D8 0x18 HttpStatusCode              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ContentsSize                              = GetInt64(new IntPtr(p + 0x020)); // 02466AD254F8 0x20 ContentsSize                ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.ReceivedSize                              = GetInt64(new IntPtr(p + 0x028)); // 02466AD25518 0x28 ReceivedSize                ( 0001865F7E40 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
