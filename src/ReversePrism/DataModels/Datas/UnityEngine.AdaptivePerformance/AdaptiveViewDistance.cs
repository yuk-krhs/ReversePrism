using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_DefaultFarClipPlane                    ModelPrimitiveType float float float Single
    public partial class AdaptiveViewDistance : DataModel
    {
        public float                                    M_DefaultFarClipPlane                   { get; set; }

        public static AdaptiveViewDistance? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptiveViewDistance() { Pointer= p0 };

            value.M_DefaultFarClipPlane                     = GetSingle(new IntPtr(p + 0x040)); // 0x40 M_DefaultFarClipPlane       ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
