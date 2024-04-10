using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NamingStrategy                           00018667F1A0 ModelClassType NamingStrategy NamingStrategy NamingStrategy Pointer
    // 018 AllowIntegerValues                       000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class StringEnumConverter : DataModel
    {
        public NamingStrategy?                          NamingStrategy                          { get; set; }
        public bool                                     AllowIntegerValues                      { get; set; }

        public static StringEnumConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringEnumConverter() { Pointer= p0 };

            value.NamingStrategy                            = GetObject<NamingStrategy>(new IntPtr(p + 0x010), ReversePrism.DataModels.NamingStrategy.FromPointer); // 0245A667B3F8 0x10 NamingStrategy              ( 00018667F1A0 ModelClassType NamingStrategy NamingStrategy NamingStrategy Pointer )
            value.AllowIntegerValues                        = GetBool(new IntPtr(p + 0x018)); // 0245A667B418 0x18 AllowIntegerValues          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
