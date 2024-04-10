using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 060 Carousel                                 0001866D8010 ModelClassType HowToPlayCarousel HowToPlayCarousel HowToPlayCarousel Pointer
    // 068 Summary                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 PreviousButton                           000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 078 NextButton                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 080 CloseButton                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 088 ResourceConfig                           0001866D9380 ModelClassType HowToPlayPopupResourceConfig HowToPlayPopupResourceConfig HowToPlayPopupResourceConfig Pointer
    public partial class HowToPlayPopupContent : DataModel
    {
        public HowToPlayCarousel?                       Carousel                                { get; set; }
        public UITextMeshProUGUI?                       Summary                                 { get; set; }
        public ButtonBase?                              PreviousButton                          { get; set; }
        public ButtonBase?                              NextButton                              { get; set; }
        public ButtonBase?                              CloseButton                             { get; set; }
        public HowToPlayPopupResourceConfig?            ResourceConfig                          { get; set; }

        public static HowToPlayPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HowToPlayPopupContent() { Pointer= p0 };

            value.Carousel                                  = GetObject<HowToPlayCarousel>(new IntPtr(p + 0x060), ReversePrism.DataModels.HowToPlayCarousel.FromPointer); // 024664CCFD60 0x60 Carousel                    ( 0001866D8010 ModelClassType HowToPlayCarousel HowToPlayCarousel HowToPlayCarousel Pointer )
            value.Summary                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664CCFD80 0x68 Summary                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PreviousButton                            = GetObject<ButtonBase>(new IntPtr(p + 0x070), ReversePrism.DataModels.ButtonBase.FromPointer); // 024664CCFDA0 0x70 PreviousButton              ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.NextButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x078), ReversePrism.DataModels.ButtonBase.FromPointer); // 024664CCFDC0 0x78 NextButton                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.CloseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x080), ReversePrism.DataModels.ButtonBase.FromPointer); // 024664CCFDE0 0x80 CloseButton                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ResourceConfig                            = GetObject<HowToPlayPopupResourceConfig>(new IntPtr(p + 0x088), ReversePrism.DataModels.HowToPlayPopupResourceConfig.FromPointer); // 024664CCFE00 0x88 ResourceConfig              ( 0001866D9380 ModelClassType HowToPlayPopupResourceConfig HowToPlayPopupResourceConfig HowToPlayPopupResourceConfig Pointer )

            return value;
        }
    }
}
