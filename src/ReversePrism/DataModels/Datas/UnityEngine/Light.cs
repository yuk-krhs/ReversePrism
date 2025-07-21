using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_BakedIndex                             ModelPrimitiveType int int int Int32
    public partial class Light : DataModel
    {
        public int                                      M_BakedIndex                            { get; set; }

        public static Light? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Light() { Pointer= p0 };

            value.M_BakedIndex                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_BakedIndex                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
