using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_DefaultShadowDistance                  ModelPrimitiveType float float float Single
    public partial class AdaptiveShadowDistance : DataModel
    {
        public float                                    M_DefaultShadowDistance                 { get; set; }

        public static AdaptiveShadowDistance? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptiveShadowDistance() { Pointer= p0 };

            value.M_DefaultShadowDistance                   = GetSingle(new IntPtr(p + 0x040)); // 0x40 M_DefaultShadowDistance     ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
