using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 mouse                                    string IL2CPP_TYPE_STRING
    // 008 touch                                    string IL2CPP_TYPE_STRING
    // 010 Pen                                      000186674040 ModelPrimitiveType string string string String
    // 018 Unknown                                  000186674040 ModelPrimitiveType string string string String
    public partial class PointerType
    {
        public string                                   Pen                                     { get; set; }
        public string                                   Unknown                                 { get; set; }

        public static PointerType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerType();

            value.Pen                                       = GetString(new IntPtr(p + 0x010)); // 0270067AB610 0x10 Pen                         ( 000186674040 ModelPrimitiveType string string string String )
            value.Unknown                                   = GetString(new IntPtr(p + 0x018)); // 0270067AB630 0x18 Unknown                     ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
