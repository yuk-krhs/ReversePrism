using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PopupPath                                string IL2CPP_TYPE_STRING
    // 060 TypeItemContentView                      ModelClassType StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView Pointer
    // 068 InfoMessageText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 SpecifiedCommercialButton                ModelClassType UIButton UIButton UIButton Pointer
    // 078 CostJewelAmountText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 HaveJewelAmountText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 HaveJewelAfterAmountText                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 ReplaceTexts                             ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 098 ShopOverlayCaller                        ModelClassType ShopOverlayCaller ShopOverlayCaller ShopOverlayCaller Pointer
    // 0A0 JewelModel                               ModelClassType JewelModel JewelModel JewelModel Pointer
    // 0A8 PopupWindow                              ModelClassType CommonPopupWindow CommonPopupWindow CommonPopupWindow Pointer
    // 0B0 EveryValueChanged                        ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class StaminaRecoverySelectJewelPopupContent : DataModel
    {
        public StaminaRecoveryTypeItemContentView?      TypeItemContentView                     { get; set; }
        public UITextMeshProUGUI?                       InfoMessageText                         { get; set; }
        public UIButton?                                SpecifiedCommercialButton               { get; set; }
        public UITextMeshProUGUI?                       CostJewelAmountText                     { get; set; }
        public UITextMeshProUGUI?                       HaveJewelAmountText                     { get; set; }
        public UITextMeshProUGUI?                       HaveJewelAfterAmountText                { get; set; }
        public List<UITextMeshProUGUI>?                 ReplaceTexts                            { get; set; }
        public ShopOverlayCaller?                       ShopOverlayCaller                       { get; set; }
        public JewelModel?                              JewelModel                              { get; set; }
        public CommonPopupWindow?                       PopupWindow                             { get; set; }
        public IDisposable?                             EveryValueChanged                       { get; set; }

        public static StaminaRecoverySelectJewelPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoverySelectJewelPopupContent() { Pointer= p0 };

            value.TypeItemContentView                       = GetObject<StaminaRecoveryTypeItemContentView>(new IntPtr(p + 0x060), ReversePrism.DataModels.StaminaRecoveryTypeItemContentView.FromPointer); // 0x60 TypeItemContentView         ( ModelClassType StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView Pointer )
            value.InfoMessageText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 InfoMessageText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SpecifiedCommercialButton                 = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 SpecifiedCommercialButton   ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CostJewelAmountText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 CostJewelAmountText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HaveJewelAmountText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 HaveJewelAmountText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HaveJewelAfterAmountText                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 HaveJewelAfterAmountText    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ReplaceTexts                              = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x90 ReplaceTexts                ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.ShopOverlayCaller                         = GetObject<ShopOverlayCaller>(new IntPtr(p + 0x098), ReversePrism.DataModels.ShopOverlayCaller.FromPointer); // 0x98 ShopOverlayCaller           ( ModelClassType ShopOverlayCaller ShopOverlayCaller ShopOverlayCaller Pointer )
            value.JewelModel                                = GetObject<JewelModel>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.JewelModel.FromPointer); // 0xA0 JewelModel                  ( ModelClassType JewelModel JewelModel JewelModel Pointer )
            value.PopupWindow                               = GetObject<CommonPopupWindow>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.CommonPopupWindow.FromPointer); // 0xA8 PopupWindow                 ( ModelClassType CommonPopupWindow CommonPopupWindow CommonPopupWindow Pointer )
            value.EveryValueChanged                         = GetObject<IDisposable>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IDisposable.FromPointer); // 0xB0 EveryValueChanged           ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
