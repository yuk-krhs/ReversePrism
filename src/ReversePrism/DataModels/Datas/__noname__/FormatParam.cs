using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Int32                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 018 String                                   000186672F10 ModelPrimitiveType string string string String
    public partial class FormatParam
    {
        public int                                      Int32                                   { get; set; }
        public string                                   String                                  { get; set; }

        public static FormatParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FormatParam();

            value.Int32                                     = GetInt32(new IntPtr(p + 0x010)); // 0270D6A6FE50 0x10 Int32                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.String                                    = GetString(new IntPtr(p + 0x018)); // 0270D6A6FE70 0x18 String                      ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
