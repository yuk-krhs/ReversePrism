using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortTargetIndex                          ModelPrimitiveType int int int Int32
    // 014 SortDirection                            ModelEnumType SortDirection SortDirection SortDirection Int32
    // 018 FilterValuesSaveString                   ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 filterOnIndices                          HashSet`1<int>[] IL2CPP_TYPE_SZARRAY
    public partial class SortFilterSettings : DataModel
    {
        public int                                      SortTargetIndex                         { get; set; }
        public SortDirection                            SortDirection                           { get; set; }
        public List<string>?                            FilterValuesSaveString                  { get; set; }

        public static SortFilterSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortFilterSettings() { Pointer= p0 };

            value.SortTargetIndex                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 SortTargetIndex             ( ModelPrimitiveType int int int Int32 )
            value.SortDirection                             = (SortDirection)GetInt32(new IntPtr(p + 0x014)); // 0x14 SortDirection               ( ModelEnumType SortDirection SortDirection SortDirection Int32 )
            value.FilterValuesSaveString                    = GetStringList(new IntPtr(p + 0x018)); // 0x18 FilterValuesSaveString      ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
