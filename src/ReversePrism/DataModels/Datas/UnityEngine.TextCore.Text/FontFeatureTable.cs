using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_MultipleSubstitutionRecords            000185CF4E28 ModelEnumListType List`1<MultipleSubstitutionRecord> List`1<MultipleSubstitutionRecord> List<MultipleSubstitutionRecord> Pointer
    // 018 M_LigatureSubstitutionRecords            000185CEFDA8 ModelEnumListType List`1<LigatureSubstitutionRecord> List`1<LigatureSubstitutionRecord> List<LigatureSubstitutionRecord> Pointer
    // 020 M_GlyphPairAdjustmentRecords             000185CDECE8 ModelEnumListType List`1<GlyphPairAdjustmentRecord> List`1<GlyphPairAdjustmentRecord> List<GlyphPairAdjustmentRecord> Pointer
    // 028 M_MarkToBaseAdjustmentRecords            000185CF1958 ModelEnumListType List`1<MarkToBaseAdjustmentRecord> List`1<MarkToBaseAdjustmentRecord> List<MarkToBaseAdjustmentRecord> Pointer
    // 030 M_MarkToMarkAdjustmentRecords            000185CF1BB8 ModelEnumListType List`1<MarkToMarkAdjustmentRecord> List`1<MarkToMarkAdjustmentRecord> List<MarkToMarkAdjustmentRecord> Pointer
    // 038 m_LigatureSubstitutionRecordLookup       Dictionary`2<uint, List`1<LigatureSubstitutionRecord>> IL2CPP_TYPE_GENERICINST
    // 040 m_GlyphPairAdjustmentRecordLookup        Dictionary`2<uint, GlyphPairAdjustmentRecord> IL2CPP_TYPE_GENERICINST
    // 048 m_MarkToBaseAdjustmentRecordLookup       Dictionary`2<uint, MarkToBaseAdjustmentRecord> IL2CPP_TYPE_GENERICINST
    // 050 m_MarkToMarkAdjustmentRecordLookup       Dictionary`2<uint, MarkToMarkAdjustmentRecord> IL2CPP_TYPE_GENERICINST
    public partial class FontFeatureTable : DataModel
    {
        public List<MultipleSubstitutionRecord>?        M_MultipleSubstitutionRecords           { get; set; }
        public List<LigatureSubstitutionRecord>?        M_LigatureSubstitutionRecords           { get; set; }
        public List<GlyphPairAdjustmentRecord>?         M_GlyphPairAdjustmentRecords            { get; set; }
        public List<MarkToBaseAdjustmentRecord>?        M_MarkToBaseAdjustmentRecords           { get; set; }
        public List<MarkToMarkAdjustmentRecord>?        M_MarkToMarkAdjustmentRecords           { get; set; }

        public static FontFeatureTable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FontFeatureTable() { Pointer= p0 };

            value.M_MultipleSubstitutionRecords             = GetEnumList<MultipleSubstitutionRecord>(new IntPtr(p + 0x010)); // 0245A68AB8E8 0x10 M_MultipleSubstitutionRecords ( 000185CF4E28 ModelEnumListType List`1<MultipleSubstitutionRecord> List`1<MultipleSubstitutionRecord> List<MultipleSubstitutionRecord> Pointer )
            value.M_LigatureSubstitutionRecords             = GetEnumList<LigatureSubstitutionRecord>(new IntPtr(p + 0x018)); // 0245A68AB908 0x18 M_LigatureSubstitutionRecords ( 000185CEFDA8 ModelEnumListType List`1<LigatureSubstitutionRecord> List`1<LigatureSubstitutionRecord> List<LigatureSubstitutionRecord> Pointer )
            value.M_GlyphPairAdjustmentRecords              = GetEnumList<GlyphPairAdjustmentRecord>(new IntPtr(p + 0x020)); // 0245A68AB928 0x20 M_GlyphPairAdjustmentRecords ( 000185CDECE8 ModelEnumListType List`1<GlyphPairAdjustmentRecord> List`1<GlyphPairAdjustmentRecord> List<GlyphPairAdjustmentRecord> Pointer )
            value.M_MarkToBaseAdjustmentRecords             = GetEnumList<MarkToBaseAdjustmentRecord>(new IntPtr(p + 0x028)); // 0245A68AB948 0x28 M_MarkToBaseAdjustmentRecords ( 000185CF1958 ModelEnumListType List`1<MarkToBaseAdjustmentRecord> List`1<MarkToBaseAdjustmentRecord> List<MarkToBaseAdjustmentRecord> Pointer )
            value.M_MarkToMarkAdjustmentRecords             = GetEnumList<MarkToMarkAdjustmentRecord>(new IntPtr(p + 0x030)); // 0245A68AB968 0x30 M_MarkToMarkAdjustmentRecords ( 000185CF1BB8 ModelEnumListType List`1<MarkToMarkAdjustmentRecord> List`1<MarkToMarkAdjustmentRecord> List<MarkToMarkAdjustmentRecord> Pointer )

            return value;
        }
    }
}
