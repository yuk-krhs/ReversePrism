using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MobileButton                             0001866D2070 ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer
    // 028 NewsButton                               0001866D2070 ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer
    // 030 MissionButton                            0001866D2070 ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer
    // 038 PresentButton                            0001866D2070 ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer
    // 040 ExchangeButton                           0001866D2070 ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer
    public partial class HomeSubFooterPanelView : DataModel
    {
        public HomeSubFooterButton?                     MobileButton                            { get; set; }
        public HomeSubFooterButton?                     NewsButton                              { get; set; }
        public HomeSubFooterButton?                     MissionButton                           { get; set; }
        public HomeSubFooterButton?                     PresentButton                           { get; set; }
        public HomeSubFooterButton?                     ExchangeButton                          { get; set; }

        public static HomeSubFooterPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSubFooterPanelView() { Pointer= p0 };

            value.MobileButton                              = GetObject<HomeSubFooterButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeSubFooterButton.FromPointer); // 0245A4FA7370 0x20 MobileButton                ( 0001866D2070 ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer )
            value.NewsButton                                = GetObject<HomeSubFooterButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.HomeSubFooterButton.FromPointer); // 0245A4FA7390 0x28 NewsButton                  ( 0001866D2070 ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer )
            value.MissionButton                             = GetObject<HomeSubFooterButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.HomeSubFooterButton.FromPointer); // 0245A4FA73B0 0x30 MissionButton               ( 0001866D2070 ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer )
            value.PresentButton                             = GetObject<HomeSubFooterButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.HomeSubFooterButton.FromPointer); // 0245A4FA73D0 0x38 PresentButton               ( 0001866D2070 ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer )
            value.ExchangeButton                            = GetObject<HomeSubFooterButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.HomeSubFooterButton.FromPointer); // 0245A4FA73F0 0x40 ExchangeButton              ( 0001866D2070 ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer )

            return value;
        }
    }
}
