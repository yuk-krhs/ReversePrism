using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_XCoordinate                            0001866656B0 ModelPrimitiveType float float float Single
    // 014 M_YCoordinate                            0001866656B0 ModelPrimitiveType float float float Single
    public partial class GlyphAnchorPoint
    {
        public float                                    M_XCoordinate                           { get; set; }
        public float                                    M_YCoordinate                           { get; set; }

        public static GlyphAnchorPoint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlyphAnchorPoint();

            value.M_XCoordinate                             = GetSingle(new IntPtr(p + 0x010)); // 027002165558 0x10 M_XCoordinate               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_YCoordinate                             = GetSingle(new IntPtr(p + 0x014)); // 027002165578 0x14 M_YCoordinate               ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
