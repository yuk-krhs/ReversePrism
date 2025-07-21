using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 LiveOptionButton                         ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 060 LiveStageDetailButton                    ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 068 AutoLiveButton                           ModelClassType AutoLiveButton AutoLiveButton AutoLiveButton Pointer
    // 070 SetLBUsageButton                         ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 078 CurrentLBUsageCountText                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 EventMaxUsageCountText                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 SkipLiveButton                           ModelClassType SkipLiveButton SkipLiveButton SkipLiveButton Pointer
    // 090 EventBannerImage                         ModelClassType UIImage UIImage UIImage Pointer
    // 098 EventBannerButton                        ModelClassType UIButton UIButton UIButton Pointer
    public partial class LiveUnitConfirmationView : DataModel
    {
        public ButtonBase?                              LiveOptionButton                        { get; set; }
        public ButtonBase?                              LiveStageDetailButton                   { get; set; }
        public AutoLiveButton?                          AutoLiveButton                          { get; set; }
        public ButtonBase?                              SetLBUsageButton                        { get; set; }
        public UITextMeshProUGUI?                       CurrentLBUsageCountText                 { get; set; }
        public UITextMeshProUGUI?                       EventMaxUsageCountText                  { get; set; }
        public SkipLiveButton?                          SkipLiveButton                          { get; set; }
        public UIImage?                                 EventBannerImage                        { get; set; }
        public UIButton?                                EventBannerButton                       { get; set; }

        public static LiveUnitConfirmationView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitConfirmationView() { Pointer= p0 };

            value.LiveOptionButton                          = GetObject<ButtonBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x58 LiveOptionButton            ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.LiveStageDetailButton                     = GetObject<ButtonBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x60 LiveStageDetailButton       ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.AutoLiveButton                            = GetObject<AutoLiveButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.AutoLiveButton.FromPointer); // 0x68 AutoLiveButton              ( ModelClassType AutoLiveButton AutoLiveButton AutoLiveButton Pointer )
            value.SetLBUsageButton                          = GetObject<ButtonBase>(new IntPtr(p + 0x070), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x70 SetLBUsageButton            ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.CurrentLBUsageCountText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 CurrentLBUsageCountText     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventMaxUsageCountText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 EventMaxUsageCountText      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkipLiveButton                            = GetObject<SkipLiveButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.SkipLiveButton.FromPointer); // 0x88 SkipLiveButton              ( ModelClassType SkipLiveButton SkipLiveButton SkipLiveButton Pointer )
            value.EventBannerImage                          = GetObject<UIImage>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIImage.FromPointer); // 0x90 EventBannerImage            ( ModelClassType UIImage UIImage UIImage Pointer )
            value.EventBannerButton                         = GetObject<UIButton>(new IntPtr(p + 0x098), ReversePrism.DataModels.UIButton.FromPointer); // 0x98 EventBannerButton           ( ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
