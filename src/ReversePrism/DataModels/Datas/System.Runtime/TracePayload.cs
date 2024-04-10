using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SerializedException                      000186671910 ModelPrimitiveType string string string String
    // 018 EventSource                              000186671910 ModelPrimitiveType string string string String
    // 020 AppDomainFriendlyName                    000186671910 ModelPrimitiveType string string string String
    // 028 ExtendedData                             000186671910 ModelPrimitiveType string string string String
    // 030 HostReference                            000186671910 ModelPrimitiveType string string string String
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

            value.SerializedException                       = GetString(new IntPtr(p + 0x010)); // 02466BAB3730 0x10 SerializedException         ( 000186671910 ModelPrimitiveType string string string String )
            value.EventSource                               = GetString(new IntPtr(p + 0x018)); // 02466BAB3750 0x18 EventSource                 ( 000186671910 ModelPrimitiveType string string string String )
            value.AppDomainFriendlyName                     = GetString(new IntPtr(p + 0x020)); // 02466BAB3770 0x20 AppDomainFriendlyName       ( 000186671910 ModelPrimitiveType string string string String )
            value.ExtendedData                              = GetString(new IntPtr(p + 0x028)); // 02466BAB3790 0x28 ExtendedData                ( 000186671910 ModelPrimitiveType string string string String )
            value.HostReference                             = GetString(new IntPtr(p + 0x030)); // 02466BAB37B0 0x30 HostReference               ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
