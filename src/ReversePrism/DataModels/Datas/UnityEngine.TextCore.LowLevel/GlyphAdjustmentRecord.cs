using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_GlyphIndex                             ModelPrimitiveType uint uint uint UInt32
    // 014 M_GlyphValueRecord                       ModelEnumType GlyphValueRecord GlyphValueRecord GlyphValueRecord Int32
    public partial class GlyphAdjustmentRecord : DataModel
    {
        public uint                                     M_GlyphIndex                            { get; set; }
        public GlyphValueRecord                         M_GlyphValueRecord                      { get; set; }

        public static GlyphAdjustmentRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlyphAdjustmentRecord() { Pointer= p0 };

            value.M_GlyphIndex                              = GetUInt32(new IntPtr(p + 0x010)); // 0x10 M_GlyphIndex                ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_GlyphValueRecord                        = (GlyphValueRecord)GetInt32(new IntPtr(p + 0x014)); // 0x14 M_GlyphValueRecord          ( ModelEnumType GlyphValueRecord GlyphValueRecord GlyphValueRecord Int32 )

            return value;
        }
    }
}
