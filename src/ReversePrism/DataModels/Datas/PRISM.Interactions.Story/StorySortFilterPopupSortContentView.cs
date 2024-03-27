using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ToggleButtonGroup                        000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 028 FavoriteToggle                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 ViewModel                                0001865A17E0 ModelClassType StorySortFilterPopupSortContentViewModel StorySortFilterPopupSortContentViewModel StorySortFilterPopupSortContentViewModel Pointer
    public partial class StorySortFilterPopupSortContentView
    {
        public ToggleButtonGroup?                       ToggleButtonGroup                       { get; set; }
        public GameObject?                              FavoriteToggle                          { get; set; }
        public StorySortFilterPopupSortContentViewModel? ViewModel                               { get; set; }

        public static StorySortFilterPopupSortContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterPopupSortContentView();

            value.ToggleButtonGroup                         = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270DB94DA88 0x20 ToggleButtonGroup           ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.FavoriteToggle                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB94DAA8 0x28 FavoriteToggle              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ViewModel                                 = GetObject<StorySortFilterPopupSortContentViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.StorySortFilterPopupSortContentViewModel.FromPointer); // 0270DB94DAC8 0x30 ViewModel                   ( 0001865A17E0 ModelClassType StorySortFilterPopupSortContentViewModel StorySortFilterPopupSortContentViewModel StorySortFilterPopupSortContentViewModel Pointer )

            return value;
        }
    }
}
