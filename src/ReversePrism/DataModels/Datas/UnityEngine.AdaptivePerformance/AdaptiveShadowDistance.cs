using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_DefaultShadowDistance                  0001866656B0 ModelPrimitiveType float float float Single
    public partial class AdaptiveShadowDistance
    {
        public float                                    M_DefaultShadowDistance                 { get; set; }

        public static AdaptiveShadowDistance? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptiveShadowDistance();

            value.M_DefaultShadowDistance                   = GetSingle(new IntPtr(p + 0x040)); // 0270DB689B78 0x40 M_DefaultShadowDistance     ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
