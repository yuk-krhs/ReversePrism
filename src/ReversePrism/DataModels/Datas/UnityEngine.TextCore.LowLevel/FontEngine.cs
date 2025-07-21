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
    // 010 S_GlyphMarshallingStruct_IN              ModelEnumListType GlyphMarshallingStruct[] GlyphMarshallingStruct[] List<GlyphMarshallingStruct> Pointer
    // 018 S_GlyphMarshallingStruct_OUT             ModelEnumListType GlyphMarshallingStruct[] GlyphMarshallingStruct[] List<GlyphMarshallingStruct> Pointer
    // 020 S_FreeGlyphRects                         ModelEnumListType GlyphRect[] GlyphRect[] List<GlyphRect> Pointer
    // 028 S_UsedGlyphRects                         ModelEnumListType GlyphRect[] GlyphRect[] List<GlyphRect> Pointer
    // 030 S_PairAdjustmentRecords_MarshallingArray ModelEnumListType GlyphPairAdjustmentRecord[] GlyphPairAdjustmentRecord[] List<GlyphPairAdjustmentRecord> Pointer
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

            value.S_GlyphMarshallingStruct_IN               = GetEnumList<GlyphMarshallingStruct>(new IntPtr(p + 0x010)); // 0x10 S_GlyphMarshallingStruct_IN ( ModelEnumListType GlyphMarshallingStruct[] GlyphMarshallingStruct[] List<GlyphMarshallingStruct> Pointer )
            value.S_GlyphMarshallingStruct_OUT              = GetEnumList<GlyphMarshallingStruct>(new IntPtr(p + 0x018)); // 0x18 S_GlyphMarshallingStruct_OUT ( ModelEnumListType GlyphMarshallingStruct[] GlyphMarshallingStruct[] List<GlyphMarshallingStruct> Pointer )
            value.S_FreeGlyphRects                          = GetEnumList<GlyphRect>(new IntPtr(p + 0x020)); // 0x20 S_FreeGlyphRects            ( ModelEnumListType GlyphRect[] GlyphRect[] List<GlyphRect> Pointer )
            value.S_UsedGlyphRects                          = GetEnumList<GlyphRect>(new IntPtr(p + 0x028)); // 0x28 S_UsedGlyphRects            ( ModelEnumListType GlyphRect[] GlyphRect[] List<GlyphRect> Pointer )
            value.S_PairAdjustmentRecords_MarshallingArray  = GetEnumList<GlyphPairAdjustmentRecord>(new IntPtr(p + 0x030)); // 0x30 S_PairAdjustmentRecords_MarshallingArray ( ModelEnumListType GlyphPairAdjustmentRecord[] GlyphPairAdjustmentRecord[] List<GlyphPairAdjustmentRecord> Pointer )

            return value;
        }
    }
}
