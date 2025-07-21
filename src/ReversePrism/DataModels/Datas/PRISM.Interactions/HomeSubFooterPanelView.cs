using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MobileButton                             ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer
    // 028 NewsButton                               ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer
    // 030 MissionButton                            ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer
    // 038 PresentButton                            ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer
    // 040 ExchangeButton                           ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer
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

            value.MobileButton                              = GetObject<HomeSubFooterButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeSubFooterButton.FromPointer); // 0x20 MobileButton                ( ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer )
            value.NewsButton                                = GetObject<HomeSubFooterButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.HomeSubFooterButton.FromPointer); // 0x28 NewsButton                  ( ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer )
            value.MissionButton                             = GetObject<HomeSubFooterButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.HomeSubFooterButton.FromPointer); // 0x30 MissionButton               ( ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer )
            value.PresentButton                             = GetObject<HomeSubFooterButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.HomeSubFooterButton.FromPointer); // 0x38 PresentButton               ( ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer )
            value.ExchangeButton                            = GetObject<HomeSubFooterButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.HomeSubFooterButton.FromPointer); // 0x40 ExchangeButton              ( ModelClassType HomeSubFooterButton HomeSubFooterButton HomeSubFooterButton Pointer )

            return value;
        }
    }
}
