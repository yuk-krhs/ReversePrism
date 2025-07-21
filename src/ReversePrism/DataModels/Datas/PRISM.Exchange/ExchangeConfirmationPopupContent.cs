using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 PriceViewProductIcon                     ModelClassType RewardItem RewardItem RewardItem Pointer
    // 0B0 PriceText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B8 RateViewButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 0C0 CountMinusButton                         ModelClassType UIButton UIButton UIButton Pointer
    // 0C8 CountMinusJumpButton                     ModelClassType UIButton UIButton UIButton Pointer
    // 0D0 CountMinButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 0D8 CountPlusButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 0E0 CountPlusJumpButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 0E8 CountMaxButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 0F0 CautionText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ExchangeConfirmationPopupContent : DataModel
    {
        public RewardItem?                              PriceViewProductIcon                    { get; set; }
        public UITextMeshProUGUI?                       PriceText                               { get; set; }
        public UIButton?                                RateViewButton                          { get; set; }
        public UIButton?                                CountMinusButton                        { get; set; }
        public UIButton?                                CountMinusJumpButton                    { get; set; }
        public UIButton?                                CountMinButton                          { get; set; }
        public UIButton?                                CountPlusButton                         { get; set; }
        public UIButton?                                CountPlusJumpButton                     { get; set; }
        public UIButton?                                CountMaxButton                          { get; set; }
        public UITextMeshProUGUI?                       CautionText                             { get; set; }

        public static ExchangeConfirmationPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeConfirmationPopupContent() { Pointer= p0 };

            value.PriceViewProductIcon                      = GetObject<RewardItem>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.RewardItem.FromPointer); // 0xA8 PriceViewProductIcon        ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PriceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xB0 PriceText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RateViewButton                            = GetObject<UIButton>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UIButton.FromPointer); // 0xB8 RateViewButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CountMinusButton                          = GetObject<UIButton>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UIButton.FromPointer); // 0xC0 CountMinusButton            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CountMinusJumpButton                      = GetObject<UIButton>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UIButton.FromPointer); // 0xC8 CountMinusJumpButton        ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CountMinButton                            = GetObject<UIButton>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UIButton.FromPointer); // 0xD0 CountMinButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CountPlusButton                           = GetObject<UIButton>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UIButton.FromPointer); // 0xD8 CountPlusButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CountPlusJumpButton                       = GetObject<UIButton>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.UIButton.FromPointer); // 0xE0 CountPlusJumpButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CountMaxButton                            = GetObject<UIButton>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.UIButton.FromPointer); // 0xE8 CountMaxButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xF0 CautionText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
