using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortContentViewModel                     0001865A1A10 ModelClassType StorySortFilterPopupSortContentViewModel StorySortFilterPopupSortContentViewModel StorySortFilterPopupSortContentViewModel Pointer
    // 018 FilterContentViewModel                   0001865A0670 ModelClassType StorySortFilterPopupFilterContentViewModel StorySortFilterPopupFilterContentViewModel StorySortFilterPopupFilterContentViewModel Pointer
    public partial class StorySortFilterPopupViewModel : DataModel
    {
        public StorySortFilterPopupSortContentViewModel? SortContentViewModel                    { get; set; }
        public StorySortFilterPopupFilterContentViewModel? FilterContentViewModel                  { get; set; }

        public static StorySortFilterPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterPopupViewModel() { Pointer= p0 };

            value.SortContentViewModel                      = GetObject<StorySortFilterPopupSortContentViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.StorySortFilterPopupSortContentViewModel.FromPointer); // 02466681E2E0 0x10 SortContentViewModel        ( 0001865A1A10 ModelClassType StorySortFilterPopupSortContentViewModel StorySortFilterPopupSortContentViewModel StorySortFilterPopupSortContentViewModel Pointer )
            value.FilterContentViewModel                    = GetObject<StorySortFilterPopupFilterContentViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.StorySortFilterPopupFilterContentViewModel.FromPointer); // 02466681E300 0x18 FilterContentViewModel      ( 0001865A0670 ModelClassType StorySortFilterPopupFilterContentViewModel StorySortFilterPopupFilterContentViewModel StorySortFilterPopupFilterContentViewModel Pointer )

            return value;
        }
    }
}
