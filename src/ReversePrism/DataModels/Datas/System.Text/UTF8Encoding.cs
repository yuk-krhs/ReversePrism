using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_default                                UTF8EncodingSealed IL2CPP_TYPE_CLASS
    // 008 s_preamble                               sbyte[] IL2CPP_TYPE_SZARRAY
    // 038 EmitUTF8Identifier                       000186596860 ModelPrimitiveType bool bool bool Bool
    // 039 IsThrowException                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class UTF8Encoding
    {
        public bool                                     EmitUTF8Identifier                      { get; set; }
        public bool                                     IsThrowException                        { get; set; }

        public static UTF8Encoding? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UTF8Encoding();

            value.EmitUTF8Identifier                        = GetBool(new IntPtr(p + 0x038)); // 0270033E4EB0 0x38 EmitUTF8Identifier          ( 000186596860 ModelPrimitiveType bool bool bool Bool )
            value.IsThrowException                          = GetBool(new IntPtr(p + 0x039)); // 0270033E4ED0 0x39 IsThrowException            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
