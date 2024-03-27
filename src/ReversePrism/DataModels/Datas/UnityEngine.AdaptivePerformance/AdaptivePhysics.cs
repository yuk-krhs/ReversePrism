using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_fixedDeltaTimeDefault                  0001866656B0 ModelPrimitiveType float float float Single
    public partial class AdaptivePhysics
    {
        public float                                    M_fixedDeltaTimeDefault                 { get; set; }

        public static AdaptivePhysics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePhysics();

            value.M_fixedDeltaTimeDefault                   = GetSingle(new IntPtr(p + 0x040)); // 0270DB689B18 0x40 M_fixedDeltaTimeDefault     ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
