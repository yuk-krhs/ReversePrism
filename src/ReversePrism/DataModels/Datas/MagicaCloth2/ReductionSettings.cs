using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SimpleDistance                           ModelPrimitiveType float float float Single
    // 014 ShapeDistance                            ModelPrimitiveType float float float Single
    public partial class ReductionSettings : DataModel
    {
        public float                                    SimpleDistance                          { get; set; }
        public float                                    ShapeDistance                           { get; set; }

        public static ReductionSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReductionSettings() { Pointer= p0 };

            value.SimpleDistance                            = GetSingle(new IntPtr(p + 0x010)); // 0x10 SimpleDistance              ( ModelPrimitiveType float float float Single )
            value.ShapeDistance                             = GetSingle(new IntPtr(p + 0x014)); // 0x14 ShapeDistance               ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
