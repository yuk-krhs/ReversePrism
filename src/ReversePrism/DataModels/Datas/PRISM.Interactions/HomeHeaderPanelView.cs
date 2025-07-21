using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StaminaContent                           ModelClassType StaminaContent StaminaContent StaminaContent Pointer
    // 028 LiveBonusContent                         ModelClassType LiveBonusContent LiveBonusContent LiveBonusContent Pointer
    // 030 JewelContent                             ModelClassType JewelContent JewelContent JewelContent Pointer
    // 038 PassContentView                          ModelClassType HomeHeaderPassContentView HomeHeaderPassContentView HomeHeaderPassContentView Pointer
    // 040 ShopPerUserLimitedSalePanelView          ModelClassType HomeLimitedSalePanelView HomeLimitedSalePanelView HomeLimitedSalePanelView Pointer
    // 048 NormalLimitedSalePanelView               ModelClassType HomeLimitedSalePanelView HomeLimitedSalePanelView HomeLimitedSalePanelView Pointer
    // 050 PanelView                                ModelClassType HomeLimitedSalePanelView HomeLimitedSalePanelView HomeLimitedSalePanelView Pointer
    public partial class HomeHeaderPanelView : DataModel
    {
        public StaminaContent?                          StaminaContent                          { get; set; }
        public LiveBonusContent?                        LiveBonusContent                        { get; set; }
        public JewelContent?                            JewelContent                            { get; set; }
        public HomeHeaderPassContentView?               PassContentView                         { get; set; }
        public HomeLimitedSalePanelView?                ShopPerUserLimitedSalePanelView         { get; set; }
        public HomeLimitedSalePanelView?                NormalLimitedSalePanelView              { get; set; }
        public HomeLimitedSalePanelView?                PanelView                               { get; set; }

        public static HomeHeaderPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeHeaderPanelView() { Pointer= p0 };

            value.StaminaContent                            = GetObject<StaminaContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.StaminaContent.FromPointer); // 0x20 StaminaContent              ( ModelClassType StaminaContent StaminaContent StaminaContent Pointer )
            value.LiveBonusContent                          = GetObject<LiveBonusContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveBonusContent.FromPointer); // 0x28 LiveBonusContent            ( ModelClassType LiveBonusContent LiveBonusContent LiveBonusContent Pointer )
            value.JewelContent                              = GetObject<JewelContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.JewelContent.FromPointer); // 0x30 JewelContent                ( ModelClassType JewelContent JewelContent JewelContent Pointer )
            value.PassContentView                           = GetObject<HomeHeaderPassContentView>(new IntPtr(p + 0x038), ReversePrism.DataModels.HomeHeaderPassContentView.FromPointer); // 0x38 PassContentView             ( ModelClassType HomeHeaderPassContentView HomeHeaderPassContentView HomeHeaderPassContentView Pointer )
            value.ShopPerUserLimitedSalePanelView           = GetObject<HomeLimitedSalePanelView>(new IntPtr(p + 0x040), ReversePrism.DataModels.HomeLimitedSalePanelView.FromPointer); // 0x40 ShopPerUserLimitedSalePanelView ( ModelClassType HomeLimitedSalePanelView HomeLimitedSalePanelView HomeLimitedSalePanelView Pointer )
            value.NormalLimitedSalePanelView                = GetObject<HomeLimitedSalePanelView>(new IntPtr(p + 0x048), ReversePrism.DataModels.HomeLimitedSalePanelView.FromPointer); // 0x48 NormalLimitedSalePanelView  ( ModelClassType HomeLimitedSalePanelView HomeLimitedSalePanelView HomeLimitedSalePanelView Pointer )
            value.PanelView                                 = GetObject<HomeLimitedSalePanelView>(new IntPtr(p + 0x050), ReversePrism.DataModels.HomeLimitedSalePanelView.FromPointer); // 0x50 PanelView                   ( ModelClassType HomeLimitedSalePanelView HomeLimitedSalePanelView HomeLimitedSalePanelView Pointer )

            return value;
        }
    }
}
