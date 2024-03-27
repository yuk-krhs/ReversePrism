using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_FirstAdjustmentRecord                  00018667FAA0 ModelEnumType GlyphAdjustmentRecord GlyphAdjustmentRecord GlyphAdjustmentRecord Int32
    // 024 M_SecondAdjustmentRecord                 00018667FAA0 ModelEnumType GlyphAdjustmentRecord GlyphAdjustmentRecord GlyphAdjustmentRecord Int32
    // 038 M_FeatureLookupFlags                     0001865B0440 ModelEnumType FontFeatureLookupFlags FontFeatureLookupFlags FontFeatureLookupFlags Int32
    public partial class GlyphPairAdjustmentRecord
    {
        public GlyphAdjustmentRecord                    M_FirstAdjustmentRecord                 { get; set; }
        public GlyphAdjustmentRecord                    M_SecondAdjustmentRecord                { get; set; }
        public FontFeatureLookupFlags                   M_FeatureLookupFlags                    { get; set; }

        public static GlyphPairAdjustmentRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlyphPairAdjustmentRecord();

            value.M_FirstAdjustmentRecord                   = (GlyphAdjustmentRecord)GetInt32(new IntPtr(p + 0x010)); // 02700216B420 0x10 M_FirstAdjustmentRecord     ( 00018667FAA0 ModelEnumType GlyphAdjustmentRecord GlyphAdjustmentRecord GlyphAdjustmentRecord Int32 )
            value.M_SecondAdjustmentRecord                  = (GlyphAdjustmentRecord)GetInt32(new IntPtr(p + 0x024)); // 02700216B440 0x24 M_SecondAdjustmentRecord    ( 00018667FAA0 ModelEnumType GlyphAdjustmentRecord GlyphAdjustmentRecord GlyphAdjustmentRecord Int32 )
            value.M_FeatureLookupFlags                      = (FontFeatureLookupFlags)GetInt32(new IntPtr(p + 0x038)); // 02700216B460 0x38 M_FeatureLookupFlags        ( 0001865B0440 ModelEnumType FontFeatureLookupFlags FontFeatureLookupFlags FontFeatureLookupFlags Int32 )

            return value;
        }
    }
}
