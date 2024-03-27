using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GridView                                 0001865C41E0 ModelClassType ProfileSupportCharaSelectGridView ProfileSupportCharaSelectGridView ProfileSupportCharaSelectGridView Pointer
    // 028 SortFilterView                           000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 030 SortSwitch                               0001866F44A0 ModelClassType UISwitch UISwitch UISwitch Pointer
    // 038 supportCharaDetailPopupViewFactory       PopupViewFactory`1<ISCharaDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 040 supportCharaSearchPopupFactory           PopupViewFactory`1<ISupportCharaSearchPopupView> IL2CPP_TYPE_GENERICINST
    // 048 onDecide                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 ViewModel                                0001865C5790 ModelClassType ProfileSupportCharaSelectViewModel ProfileSupportCharaSelectViewModel ProfileSupportCharaSelectViewModel Pointer
    // 060 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfileSupportCharaSelectPopupView
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
            var value   = new ProfileSupportCharaSelectPopupView();

            value.GridView                                  = GetObject<ProfileSupportCharaSelectGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileSupportCharaSelectGridView.FromPointer); // 0270DB71F048 0x20 GridView                    ( 0001865C41E0 ModelClassType ProfileSupportCharaSelectGridView ProfileSupportCharaSelectGridView ProfileSupportCharaSelectGridView Pointer )
            value.SortFilterView                            = GetObject<FilterAndSortView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0270DB71F068 0x28 SortFilterView              ( 000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.SortSwitch                                = GetObject<UISwitch>(new IntPtr(p + 0x030), ReversePrism.DataModels.UISwitch.FromPointer); // 0270DB71F088 0x30 SortSwitch                  ( 0001866F44A0 ModelClassType UISwitch UISwitch UISwitch Pointer )
            value.ViewModel                                 = GetObject<ProfileSupportCharaSelectViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProfileSupportCharaSelectViewModel.FromPointer); // 0270DB71F128 0x58 ViewModel                   ( 0001865C5790 ModelClassType ProfileSupportCharaSelectViewModel ProfileSupportCharaSelectViewModel ProfileSupportCharaSelectViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB71F148 0x60 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
