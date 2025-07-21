using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_DefaultCascadeCount                    ModelPrimitiveType int int int Int32
    public partial class AdaptiveShadowCascade : DataModel
    {
        public int                                      M_DefaultCascadeCount                   { get; set; }

        public static AdaptiveShadowCascade? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptiveShadowCascade() { Pointer= p0 };

            value.M_DefaultCascadeCount                     = GetInt32(new IntPtr(p + 0x040)); // 0x40 M_DefaultCascadeCount       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
