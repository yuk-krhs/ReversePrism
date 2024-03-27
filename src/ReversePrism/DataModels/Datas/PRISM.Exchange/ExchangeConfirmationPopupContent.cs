using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 PriceViewProductIcon                     00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 0B0 PriceText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B8 RateViewButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0C0 CountMinusButton                         0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0C8 CountMinusJumpButton                     0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0D0 CountMinButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0D8 CountPlusButton                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0E0 CountPlusJumpButton                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0E8 CountMaxButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0F0 CautionText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ExchangeConfirmationPopupContent
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
            var value   = new ExchangeConfirmationPopupContent();

            value.PriceViewProductIcon                      = GetObject<RewardItem>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.RewardItem.FromPointer); // 0270D5507B10 0xA8 PriceViewProductIcon        ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PriceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5507B30 0xB0 PriceText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RateViewButton                            = GetObject<UIButton>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5507B50 0xB8 RateViewButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CountMinusButton                          = GetObject<UIButton>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5507B70 0xC0 CountMinusButton            ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CountMinusJumpButton                      = GetObject<UIButton>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5507B90 0xC8 CountMinusJumpButton        ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CountMinButton                            = GetObject<UIButton>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5507BB0 0xD0 CountMinButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CountPlusButton                           = GetObject<UIButton>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5507BD0 0xD8 CountPlusButton             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CountPlusJumpButton                       = GetObject<UIButton>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5507BF0 0xE0 CountPlusJumpButton         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CountMaxButton                            = GetObject<UIButton>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5507C10 0xE8 CountMaxButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5507C30 0xF0 CautionText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
