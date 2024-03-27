using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 SliderView                               0001865424D0 ModelClassType LiveBonusUsageSliderView LiveBonusUsageSliderView LiveBonusUsageSliderView Pointer
    // 070 CurrentLiveBonus                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 LiveBonusAfterConsumption                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 RemainingSkipCount                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 RemainingAutoCount                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 StartButtonOverlayUI                     000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 098 AutoButtonOverlayUI                      000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0A0 CurrentLBValue                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SkipButtonIndex                          int IL2CPP_TYPE_I4
    // 000 AutoButtonIndex                          int IL2CPP_TYPE_I4
    public partial class SkipLiveConfirmationPopupContent
    {
        public LiveBonusUsageSliderView?                SliderView                              { get; set; }
        public UITextMeshProUGUI?                       CurrentLiveBonus                        { get; set; }
        public UITextMeshProUGUI?                       LiveBonusAfterConsumption               { get; set; }
        public UITextMeshProUGUI?                       RemainingSkipCount                      { get; set; }
        public UITextMeshProUGUI?                       RemainingAutoCount                      { get; set; }
        public RectTransform?                           StartButtonOverlayUI                    { get; set; }
        public RectTransform?                           AutoButtonOverlayUI                     { get; set; }
        public int                                      CurrentLBValue                          { get; set; }

        public static SkipLiveConfirmationPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkipLiveConfirmationPopupContent();

            value.SliderView                                = GetObject<LiveBonusUsageSliderView>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveBonusUsageSliderView.FromPointer); // 0270D5229AA8 0x68 SliderView                  ( 0001865424D0 ModelClassType LiveBonusUsageSliderView LiveBonusUsageSliderView LiveBonusUsageSliderView Pointer )
            value.CurrentLiveBonus                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5229AC8 0x70 CurrentLiveBonus            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LiveBonusAfterConsumption                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5229AE8 0x78 LiveBonusAfterConsumption   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RemainingSkipCount                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5229B08 0x80 RemainingSkipCount          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RemainingAutoCount                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5229B28 0x88 RemainingAutoCount          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StartButtonOverlayUI                      = GetObject<RectTransform>(new IntPtr(p + 0x090), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D5229B48 0x90 StartButtonOverlayUI        ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.AutoButtonOverlayUI                       = GetObject<RectTransform>(new IntPtr(p + 0x098), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D5229B68 0x98 AutoButtonOverlayUI         ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.CurrentLBValue                            = GetInt32(new IntPtr(p + 0x0A0)); // 0270D5229B88 0xA0 CurrentLBValue              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
