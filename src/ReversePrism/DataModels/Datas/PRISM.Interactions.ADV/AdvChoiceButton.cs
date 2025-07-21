using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 UiText                                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 VoIcon                                   ModelClassType GameObject GameObject GameObject Pointer
    // 038 DaIcon                                   ModelClassType GameObject GameObject GameObject Pointer
    // 040 ViIcon                                   ModelClassType GameObject GameObject GameObject Pointer
    // 048 MeIcon                                   ModelClassType GameObject GameObject GameObject Pointer
    // 050 SdCharaIcon                              ModelClassType GameObject GameObject GameObject Pointer
    // 058 SdCharaImage                             ModelClassType UIImage UIImage UIImage Pointer
    public partial class AdvChoiceButton : DataModel
    {
        public ButtonBase?                              Button                                  { get; set; }
        public UITextMeshProUGUI?                       UiText                                  { get; set; }
        public GameObject?                              VoIcon                                  { get; set; }
        public GameObject?                              DaIcon                                  { get; set; }
        public GameObject?                              ViIcon                                  { get; set; }
        public GameObject?                              MeIcon                                  { get; set; }
        public GameObject?                              SdCharaIcon                             { get; set; }
        public UIImage?                                 SdCharaImage                            { get; set; }

        public static AdvChoiceButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvChoiceButton() { Pointer= p0 };

            value.Button                                    = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x20 Button                      ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.UiText                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 UiText                      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VoIcon                                    = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 VoIcon                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DaIcon                                    = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 DaIcon                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ViIcon                                    = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 ViIcon                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MeIcon                                    = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 MeIcon                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SdCharaIcon                               = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 SdCharaIcon                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SdCharaImage                              = GetObject<UIImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIImage.FromPointer); // 0x58 SdCharaImage                ( ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
