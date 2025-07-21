using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_GlyphPairAdjustmentRecords             ModelClassListType List`1<TMP_GlyphPairAdjustmentRecord> List`1<TMP_GlyphPairAdjustmentRecord> List<TMP_GlyphPairAdjustmentRecord> Pointer
    // 018 m_GlyphPairAdjustmentRecordLookupDictionary Dictionary`2<uint, TMP_GlyphPairAdjustmentRecord> IL2CPP_TYPE_GENERICINST
    public partial class TMP_FontFeatureTable : DataModel
    {
        public List<TMP_GlyphPairAdjustmentRecord>?     M_GlyphPairAdjustmentRecords            { get; set; }

        public static TMP_FontFeatureTable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_FontFeatureTable() { Pointer= p0 };

            value.M_GlyphPairAdjustmentRecords              = GetObjectList<TMP_GlyphPairAdjustmentRecord>(new IntPtr(p + 0x010), ReversePrism.DataModels.TMP_GlyphPairAdjustmentRecord.FromPointer); // 0x10 M_GlyphPairAdjustmentRecords ( ModelClassListType List`1<TMP_GlyphPairAdjustmentRecord> List`1<TMP_GlyphPairAdjustmentRecord> List<TMP_GlyphPairAdjustmentRecord> Pointer )

            return value;
        }
    }
}
