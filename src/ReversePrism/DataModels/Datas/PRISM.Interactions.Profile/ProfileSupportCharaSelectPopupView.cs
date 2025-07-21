using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GridView                                 ModelClassType ProfileSupportCharaSelectGridView ProfileSupportCharaSelectGridView ProfileSupportCharaSelectGridView Pointer
    // 028 SortFilterView                           ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 030 SortSwitch                               ModelClassType UISwitch UISwitch UISwitch Pointer
    // 038 onDecide                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 ViewModel                                ModelClassType ProfileSupportCharaSelectViewModel ProfileSupportCharaSelectViewModel ProfileSupportCharaSelectViewModel Pointer
    // 050 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfileSupportCharaSelectPopupView : DataModel
    {
        public ProfileSupportCharaSelectGridView?       GridView                                { get; set; }
        public FilterAndSortView?                       SortFilterView                          { get; set; }
        public UISwitch?                                SortSwitch                              { get; set; }
        public ProfileSupportCharaSelectViewModel?      ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProfileSupportCharaSelectPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileSupportCharaSelectPopupView() { Pointer= p0 };

            value.GridView                                  = GetObject<ProfileSupportCharaSelectGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileSupportCharaSelectGridView.FromPointer); // 0x20 GridView                    ( ModelClassType ProfileSupportCharaSelectGridView ProfileSupportCharaSelectGridView ProfileSupportCharaSelectGridView Pointer )
            value.SortFilterView                            = GetObject<FilterAndSortView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0x28 SortFilterView              ( ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.SortSwitch                                = GetObject<UISwitch>(new IntPtr(p + 0x030), ReversePrism.DataModels.UISwitch.FromPointer); // 0x30 SortSwitch                  ( ModelClassType UISwitch UISwitch UISwitch Pointer )
            value.ViewModel                                 = GetObject<ProfileSupportCharaSelectViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProfileSupportCharaSelectViewModel.FromPointer); // 0x48 ViewModel                   ( ModelClassType ProfileSupportCharaSelectViewModel ProfileSupportCharaSelectViewModel ProfileSupportCharaSelectViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x50 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
