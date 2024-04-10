using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_StringOriginalCase                     000186672F10 ModelPrimitiveType string string string String
    // 018 M_StringLowerCase                        000186672F10 ModelPrimitiveType string string string String
    public partial class InternedString : DataModel
    {
        public string                                   M_StringOriginalCase                    { get; set; }
        public string                                   M_StringLowerCase                       { get; set; }

        public static InternedString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InternedString() { Pointer= p0 };

            value.M_StringOriginalCase                      = GetString(new IntPtr(p + 0x010)); // 0245A2E35F58 0x10 M_StringOriginalCase        ( 000186672F10 ModelPrimitiveType string string string String )
            value.M_StringLowerCase                         = GetString(new IntPtr(p + 0x018)); // 0245A2E35F78 0x18 M_StringLowerCase           ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
