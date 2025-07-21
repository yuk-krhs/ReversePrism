using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_BaseMarkGlyphID                        ModelPrimitiveType uint uint uint UInt32
    // 014 M_BaseMarkGlyphAnchorPoint               ModelEnumType GlyphAnchorPoint GlyphAnchorPoint GlyphAnchorPoint Int32
    // 01C M_CombiningMarkGlyphID                   ModelPrimitiveType uint uint uint UInt32
    // 020 M_CombiningMarkPositionAdjustment        ModelEnumType MarkPositionAdjustment MarkPositionAdjustment MarkPositionAdjustment Int32
    public partial class MarkToMarkAdjustmentRecord : DataModel
    {
        public uint                                     M_BaseMarkGlyphID                       { get; set; }
        public GlyphAnchorPoint                         M_BaseMarkGlyphAnchorPoint              { get; set; }
        public uint                                     M_CombiningMarkGlyphID                  { get; set; }
        public MarkPositionAdjustment                   M_CombiningMarkPositionAdjustment       { get; set; }

        public static MarkToMarkAdjustmentRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MarkToMarkAdjustmentRecord() { Pointer= p0 };

            value.M_BaseMarkGlyphID                         = GetUInt32(new IntPtr(p + 0x010)); // 0x10 M_BaseMarkGlyphID           ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_BaseMarkGlyphAnchorPoint                = (GlyphAnchorPoint)GetInt32(new IntPtr(p + 0x014)); // 0x14 M_BaseMarkGlyphAnchorPoint  ( ModelEnumType GlyphAnchorPoint GlyphAnchorPoint GlyphAnchorPoint Int32 )
            value.M_CombiningMarkGlyphID                    = GetUInt32(new IntPtr(p + 0x01C)); // 0x1C M_CombiningMarkGlyphID      ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_CombiningMarkPositionAdjustment         = (MarkPositionAdjustment)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_CombiningMarkPositionAdjustment ( ModelEnumType MarkPositionAdjustment MarkPositionAdjustment MarkPositionAdjustment Int32 )

            return value;
        }
    }
}
