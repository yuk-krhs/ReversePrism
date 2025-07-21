using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GridView                                 ModelClassType HomeSettingsIdolSelectGridView HomeSettingsIdolSelectGridView HomeSettingsIdolSelectGridView Pointer
    // 028 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 030 ViewModel                                ModelClassType HomeSettingsIdolSelectViewModel HomeSettingsIdolSelectViewModel HomeSettingsIdolSelectViewModel Pointer
    // 038 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class HomeSettingsIdolSelectPopupView : DataModel
    {
        public HomeSettingsIdolSelectGridView?          GridView                                { get; set; }
        public HomeSettingsIdolSelectViewModel?         ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static HomeSettingsIdolSelectPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSettingsIdolSelectPopupView() { Pointer= p0 };

            value.GridView                                  = GetObject<HomeSettingsIdolSelectGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeSettingsIdolSelectGridView.FromPointer); // 0x20 GridView                    ( ModelClassType HomeSettingsIdolSelectGridView HomeSettingsIdolSelectGridView HomeSettingsIdolSelectGridView Pointer )
            value.ViewModel                                 = GetObject<HomeSettingsIdolSelectViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.HomeSettingsIdolSelectViewModel.FromPointer); // 0x30 ViewModel                   ( ModelClassType HomeSettingsIdolSelectViewModel HomeSettingsIdolSelectViewModel HomeSettingsIdolSelectViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x38 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
