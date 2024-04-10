using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReadToggleFilterViewModel                0001865A4110 ModelClassType StorySortFilterToggleFilterViewModel StorySortFilterToggleFilterViewModel StorySortFilterToggleFilterViewModel Pointer
    // 018 StoryTypeToggleFilterViewModel           0001865A4110 ModelClassType StorySortFilterToggleFilterViewModel StorySortFilterToggleFilterViewModel StorySortFilterToggleFilterViewModel Pointer
    // 020 CharacterFilterViewModel                 00018659F2D0 ModelClassType StorySortFilterCharacterFilterViewModel StorySortFilterCharacterFilterViewModel StorySortFilterCharacterFilterViewModel Pointer
    public partial class StorySortFilterPopupFilterContentViewModel : DataModel
    {
        public StorySortFilterToggleFilterViewModel?    ReadToggleFilterViewModel               { get; set; }
        public StorySortFilterToggleFilterViewModel?    StoryTypeToggleFilterViewModel          { get; set; }
        public StorySortFilterCharacterFilterViewModel? CharacterFilterViewModel                { get; set; }

        public static StorySortFilterPopupFilterContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterPopupFilterContentViewModel() { Pointer= p0 };

            value.ReadToggleFilterViewModel                 = GetObject<StorySortFilterToggleFilterViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.StorySortFilterToggleFilterViewModel.FromPointer); // 024666820D70 0x10 ReadToggleFilterViewModel   ( 0001865A4110 ModelClassType StorySortFilterToggleFilterViewModel StorySortFilterToggleFilterViewModel StorySortFilterToggleFilterViewModel Pointer )
            value.StoryTypeToggleFilterViewModel            = GetObject<StorySortFilterToggleFilterViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.StorySortFilterToggleFilterViewModel.FromPointer); // 024666820D90 0x18 StoryTypeToggleFilterViewModel ( 0001865A4110 ModelClassType StorySortFilterToggleFilterViewModel StorySortFilterToggleFilterViewModel StorySortFilterToggleFilterViewModel Pointer )
            value.CharacterFilterViewModel                  = GetObject<StorySortFilterCharacterFilterViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.StorySortFilterCharacterFilterViewModel.FromPointer); // 024666820DB0 0x20 CharacterFilterViewModel    ( 00018659F2D0 ModelClassType StorySortFilterCharacterFilterViewModel StorySortFilterCharacterFilterViewModel StorySortFilterCharacterFilterViewModel Pointer )

            return value;
        }
    }
}
