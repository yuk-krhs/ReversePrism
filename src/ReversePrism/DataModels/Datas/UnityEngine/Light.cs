using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_BakedIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class Light
    {
        public int                                      M_BakedIndex                            { get; set; }

        public static Light? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Light();

            value.M_BakedIndex                              = GetInt32(new IntPtr(p + 0x018)); // 0270065F6A38 0x18 M_BakedIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
