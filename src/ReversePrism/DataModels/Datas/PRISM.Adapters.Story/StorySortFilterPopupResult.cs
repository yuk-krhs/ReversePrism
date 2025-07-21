using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortTargetIndex                          ModelPrimitiveType int int int Int32
    // 018 <FilterOnIndices>k__BackingField         HashSet`1<int>[] IL2CPP_TYPE_SZARRAY
    public partial class StorySortFilterPopupResult : DataModel
    {
        public int                                      SortTargetIndex                         { get; set; }

        public static StorySortFilterPopupResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterPopupResult() { Pointer= p0 };

            value.SortTargetIndex                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 SortTargetIndex             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
