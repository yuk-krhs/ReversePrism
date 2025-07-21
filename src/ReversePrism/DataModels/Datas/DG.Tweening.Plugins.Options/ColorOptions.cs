using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AlphaOnly                                ModelPrimitiveType bool bool bool Bool
    public partial class ColorOptions : DataModel
    {
        public bool                                     AlphaOnly                               { get; set; }

        public static ColorOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorOptions() { Pointer= p0 };

            value.AlphaOnly                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 AlphaOnly                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
