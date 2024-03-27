using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 S                                        000186671910 ModelPrimitiveType string string string String
    // 020 Pos                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Length                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class StringReader
    {
        public string                                   S                                       { get; set; }
        public int                                      Pos                                     { get; set; }
        public int                                      Length                                  { get; set; }

        public static StringReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringReader();

            value.S                                         = GetString(new IntPtr(p + 0x018)); // 027005FE4FA0 0x18 S                           ( 000186671910 ModelPrimitiveType string string string String )
            value.Pos                                       = GetInt32(new IntPtr(p + 0x020)); // 027005FE4FC0 0x20 Pos                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x024)); // 027005FE4FE0 0x24 Length                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
