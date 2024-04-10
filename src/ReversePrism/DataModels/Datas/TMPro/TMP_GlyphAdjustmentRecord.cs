using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_GlyphIndex                             000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 014 M_GlyphValueRecord                       00018660D7D0 ModelEnumType TMP_GlyphValueRecord TMP_GlyphValueRecord TMP_GlyphValueRecord Int32
    public partial class TMP_GlyphAdjustmentRecord : DataModel
    {
        public uint                                     M_GlyphIndex                            { get; set; }
        public TMP_GlyphValueRecord                     M_GlyphValueRecord                      { get; set; }

        public static TMP_GlyphAdjustmentRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_GlyphAdjustmentRecord() { Pointer= p0 };

            value.M_GlyphIndex                              = GetUInt32(new IntPtr(p + 0x010)); // 0246609BD4C8 0x10 M_GlyphIndex                ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.M_GlyphValueRecord                        = (TMP_GlyphValueRecord)GetInt32(new IntPtr(p + 0x014)); // 0246609BD4E8 0x14 M_GlyphValueRecord          ( 00018660D7D0 ModelEnumType TMP_GlyphValueRecord TMP_GlyphValueRecord TMP_GlyphValueRecord Int32 )

            return value;
        }
    }
}
