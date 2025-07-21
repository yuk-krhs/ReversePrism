using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewModel                                ModelClassType HomeSettingsViewModel HomeSettingsViewModel HomeSettingsViewModel Pointer
    public partial class HomeSettingsPopupSequencer : DataModel
    {
        public HomeSettingsViewModel?                   ViewModel                               { get; set; }

        public static HomeSettingsPopupSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSettingsPopupSequencer() { Pointer= p0 };

            value.ViewModel                                 = GetObject<HomeSettingsViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.HomeSettingsViewModel.FromPointer); // 0x10 ViewModel                   ( ModelClassType HomeSettingsViewModel HomeSettingsViewModel HomeSettingsViewModel Pointer )

            return value;
        }
    }
}
