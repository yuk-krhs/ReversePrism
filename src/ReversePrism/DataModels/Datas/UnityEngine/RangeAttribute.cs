using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Min                                      000186666F40 ModelPrimitiveType float float float Single
    // 014 Max                                      000186666F40 ModelPrimitiveType float float float Single
    public partial class RangeAttribute : DataModel
    {
        public float                                    Min                                     { get; set; }
        public float                                    Max                                     { get; set; }

        public static RangeAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RangeAttribute() { Pointer= p0 };

            value.Min                                       = GetSingle(new IntPtr(p + 0x010)); // 0245A687AAE8 0x10 Min                         ( 000186666F40 ModelPrimitiveType float float float Single )
            value.Max                                       = GetSingle(new IntPtr(p + 0x014)); // 0245A687AB08 0x14 Max                         ( 000186666F40 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
