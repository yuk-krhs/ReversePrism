using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_BaseGlyphID                            000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 014 M_BaseGlyphAnchorPoint                   00018667FF60 ModelEnumType GlyphAnchorPoint GlyphAnchorPoint GlyphAnchorPoint Int32
    // 01C M_MarkGlyphID                            000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 020 M_MarkPositionAdjustment                 0001865D36E0 ModelEnumType MarkPositionAdjustment MarkPositionAdjustment MarkPositionAdjustment Int32
    public partial class MarkToBaseAdjustmentRecord
    {
        public uint                                     M_BaseGlyphID                           { get; set; }
        public GlyphAnchorPoint                         M_BaseGlyphAnchorPoint                  { get; set; }
        public uint                                     M_MarkGlyphID                           { get; set; }
        public MarkPositionAdjustment                   M_MarkPositionAdjustment                { get; set; }

        public static MarkToBaseAdjustmentRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MarkToBaseAdjustmentRecord();

            value.M_BaseGlyphID                             = GetUInt32(new IntPtr(p + 0x010)); // 0270021736A8 0x10 M_BaseGlyphID               ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.M_BaseGlyphAnchorPoint                    = (GlyphAnchorPoint)GetInt32(new IntPtr(p + 0x014)); // 0270021736C8 0x14 M_BaseGlyphAnchorPoint      ( 00018667FF60 ModelEnumType GlyphAnchorPoint GlyphAnchorPoint GlyphAnchorPoint Int32 )
            value.M_MarkGlyphID                             = GetUInt32(new IntPtr(p + 0x01C)); // 0270021736E8 0x1C M_MarkGlyphID               ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.M_MarkPositionAdjustment                  = (MarkPositionAdjustment)GetInt32(new IntPtr(p + 0x020)); // 027002173708 0x20 M_MarkPositionAdjustment    ( 0001865D36E0 ModelEnumType MarkPositionAdjustment MarkPositionAdjustment MarkPositionAdjustment Int32 )

            return value;
        }
    }
}
