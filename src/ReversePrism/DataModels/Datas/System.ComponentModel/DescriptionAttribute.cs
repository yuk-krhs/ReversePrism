using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  DescriptionAttribute IL2CPP_TYPE_CLASS
    // 010 DescriptionValue                         000186671910 ModelPrimitiveType string string string String
    public partial class DescriptionAttribute
    {
        public string                                   DescriptionValue                        { get; set; }

        public static DescriptionAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DescriptionAttribute();

            value.DescriptionValue                          = GetString(new IntPtr(p + 0x010)); // 0270D7987120 0x10 DescriptionValue            ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
