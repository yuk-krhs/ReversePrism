using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Domain                                   ModelPrimitiveType string string string String
    // 018 Reason                                   ModelPrimitiveType string string string String
    // 020 Message                                  ModelPrimitiveType string string string String
    // 028 GwCode                                   ModelPrimitiveType string string string String
    // 030 GwMessage                                ModelPrimitiveType string string string String
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

            value.Domain                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Domain                      ( ModelPrimitiveType string string string String )
            value.Reason                                    = GetString(new IntPtr(p + 0x018)); // 0x18 Reason                      ( ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x020)); // 0x20 Message                     ( ModelPrimitiveType string string string String )
            value.GwCode                                    = GetString(new IntPtr(p + 0x028)); // 0x28 GwCode                      ( ModelPrimitiveType string string string String )
            value.GwMessage                                 = GetString(new IntPtr(p + 0x030)); // 0x30 GwMessage                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
