using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 UnitEditCarousel                         00018658DD80 ModelClassType LiveUnitEditCarousel LiveUnitEditCarousel LiveUnitEditCarousel Pointer
    // 070 SwitchStatusInfoDisplayButton            0001865B3940 ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer
    // 078 TotalParameterText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 ParameterDetailButton                    000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 088 TotalSupportBonus                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class LiveUnitConfirmationUnitEditView
    {
        public LiveUnitEditCarousel?                    UnitEditCarousel                        { get; set; }
        public ClickNumberCountedButton?                SwitchStatusInfoDisplayButton           { get; set; }
        public UITextMeshProUGUI?                       TotalParameterText                      { get; set; }
        public ButtonBase?                              ParameterDetailButton                   { get; set; }
        public UITextMeshProUGUI?                       TotalSupportBonus                       { get; set; }

        public static LiveUnitConfirmationUnitEditView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitConfirmationUnitEditView();

            value.UnitEditCarousel                          = GetObject<LiveUnitEditCarousel>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveUnitEditCarousel.FromPointer); // 0270D52A3D48 0x68 UnitEditCarousel            ( 00018658DD80 ModelClassType LiveUnitEditCarousel LiveUnitEditCarousel LiveUnitEditCarousel Pointer )
            value.SwitchStatusInfoDisplayButton             = GetObject<ClickNumberCountedButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.ClickNumberCountedButton.FromPointer); // 0270D52A3D68 0x70 SwitchStatusInfoDisplayButton ( 0001865B3940 ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer )
            value.TotalParameterText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52A3D88 0x78 TotalParameterText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ParameterDetailButton                     = GetObject<ButtonBase>(new IntPtr(p + 0x080), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D52A3DA8 0x80 ParameterDetailButton       ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TotalSupportBonus                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52A3DC8 0x88 TotalSupportBonus           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
