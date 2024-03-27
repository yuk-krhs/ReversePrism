using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StaminaContent                           000186563E90 ModelClassType StaminaContent StaminaContent StaminaContent Pointer
    // 028 LiveBonusContent                         000186540AD0 ModelClassType LiveBonusContent LiveBonusContent LiveBonusContent Pointer
    // 030 JewelContent                             00018674A770 ModelClassType JewelContent JewelContent JewelContent Pointer
    // 038 PassContentView                          0001866C1590 ModelClassType HomeHeaderPassContentView HomeHeaderPassContentView HomeHeaderPassContentView Pointer
    // 040 LimitedSalePanelView                     0001866C21D0 ModelClassType HomeLimitedSalePanelView HomeLimitedSalePanelView HomeLimitedSalePanelView Pointer
    public partial class HomeHeaderPanelView
    {
        public StaminaContent?                          StaminaContent                          { get; set; }
        public LiveBonusContent?                        LiveBonusContent                        { get; set; }
        public JewelContent?                            JewelContent                            { get; set; }
        public HomeHeaderPassContentView?               PassContentView                         { get; set; }
        public HomeLimitedSalePanelView?                LimitedSalePanelView                    { get; set; }

        public static HomeHeaderPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeHeaderPanelView();

            value.StaminaContent                            = GetObject<StaminaContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.StaminaContent.FromPointer); // 027004F460E8 0x20 StaminaContent              ( 000186563E90 ModelClassType StaminaContent StaminaContent StaminaContent Pointer )
            value.LiveBonusContent                          = GetObject<LiveBonusContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveBonusContent.FromPointer); // 027004F46108 0x28 LiveBonusContent            ( 000186540AD0 ModelClassType LiveBonusContent LiveBonusContent LiveBonusContent Pointer )
            value.JewelContent                              = GetObject<JewelContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.JewelContent.FromPointer); // 027004F46128 0x30 JewelContent                ( 00018674A770 ModelClassType JewelContent JewelContent JewelContent Pointer )
            value.PassContentView                           = GetObject<HomeHeaderPassContentView>(new IntPtr(p + 0x038), ReversePrism.DataModels.HomeHeaderPassContentView.FromPointer); // 027004F46148 0x38 PassContentView             ( 0001866C1590 ModelClassType HomeHeaderPassContentView HomeHeaderPassContentView HomeHeaderPassContentView Pointer )
            value.LimitedSalePanelView                      = GetObject<HomeLimitedSalePanelView>(new IntPtr(p + 0x040), ReversePrism.DataModels.HomeLimitedSalePanelView.FromPointer); // 027004F46168 0x40 LimitedSalePanelView        ( 0001866C21D0 ModelClassType HomeLimitedSalePanelView HomeLimitedSalePanelView HomeLimitedSalePanelView Pointer )

            return value;
        }
    }
}
