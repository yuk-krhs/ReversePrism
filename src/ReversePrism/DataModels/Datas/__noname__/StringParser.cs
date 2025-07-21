using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _str                                     ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 020 _ch                                      char IL2CPP_TYPE_CHAR
    // 024 Pos                                      ModelPrimitiveType int int int Int32
    // 028 Len                                      ModelPrimitiveType int int int Int32
    public partial class StringParser : DataModel
    {
        public int                                      Pos                                     { get; set; }
        public int                                      Len                                     { get; set; }

        public static StringParser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringParser() { Pointer= p0 };

            value.Pos                                       = GetInt32(new IntPtr(p + 0x024)); // 0x24 Pos                         ( ModelPrimitiveType int int int Int32 )
            value.Len                                       = GetInt32(new IntPtr(p + 0x028)); // 0x28 Len                         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
