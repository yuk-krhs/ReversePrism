using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SliderView                               ModelClassType LiveBonusUsageSliderView LiveBonusUsageSliderView LiveBonusUsageSliderView Pointer
    // 028 CurrentLiveBonus                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 LiveBonusAfterConsumption                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 RemainingSkipCount                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 RemainingAutoCount                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 StartButtonOverlayUI                     ModelClassType RectTransform RectTransform RectTransform Pointer
    // 050 AutoButtonOverlayUI                      ModelClassType RectTransform RectTransform RectTransform Pointer
    // 058 HowToPlayPopupOpener                     ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 060 CurrentLBValue                           ModelPrimitiveType int int int Int32
    // 000 SkipButtonIndex                          int IL2CPP_TYPE_I4
    // 000 AutoButtonIndex                          int IL2CPP_TYPE_I4
    // 068 onClick                                  Subject`1<ValueTuple`3<SkipLiveStaminaType, int, bool>> IL2CPP_TYPE_GENERICINST
    // 070 Model                                    ModelClassType LiveUnitConfirmationModel LiveUnitConfirmationModel LiveUnitConfirmationModel Pointer
    // 078 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class SkipLiveConfirmationPopupView : DataModel
    {
        public LiveBonusUsageSliderView?                SliderView                              { get; set; }
        public UITextMeshProUGUI?                       CurrentLiveBonus                        { get; set; }
        public UITextMeshProUGUI?                       LiveBonusAfterConsumption               { get; set; }
        public UITextMeshProUGUI?                       RemainingSkipCount                      { get; set; }
        public UITextMeshProUGUI?                       RemainingAutoCount                      { get; set; }
        public RectTransform?                           StartButtonOverlayUI                    { get; set; }
        public RectTransform?                           AutoButtonOverlayUI                     { get; set; }
        public HowToPlayPopupOpener?                    HowToPlayPopupOpener                    { get; set; }
        public int                                      CurrentLBValue                          { get; set; }
        public LiveUnitConfirmationModel?               Model                                   { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static SkipLiveConfirmationPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkipLiveConfirmationPopupView() { Pointer= p0 };

            value.SliderView                                = GetObject<LiveBonusUsageSliderView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveBonusUsageSliderView.FromPointer); // 0x20 SliderView                  ( ModelClassType LiveBonusUsageSliderView LiveBonusUsageSliderView LiveBonusUsageSliderView Pointer )
            value.CurrentLiveBonus                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 CurrentLiveBonus            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LiveBonusAfterConsumption                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 LiveBonusAfterConsumption   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RemainingSkipCount                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 RemainingSkipCount          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RemainingAutoCount                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 RemainingAutoCount          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StartButtonOverlayUI                      = GetObject<RectTransform>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectTransform.FromPointer); // 0x48 StartButtonOverlayUI        ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.AutoButtonOverlayUI                       = GetObject<RectTransform>(new IntPtr(p + 0x050), ReversePrism.DataModels.RectTransform.FromPointer); // 0x50 AutoButtonOverlayUI         ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x058), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0x58 HowToPlayPopupOpener        ( ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.CurrentLBValue                            = GetInt32(new IntPtr(p + 0x060)); // 0x60 CurrentLBValue              ( ModelPrimitiveType int int int Int32 )
            value.Model                                     = GetObject<LiveUnitConfirmationModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.LiveUnitConfirmationModel.FromPointer); // 0x70 Model                       ( ModelClassType LiveUnitConfirmationModel LiveUnitConfirmationModel LiveUnitConfirmationModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x078), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x78 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
