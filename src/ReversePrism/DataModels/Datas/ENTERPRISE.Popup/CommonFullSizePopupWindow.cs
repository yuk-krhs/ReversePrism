using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 EaseType                                 000186716C50 ModelEnumType Ease Ease Ease Int32
    // 094 DurationSecond                           0001866656B0 ModelPrimitiveType float float float Single
    // 098 StartScale                               0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0A8 TouchBlockerObject                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0B0 TitleObject                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0B8 TitleText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C0 HelpButton                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0C8 BackButtonObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0D0 BackButton                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    public partial class CommonFullSizePopupWindow
    {
        public Ease                                     EaseType                                { get; set; }
        public float                                    DurationSecond                          { get; set; }
        public Vector3                                  StartScale                              { get; set; }
        public GameObject?                              TouchBlockerObject                      { get; set; }
        public GameObject?                              TitleObject                             { get; set; }
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public ButtonBase?                              HelpButton                              { get; set; }
        public GameObject?                              BackButtonObject                        { get; set; }
        public ButtonBase?                              BackButton                              { get; set; }

        public static CommonFullSizePopupWindow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonFullSizePopupWindow();

            value.EaseType                                  = (Ease)GetInt32(new IntPtr(p + 0x090)); // 027004044B00 0x90 EaseType                    ( 000186716C50 ModelEnumType Ease Ease Ease Int32 )
            value.DurationSecond                            = GetSingle(new IntPtr(p + 0x094)); // 027004044B20 0x94 DurationSecond              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.StartScale                                = (Vector3)GetInt32(new IntPtr(p + 0x098)); // 027004044B40 0x98 StartScale                  ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TouchBlockerObject                        = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 027004044B60 0xA8 TouchBlockerObject          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TitleObject                               = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 027004044B80 0xB0 TitleObject                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004044BA0 0xB8 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HelpButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ButtonBase.FromPointer); // 027004044BC0 0xC0 HelpButton                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BackButtonObject                          = GetObject<GameObject>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.GameObject.FromPointer); // 027004044BE0 0xC8 BackButtonObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BackButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.ButtonBase.FromPointer); // 027004044C00 0xD0 BackButton                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
