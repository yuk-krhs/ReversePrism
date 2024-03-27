using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Snapping                                 000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class FloatOptions
    {
        public bool                                     Snapping                                { get; set; }

        public static FloatOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FloatOptions();

            value.Snapping                                  = GetBool(new IntPtr(p + 0x010)); // 027004437860 0x10 Snapping                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
