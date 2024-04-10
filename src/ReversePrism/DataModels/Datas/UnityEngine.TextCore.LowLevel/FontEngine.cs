using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Glyphs                                 Glyph[] IL2CPP_TYPE_SZARRAY
    // 008 s_GlyphIndexes_MarshallingArray_A        uint[] IL2CPP_TYPE_SZARRAY
    // 010 S_GlyphMarshallingStruct_IN              000185B822F0 ModelEnumListType GlyphMarshallingStruct[] GlyphMarshallingStruct[] List<GlyphMarshallingStruct> Pointer
    // 018 S_GlyphMarshallingStruct_OUT             000185B822F0 ModelEnumListType GlyphMarshallingStruct[] GlyphMarshallingStruct[] List<GlyphMarshallingStruct> Pointer
    // 020 S_FreeGlyphRects                         000185B82980 ModelEnumListType GlyphRect[] GlyphRect[] List<GlyphRect> Pointer
    // 028 S_UsedGlyphRects                         000185B82980 ModelEnumListType GlyphRect[] GlyphRect[] List<GlyphRect> Pointer
    // 030 S_PairAdjustmentRecords_MarshallingArray 000185B82780 ModelEnumListType GlyphPairAdjustmentRecord[] GlyphPairAdjustmentRecord[] List<GlyphPairAdjustmentRecord> Pointer
    // 038 s_GlyphLookupDictionary                  Dictionary`2<uint, Glyph> IL2CPP_TYPE_GENERICINST
    public partial class FontEngine : DataModel
    {
        public List<GlyphMarshallingStruct>?            S_GlyphMarshallingStruct_IN             { get; set; }
        public List<GlyphMarshallingStruct>?            S_GlyphMarshallingStruct_OUT            { get; set; }
        public List<GlyphRect>?                         S_FreeGlyphRects                        { get; set; }
        public List<GlyphRect>?                         S_UsedGlyphRects                        { get; set; }
        public List<GlyphPairAdjustmentRecord>?         S_PairAdjustmentRecords_MarshallingArray { get; set; }

        public static FontEngine? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FontEngine() { Pointer= p0 };

            value.S_GlyphMarshallingStruct_IN               = GetEnumList<GlyphMarshallingStruct>(new IntPtr(p + 0x010)); // 0245A3A27F40 0x10 S_GlyphMarshallingStruct_IN ( 000185B822F0 ModelEnumListType GlyphMarshallingStruct[] GlyphMarshallingStruct[] List<GlyphMarshallingStruct> Pointer )
            value.S_GlyphMarshallingStruct_OUT              = GetEnumList<GlyphMarshallingStruct>(new IntPtr(p + 0x018)); // 0245A3A27F60 0x18 S_GlyphMarshallingStruct_OUT ( 000185B822F0 ModelEnumListType GlyphMarshallingStruct[] GlyphMarshallingStruct[] List<GlyphMarshallingStruct> Pointer )
            value.S_FreeGlyphRects                          = GetEnumList<GlyphRect>(new IntPtr(p + 0x020)); // 0245A3A27F80 0x20 S_FreeGlyphRects            ( 000185B82980 ModelEnumListType GlyphRect[] GlyphRect[] List<GlyphRect> Pointer )
            value.S_UsedGlyphRects                          = GetEnumList<GlyphRect>(new IntPtr(p + 0x028)); // 0245A3A27FA0 0x28 S_UsedGlyphRects            ( 000185B82980 ModelEnumListType GlyphRect[] GlyphRect[] List<GlyphRect> Pointer )
            value.S_PairAdjustmentRecords_MarshallingArray  = GetEnumList<GlyphPairAdjustmentRecord>(new IntPtr(p + 0x030)); // 0245A3A27FC0 0x30 S_PairAdjustmentRecords_MarshallingArray ( 000185B82780 ModelEnumListType GlyphPairAdjustmentRecord[] GlyphPairAdjustmentRecord[] List<GlyphPairAdjustmentRecord> Pointer )

            return value;
        }
    }
}
