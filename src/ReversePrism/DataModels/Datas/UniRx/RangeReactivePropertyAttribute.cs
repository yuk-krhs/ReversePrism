using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Min                                      ModelPrimitiveType float float float Single
    // 014 Max                                      ModelPrimitiveType float float float Single
    public partial class RangeReactivePropertyAttribute : DataModel
    {
        public float                                    Min                                     { get; set; }
        public float                                    Max                                     { get; set; }

        public static RangeReactivePropertyAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RangeReactivePropertyAttribute() { Pointer= p0 };

            value.Min                                       = GetSingle(new IntPtr(p + 0x010)); // 0x10 Min                         ( ModelPrimitiveType float float float Single )
            value.Max                                       = GetSingle(new IntPtr(p + 0x014)); // 0x14 Max                         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
