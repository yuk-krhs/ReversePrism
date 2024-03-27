using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 QualifiedNativeName                      000186671910 ModelPrimitiveType string string string String
    // 018 Declaration                              000186671910 ModelPrimitiveType string string string String
    public partial class NativeClassAttribute
    {
        public string                                   QualifiedNativeName                     { get; set; }
        public string                                   Declaration                             { get; set; }

        public static NativeClassAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeClassAttribute();

            value.QualifiedNativeName                       = GetString(new IntPtr(p + 0x010)); // 027006978AB8 0x10 QualifiedNativeName         ( 000186671910 ModelPrimitiveType string string string String )
            value.Declaration                               = GetString(new IntPtr(p + 0x018)); // 027006978AD8 0x18 Declaration                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
