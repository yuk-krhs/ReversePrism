using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ReadFilterView                           0001865A39E0 ModelClassType StorySortFilterToggleFilterView StorySortFilterToggleFilterView StorySortFilterToggleFilterView Pointer
    // 028 StoryTypeFilterView                      0001865A39E0 ModelClassType StorySortFilterToggleFilterView StorySortFilterToggleFilterView StorySortFilterToggleFilterView Pointer
    // 030 CharacterFilterView                      00018659EBE0 ModelClassType StorySortFilterCharacterFilterView StorySortFilterCharacterFilterView StorySortFilterCharacterFilterView Pointer
    // 038 FilterResetButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 ViewModel                                0001865A0430 ModelClassType StorySortFilterPopupFilterContentViewModel StorySortFilterPopupFilterContentViewModel StorySortFilterPopupFilterContentViewModel Pointer
    public partial class StorySortFilterPopupFilterContentView : DataModel
    {
        public StorySortFilterToggleFilterView?         ReadFilterView                          { get; set; }
        public StorySortFilterToggleFilterView?         StoryTypeFilterView                     { get; set; }
        public StorySortFilterCharacterFilterView?      CharacterFilterView                     { get; set; }
        public UIButton?                                FilterResetButton                       { get; set; }
        public StorySortFilterPopupFilterContentViewModel? ViewModel                               { get; set; }

        public static StorySortFilterPopupFilterContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterPopupFilterContentView() { Pointer= p0 };

            value.ReadFilterView                            = GetObject<StorySortFilterToggleFilterView>(new IntPtr(p + 0x020), ReversePrism.DataModels.StorySortFilterToggleFilterView.FromPointer); // 02466B9D4D98 0x20 ReadFilterView              ( 0001865A39E0 ModelClassType StorySortFilterToggleFilterView StorySortFilterToggleFilterView StorySortFilterToggleFilterView Pointer )
            value.StoryTypeFilterView                       = GetObject<StorySortFilterToggleFilterView>(new IntPtr(p + 0x028), ReversePrism.DataModels.StorySortFilterToggleFilterView.FromPointer); // 02466B9D4DB8 0x28 StoryTypeFilterView         ( 0001865A39E0 ModelClassType StorySortFilterToggleFilterView StorySortFilterToggleFilterView StorySortFilterToggleFilterView Pointer )
            value.CharacterFilterView                       = GetObject<StorySortFilterCharacterFilterView>(new IntPtr(p + 0x030), ReversePrism.DataModels.StorySortFilterCharacterFilterView.FromPointer); // 02466B9D4DD8 0x30 CharacterFilterView         ( 00018659EBE0 ModelClassType StorySortFilterCharacterFilterView StorySortFilterCharacterFilterView StorySortFilterCharacterFilterView Pointer )
            value.FilterResetButton                         = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466B9D4DF8 0x38 FilterResetButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<StorySortFilterPopupFilterContentViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.StorySortFilterPopupFilterContentViewModel.FromPointer); // 02466B9D4E18 0x40 ViewModel                   ( 0001865A0430 ModelClassType StorySortFilterPopupFilterContentViewModel StorySortFilterPopupFilterContentViewModel StorySortFilterPopupFilterContentViewModel Pointer )

            return value;
        }
    }
}
