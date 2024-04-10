using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GridView                                 0001866CD390 ModelClassType HomeSettingsIdolSelectGridView HomeSettingsIdolSelectGridView HomeSettingsIdolSelectGridView Pointer
    // 028 PopupFrame                               0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    // 030 onCloseButtonClicked                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 onDecideButtonClicked                    Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 ViewModel                                0001866CED60 ModelClassType HomeSettingsIdolSelectViewModel HomeSettingsIdolSelectViewModel HomeSettingsIdolSelectViewModel Pointer
    public partial class HomeSettingsIdolSelectPopupView : DataModel
    {
        public HomeSettingsIdolSelectGridView?          GridView                                { get; set; }
        public IPopupFrameView?                         PopupFrame                              { get; set; }
        public HomeSettingsIdolSelectViewModel?         ViewModel                               { get; set; }

        public static HomeSettingsIdolSelectPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSettingsIdolSelectPopupView() { Pointer= p0 };

            value.GridView                                  = GetObject<HomeSettingsIdolSelectGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeSettingsIdolSelectGridView.FromPointer); // 02466B5A02A8 0x20 GridView                    ( 0001866CD390 ModelClassType HomeSettingsIdolSelectGridView HomeSettingsIdolSelectGridView HomeSettingsIdolSelectGridView Pointer )
            value.PopupFrame                                = GetObject<IPopupFrameView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B5A02C8 0x28 PopupFrame                  ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )
            value.ViewModel                                 = GetObject<HomeSettingsIdolSelectViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.HomeSettingsIdolSelectViewModel.FromPointer); // 02466B5A0328 0x40 ViewModel                   ( 0001866CED60 ModelClassType HomeSettingsIdolSelectViewModel HomeSettingsIdolSelectViewModel HomeSettingsIdolSelectViewModel Pointer )

            return value;
        }
    }
}
