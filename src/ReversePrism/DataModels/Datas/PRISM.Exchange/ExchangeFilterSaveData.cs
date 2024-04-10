using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortFilterSettings                       0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    // 018 filterItemIDs                            List`1<int>[] IL2CPP_TYPE_SZARRAY
    // 020 FilterIDsSaveString                      000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class ExchangeFilterSaveData : DataModel
    {
        public SortFilterSettings?                      SortFilterSettings                      { get; set; }
        public List<string>?                            FilterIDsSaveString                     { get; set; }

        public static ExchangeFilterSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeFilterSaveData() { Pointer= p0 };

            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x010), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 0245A3AAC460 0x10 SortFilterSettings          ( 0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )
            value.FilterIDsSaveString                       = GetStringList(new IntPtr(p + 0x020)); // 0245A3AAC4A0 0x20 FilterIDsSaveString         ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
