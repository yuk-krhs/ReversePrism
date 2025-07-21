using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 UnitEditCarousel                         ModelClassType LiveUnitEditCarousel LiveUnitEditCarousel LiveUnitEditCarousel Pointer
    // 080 SwitchStatusInfoDisplayButton            ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer
    // 088 TotalParameterText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 ParameterDetailButton                    ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 098 TotalParameterWarnTextObj                ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 BackgroundObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 TotalSupportBonus                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class LiveUnitConfirmationUnitEditView : DataModel
    {
        public LiveUnitEditCarousel?                    UnitEditCarousel                        { get; set; }
        public ClickNumberCountedButton?                SwitchStatusInfoDisplayButton           { get; set; }
        public UITextMeshProUGUI?                       TotalParameterText                      { get; set; }
        public ButtonBase?                              ParameterDetailButton                   { get; set; }
        public GameObject?                              TotalParameterWarnTextObj               { get; set; }
        public GameObject?                              BackgroundObject                        { get; set; }
        public UITextMeshProUGUI?                       TotalSupportBonus                       { get; set; }

        public static LiveUnitConfirmationUnitEditView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitConfirmationUnitEditView() { Pointer= p0 };

            value.UnitEditCarousel                          = GetObject<LiveUnitEditCarousel>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveUnitEditCarousel.FromPointer); // 0x78 UnitEditCarousel            ( ModelClassType LiveUnitEditCarousel LiveUnitEditCarousel LiveUnitEditCarousel Pointer )
            value.SwitchStatusInfoDisplayButton             = GetObject<ClickNumberCountedButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.ClickNumberCountedButton.FromPointer); // 0x80 SwitchStatusInfoDisplayButton ( ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer )
            value.TotalParameterText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 TotalParameterText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ParameterDetailButton                     = GetObject<ButtonBase>(new IntPtr(p + 0x090), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x90 ParameterDetailButton       ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TotalParameterWarnTextObj                 = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 TotalParameterWarnTextObj   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BackgroundObject                          = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 BackgroundObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TotalSupportBonus                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA8 TotalSupportBonus           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
