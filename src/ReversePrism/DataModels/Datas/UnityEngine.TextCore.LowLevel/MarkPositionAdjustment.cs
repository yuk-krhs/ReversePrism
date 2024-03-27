using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_XPositionAdjustment                    0001866656B0 ModelPrimitiveType float float float Single
    // 014 M_YPositionAdjustment                    0001866656B0 ModelPrimitiveType float float float Single
    public partial class MarkPositionAdjustment
    {
        public float                                    M_XPositionAdjustment                   { get; set; }
        public float                                    M_YPositionAdjustment                   { get; set; }

        public static MarkPositionAdjustment? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MarkPositionAdjustment();

            value.M_XPositionAdjustment                     = GetSingle(new IntPtr(p + 0x010)); // 027002171DB0 0x10 M_XPositionAdjustment       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_YPositionAdjustment                     = GetSingle(new IntPtr(p + 0x014)); // 027002171DD0 0x14 M_YPositionAdjustment       ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
