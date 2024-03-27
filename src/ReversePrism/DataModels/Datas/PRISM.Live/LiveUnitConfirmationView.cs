using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 LiveOptionButton                         000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 058 LiveStageDetailButton                    000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 060 AutoLiveButton                           0001867266F0 ModelClassType AutoLiveButton AutoLiveButton AutoLiveButton Pointer
    // 068 SetLBUsageButton                         000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 070 CurrentLBUsageCountText                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 EventMaxUsageCountText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 SkipLiveButton                           0001865157F0 ModelClassType SkipLiveButton SkipLiveButton SkipLiveButton Pointer
    public partial class LiveUnitConfirmationView
    {
        public ButtonBase?                              LiveOptionButton                        { get; set; }
        public ButtonBase?                              LiveStageDetailButton                   { get; set; }
        public AutoLiveButton?                          AutoLiveButton                          { get; set; }
        public ButtonBase?                              SetLBUsageButton                        { get; set; }
        public UITextMeshProUGUI?                       CurrentLBUsageCountText                 { get; set; }
        public UITextMeshProUGUI?                       EventMaxUsageCountText                  { get; set; }
        public SkipLiveButton?                          SkipLiveButton                          { get; set; }

        public static LiveUnitConfirmationView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitConfirmationView();

            value.LiveOptionButton                          = GetObject<ButtonBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D52A3BA0 0x50 LiveOptionButton            ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.LiveStageDetailButton                     = GetObject<ButtonBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D52A3BC0 0x58 LiveStageDetailButton       ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.AutoLiveButton                            = GetObject<AutoLiveButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.AutoLiveButton.FromPointer); // 0270D52A3BE0 0x60 AutoLiveButton              ( 0001867266F0 ModelClassType AutoLiveButton AutoLiveButton AutoLiveButton Pointer )
            value.SetLBUsageButton                          = GetObject<ButtonBase>(new IntPtr(p + 0x068), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D52A3C00 0x68 SetLBUsageButton            ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.CurrentLBUsageCountText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52A3C20 0x70 CurrentLBUsageCountText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventMaxUsageCountText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52A3C40 0x78 EventMaxUsageCountText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkipLiveButton                            = GetObject<SkipLiveButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.SkipLiveButton.FromPointer); // 0270D52A3C60 0x80 SkipLiveButton              ( 0001865157F0 ModelClassType SkipLiveButton SkipLiveButton SkipLiveButton Pointer )

            return value;
        }
    }
}
