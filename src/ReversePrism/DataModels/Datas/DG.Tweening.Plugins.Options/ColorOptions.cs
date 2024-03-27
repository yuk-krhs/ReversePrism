using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AlphaOnly                                000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class ColorOptions
    {
        public bool                                     AlphaOnly                               { get; set; }

        public static ColorOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorOptions();

            value.AlphaOnly                                 = GetBool(new IntPtr(p + 0x010)); // 027004348900 0x10 AlphaOnly                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
