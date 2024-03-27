using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_DefaultShadowQualityBias               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AdaptiveShadowQuality
    {
        public int                                      M_DefaultShadowQualityBias              { get; set; }

        public static AdaptiveShadowQuality? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptiveShadowQuality();

            value.M_DefaultShadowQualityBias                = GetInt32(new IntPtr(p + 0x040)); // 0270DB689BB8 0x40 M_DefaultShadowQualityBias  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
