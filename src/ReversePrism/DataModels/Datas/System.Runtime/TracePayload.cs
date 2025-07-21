using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SerializedException                      ModelPrimitiveType string string string String
    // 018 EventSource                              ModelPrimitiveType string string string String
    // 020 AppDomainFriendlyName                    ModelPrimitiveType string string string String
    // 028 ExtendedData                             ModelPrimitiveType string string string String
    // 030 HostReference                            ModelPrimitiveType string string string String
    public partial class TracePayload : DataModel
    {
        public string                                   SerializedException                     { get; set; }
        public string                                   EventSource                             { get; set; }
        public string                                   AppDomainFriendlyName                   { get; set; }
        public string                                   ExtendedData                            { get; set; }
        public string                                   HostReference                           { get; set; }

        public static TracePayload? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TracePayload() { Pointer= p0 };

            value.SerializedException                       = GetString(new IntPtr(p + 0x010)); // 0x10 SerializedException         ( ModelPrimitiveType string string string String )
            value.EventSource                               = GetString(new IntPtr(p + 0x018)); // 0x18 EventSource                 ( ModelPrimitiveType string string string String )
            value.AppDomainFriendlyName                     = GetString(new IntPtr(p + 0x020)); // 0x20 AppDomainFriendlyName       ( ModelPrimitiveType string string string String )
            value.ExtendedData                              = GetString(new IntPtr(p + 0x028)); // 0x28 ExtendedData                ( ModelPrimitiveType string string string String )
            value.HostReference                             = GetString(new IntPtr(p + 0x030)); // 0x30 HostReference               ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
