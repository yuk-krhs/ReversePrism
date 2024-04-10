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
    public partial class StorySortFilterPopupSortContentView : DataModel
    {
        public ToggleButtonGroup?                       ToggleButtonGroup                       { get; set; }
        public GameObject?                              FavoriteToggle                          { get; set; }
        public StorySortFilterPopupSortContentViewModel? ViewModel                               { get; set; }

        public static StorySortFilterPopupSortContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterPopupSortContentView() { Pointer= p0 };

            value.ToggleButtonGroup                         = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466B9D4E98 0x20 ToggleButtonGroup           ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.FavoriteToggle                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466B9D4EB8 0x28 FavoriteToggle              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ViewModel                                 = GetObject<StorySortFilterPopupSortContentViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.StorySortFilterPopupSortContentViewModel.FromPointer); // 02466B9D4ED8 0x30 ViewModel                   ( 0001865A17E0 ModelClassType StorySortFilterPopupSortContentViewModel StorySortFilterPopupSortContentViewModel StorySortFilterPopupSortContentViewModel Pointer )

            return value;
        }
    }
}
