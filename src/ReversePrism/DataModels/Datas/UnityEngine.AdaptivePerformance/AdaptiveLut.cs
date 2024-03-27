using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_DefaultLutBias                         0001866656B0 ModelPrimitiveType float float float Single
    public partial class AdaptiveLut
    {
        public float                                    M_DefaultLutBias                        { get; set; }

        public static AdaptiveLut? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptiveLut();

            value.M_DefaultLutBias                          = GetSingle(new IntPtr(p + 0x040)); // 0270DB689AD8 0x40 M_DefaultLutBias            ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
