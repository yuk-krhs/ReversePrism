using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Domain                                   000186671910 ModelPrimitiveType string string string String
    // 018 Reason                                   000186671910 ModelPrimitiveType string string string String
    // 020 Message                                  000186671910 ModelPrimitiveType string string string String
    // 028 GwCode                                   000186671910 ModelPrimitiveType string string string String
    // 030 GwMessage                                000186671910 ModelPrimitiveType string string string String
    public partial class ErrorDetail : DataModel
    {
        public string                                   Domain                                  { get; set; }
        public string                                   Reason                                  { get; set; }
        public string                                   Message                                 { get; set; }
        public string                                   GwCode                                  { get; set; }
        public string                                   GwMessage                               { get; set; }

        public static ErrorDetail? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ErrorDetail() { Pointer= p0 };

            value.Domain                                    = GetString(new IntPtr(p + 0x010)); // 02466B508930 0x10 Domain                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Reason                                    = GetString(new IntPtr(p + 0x018)); // 02466B508950 0x18 Reason                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x020)); // 02466B508970 0x20 Message                     ( 000186671910 ModelPrimitiveType string string string String )
            value.GwCode                                    = GetString(new IntPtr(p + 0x028)); // 02466B508990 0x28 GwCode                      ( 000186671910 ModelPrimitiveType string string string String )
            value.GwMessage                                 = GetString(new IntPtr(p + 0x030)); // 02466B5089B0 0x30 GwMessage                   ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
