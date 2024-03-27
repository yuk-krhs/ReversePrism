using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortTargetIndex                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 UseFavoriteToggle                        0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class StorySortFilterPopupSortContentViewModel
    {
        public int                                      SortTargetIndex                         { get; set; }
        public bool                                     UseFavoriteToggle                       { get; set; }

        public static StorySortFilterPopupSortContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterPopupSortContentViewModel();

            value.SortTargetIndex                           = GetInt32(new IntPtr(p + 0x010)); // 0270D67C3520 0x10 SortTargetIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UseFavoriteToggle                         = GetBool(new IntPtr(p + 0x014)); // 0270D67C3540 0x14 UseFavoriteToggle           ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
