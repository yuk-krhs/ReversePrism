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
    public partial class NativeClassAttribute : DataModel
    {
        public string                                   QualifiedNativeName                     { get; set; }
        public string                                   Declaration                             { get; set; }

        public static NativeClassAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeClassAttribute() { Pointer= p0 };

            value.QualifiedNativeName                       = GetString(new IntPtr(p + 0x010)); // 0245A692B250 0x10 QualifiedNativeName         ( 000186671910 ModelPrimitiveType string string string String )
            value.Declaration                               = GetString(new IntPtr(p + 0x018)); // 0245A692B270 0x18 Declaration                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
