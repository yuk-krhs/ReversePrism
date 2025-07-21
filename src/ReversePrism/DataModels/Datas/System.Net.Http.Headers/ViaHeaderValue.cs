using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Comment                                  ModelPrimitiveType string string string String
    // 018 ProtocolName                             ModelPrimitiveType string string string String
    // 020 ProtocolVersion                          ModelPrimitiveType string string string String
    // 028 ReceivedBy                               ModelPrimitiveType string string string String
    public partial class ViaHeaderValue : DataModel
    {
        public string                                   Comment                                 { get; set; }
        public string                                   ProtocolName                            { get; set; }
        public string                                   ProtocolVersion                         { get; set; }
        public string                                   ReceivedBy                              { get; set; }

        public static ViaHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViaHeaderValue() { Pointer= p0 };

            value.Comment                                   = GetString(new IntPtr(p + 0x010)); // 0x10 Comment                     ( ModelPrimitiveType string string string String )
            value.ProtocolName                              = GetString(new IntPtr(p + 0x018)); // 0x18 ProtocolName                ( ModelPrimitiveType string string string String )
            value.ProtocolVersion                           = GetString(new IntPtr(p + 0x020)); // 0x20 ProtocolVersion             ( ModelPrimitiveType string string string String )
            value.ReceivedBy                                = GetString(new IntPtr(p + 0x028)); // 0x28 ReceivedBy                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
