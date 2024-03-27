using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CueName                                  000186671910 ModelPrimitiveType string string string String
    // 018 Message                                  000186671910 ModelPrimitiveType string string string String
    public partial class TextWindowSequence
    {
        public string                                   CueName                                 { get; set; }
        public string                                   Message                                 { get; set; }

        public static TextWindowSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextWindowSequence();

            value.CueName                                   = GetString(new IntPtr(p + 0x010)); // 0270DBC117F8 0x10 CueName                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x018)); // 0270DBC11818 0x18 Message                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
