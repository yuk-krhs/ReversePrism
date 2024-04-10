using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_DefaultShadowmapResolution             0001866656B0 ModelPrimitiveType float float float Single
    public partial class AdaptiveShadowmapResolution : DataModel
    {
        public float                                    M_DefaultShadowmapResolution            { get; set; }

        public static AdaptiveShadowmapResolution? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptiveShadowmapResolution() { Pointer= p0 };

            value.M_DefaultShadowmapResolution              = GetSingle(new IntPtr(p + 0x040)); // 02466B715E58 0x40 M_DefaultShadowmapResolution ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
