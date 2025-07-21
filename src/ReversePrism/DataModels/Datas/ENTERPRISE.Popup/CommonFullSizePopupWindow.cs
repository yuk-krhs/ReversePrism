using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 EaseType                                 ModelEnumType Ease Ease Ease Int32
    // 094 DurationSecond                           ModelPrimitiveType float float float Single
    // 098 StartScale                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0A8 TouchBlockerObject                       ModelClassType GameObject GameObject GameObject Pointer
    // 0B0 TitleObject                              ModelClassType GameObject GameObject GameObject Pointer
    // 0B8 TitleText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C0 HelpButton                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0C8 BackButtonObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 0D0 BackButton                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    public partial class CommonFullSizePopupWindow : DataModel
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
            var value   = new CommonFullSizePopupWindow() { Pointer= p0 };

            value.EaseType                                  = (Ease)GetInt32(new IntPtr(p + 0x090)); // 0x90 EaseType                    ( ModelEnumType Ease Ease Ease Int32 )
            value.DurationSecond                            = GetSingle(new IntPtr(p + 0x094)); // 0x94 DurationSecond              ( ModelPrimitiveType float float float Single )
            value.StartScale                                = (Vector3)GetInt32(new IntPtr(p + 0x098)); // 0x98 StartScale                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TouchBlockerObject                        = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 0xA8 TouchBlockerObject          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TitleObject                               = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 0xB0 TitleObject                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xB8 TitleText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HelpButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xC0 HelpButton                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BackButtonObject                          = GetObject<GameObject>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.GameObject.FromPointer); // 0xC8 BackButtonObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BackButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xD0 BackButton                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
