using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Width                                  0001866656B0 ModelPrimitiveType float float float Single
    // 014 M_Height                                 0001866656B0 ModelPrimitiveType float float float Single
    // 018 M_HorizontalBearingX                     0001866656B0 ModelPrimitiveType float float float Single
    // 01C M_HorizontalBearingY                     0001866656B0 ModelPrimitiveType float float float Single
    // 020 M_HorizontalAdvance                      0001866656B0 ModelPrimitiveType float float float Single
    public partial class GlyphMetrics
    {
        public float                                    M_Width                                 { get; set; }
        public float                                    M_Height                                { get; set; }
        public float                                    M_HorizontalBearingX                    { get; set; }
        public float                                    M_HorizontalBearingY                    { get; set; }
        public float                                    M_HorizontalAdvance                     { get; set; }

        public static GlyphMetrics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlyphMetrics();

            value.M_Width                                   = GetSingle(new IntPtr(p + 0x010)); // 02700215B648 0x10 M_Width                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Height                                  = GetSingle(new IntPtr(p + 0x014)); // 02700215B668 0x14 M_Height                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_HorizontalBearingX                      = GetSingle(new IntPtr(p + 0x018)); // 02700215B688 0x18 M_HorizontalBearingX        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_HorizontalBearingY                      = GetSingle(new IntPtr(p + 0x01C)); // 02700215B6A8 0x1C M_HorizontalBearingY        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_HorizontalAdvance                       = GetSingle(new IntPtr(p + 0x020)); // 02700215B6C8 0x20 M_HorizontalAdvance         ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
