using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018656B710 ModelClassType IHomeSettingsIdolSelectPopupView IHomeSettingsIdolSelectPopupView IHomeSettingsIdolSelectPopupView Pointer
    // 018 IdolSelectViewModel                      0001866CED60 ModelClassType HomeSettingsIdolSelectViewModel HomeSettingsIdolSelectViewModel HomeSettingsIdolSelectViewModel Pointer
    public partial class HomeSettingsIdolSelectPopupPresenter
    {
        public IHomeSettingsIdolSelectPopupView?        View                                    { get; set; }
        public HomeSettingsIdolSelectViewModel?         IdolSelectViewModel                     { get; set; }

        public static HomeSettingsIdolSelectPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSettingsIdolSelectPopupPresenter();

            value.View                                      = GetObject<IHomeSettingsIdolSelectPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IHomeSettingsIdolSelectPopupView.FromPointer); // 0270D622C488 0x10 View                        ( 00018656B710 ModelClassType IHomeSettingsIdolSelectPopupView IHomeSettingsIdolSelectPopupView IHomeSettingsIdolSelectPopupView Pointer )
            value.IdolSelectViewModel                       = GetObject<HomeSettingsIdolSelectViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.HomeSettingsIdolSelectViewModel.FromPointer); // 0270D622C4A8 0x18 IdolSelectViewModel         ( 0001866CED60 ModelClassType HomeSettingsIdolSelectViewModel HomeSettingsIdolSelectViewModel HomeSettingsIdolSelectViewModel Pointer )

            return value;
        }
    }
}
