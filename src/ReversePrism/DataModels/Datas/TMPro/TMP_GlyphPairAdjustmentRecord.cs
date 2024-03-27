using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_FirstAdjustmentRecord                  00018660D110 ModelEnumType TMP_GlyphAdjustmentRecord TMP_GlyphAdjustmentRecord TMP_GlyphAdjustmentRecord Int32
    // 024 M_SecondAdjustmentRecord                 00018660D110 ModelEnumType TMP_GlyphAdjustmentRecord TMP_GlyphAdjustmentRecord TMP_GlyphAdjustmentRecord Int32
    // 038 M_FeatureLookupFlags                     0001865AFCE0 ModelEnumType FontFeatureLookupFlags FontFeatureLookupFlags FontFeatureLookupFlags Int32
    public partial class TMP_GlyphPairAdjustmentRecord
    {
        public TMP_GlyphAdjustmentRecord                M_FirstAdjustmentRecord                 { get; set; }
        public TMP_GlyphAdjustmentRecord                M_SecondAdjustmentRecord                { get; set; }
        public FontFeatureLookupFlags                   M_FeatureLookupFlags                    { get; set; }

        public static TMP_GlyphPairAdjustmentRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_GlyphPairAdjustmentRecord();

            value.M_FirstAdjustmentRecord                   = (TMP_GlyphAdjustmentRecord)GetInt32(new IntPtr(p + 0x010)); // 0270D09CE568 0x10 M_FirstAdjustmentRecord     ( 00018660D110 ModelEnumType TMP_GlyphAdjustmentRecord TMP_GlyphAdjustmentRecord TMP_GlyphAdjustmentRecord Int32 )
            value.M_SecondAdjustmentRecord                  = (TMP_GlyphAdjustmentRecord)GetInt32(new IntPtr(p + 0x024)); // 0270D09CE588 0x24 M_SecondAdjustmentRecord    ( 00018660D110 ModelEnumType TMP_GlyphAdjustmentRecord TMP_GlyphAdjustmentRecord TMP_GlyphAdjustmentRecord Int32 )
            value.M_FeatureLookupFlags                      = (FontFeatureLookupFlags)GetInt32(new IntPtr(p + 0x038)); // 0270D09CE5A8 0x38 M_FeatureLookupFlags        ( 0001865AFCE0 ModelEnumType FontFeatureLookupFlags FontFeatureLookupFlags FontFeatureLookupFlags Int32 )

            return value;
        }
    }
}
