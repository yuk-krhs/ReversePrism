using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortTargetIndex                          ModelPrimitiveType int int int Int32
    // 014 UseFavoriteToggle                        ModelPrimitiveType bool bool bool Bool
    public partial class StorySortFilterPopupSortContentViewModel : DataModel
    {
        public int                                      SortTargetIndex                         { get; set; }
        public bool                                     UseFavoriteToggle                       { get; set; }

        public static StorySortFilterPopupSortContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterPopupSortContentViewModel() { Pointer= p0 };

            value.SortTargetIndex                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 SortTargetIndex             ( ModelPrimitiveType int int int Int32 )
            value.UseFavoriteToggle                         = GetBool(new IntPtr(p + 0x014)); // 0x14 UseFavoriteToggle           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
