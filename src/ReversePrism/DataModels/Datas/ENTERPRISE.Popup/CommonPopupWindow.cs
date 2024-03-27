using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 TitleText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 OutOfRangeButton                         000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0A0 TitleInfoButton                          000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0A8 OutOfRangeTouch                          000186764560 ModelEnumType PopupOutOfRangeTouch PopupOutOfRangeTouch PopupOutOfRangeTouch Int32
    // 0B0 HeaderObject                             0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 0B8 FooterObject                             0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 TouchBlockerObject                       0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 MButtonInfoList                          000185CD0638 ModelClassListType List`1<ButtonInformation> List`1<ButtonInformation> List<ButtonInformation> Pointer
    // 0D0 IsEnableClickOutOfRange                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0D8 OpenSE                                   000186536200 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0E8 CloseSE                                  000186536200 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0F8 EaseType                                 000186716C50 ModelEnumType Ease Ease Ease Int32
    // 0FC DurationSecond                           0001866656B0 ModelPrimitiveType float float float Single
    // 100 StartScale                               0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class CommonPopupWindow
    {
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public ButtonBase?                              OutOfRangeButton                        { get; set; }
        public ButtonBase?                              TitleInfoButton                         { get; set; }
        public PopupOutOfRangeTouch                     OutOfRangeTouch                         { get; set; }
        public GameObject?                              HeaderObject                            { get; set; }
        public GameObject?                              FooterObject                            { get; set; }
        public GameObject?                              TouchBlockerObject                      { get; set; }
        public List<ButtonInformation>?                 MButtonInfoList                         { get; set; }
        public bool                                     IsEnableClickOutOfRange                 { get; set; }
        public SoundKey                                 OpenSE                                  { get; set; }
        public SoundKey                                 CloseSE                                 { get; set; }
        public Ease                                     EaseType                                { get; set; }
        public float                                    DurationSecond                          { get; set; }
        public Vector3                                  StartScale                              { get; set; }

        public static CommonPopupWindow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonPopupWindow();

            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D0D4F208 0x90 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.OutOfRangeButton                          = GetObject<ButtonBase>(new IntPtr(p + 0x098), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D0D4F228 0x98 OutOfRangeButton            ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TitleInfoButton                           = GetObject<ButtonBase>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D0D4F248 0xA0 TitleInfoButton             ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.OutOfRangeTouch                           = (PopupOutOfRangeTouch)GetInt32(new IntPtr(p + 0x0A8)); // 0270D0D4F268 0xA8 OutOfRangeTouch             ( 000186764560 ModelEnumType PopupOutOfRangeTouch PopupOutOfRangeTouch PopupOutOfRangeTouch Int32 )
            value.HeaderObject                              = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 0270D0D4F288 0xB0 HeaderObject                ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.FooterObject                              = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 0270D0D4F2A8 0xB8 FooterObject                ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.TouchBlockerObject                        = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 0270D0D4F2C8 0xC0 TouchBlockerObject          ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.MButtonInfoList                           = GetObjectList<ButtonInformation>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.ButtonInformation.FromPointer); // 0270D0D4F2E8 0xC8 MButtonInfoList             ( 000185CD0638 ModelClassListType List`1<ButtonInformation> List`1<ButtonInformation> List<ButtonInformation> Pointer )
            value.IsEnableClickOutOfRange                   = GetBool(new IntPtr(p + 0x0D0)); // 0270D0D4F308 0xD0 IsEnableClickOutOfRange     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OpenSE                                    = (SoundKey)GetInt32(new IntPtr(p + 0x0D8)); // 0270D0D4F328 0xD8 OpenSE                      ( 000186536200 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.CloseSE                                   = (SoundKey)GetInt32(new IntPtr(p + 0x0E8)); // 0270D0D4F348 0xE8 CloseSE                     ( 000186536200 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EaseType                                  = (Ease)GetInt32(new IntPtr(p + 0x0F8)); // 0270D0D4F368 0xF8 EaseType                    ( 000186716C50 ModelEnumType Ease Ease Ease Int32 )
            value.DurationSecond                            = GetSingle(new IntPtr(p + 0x0FC)); // 0270D0D4F388 0xFC DurationSecond              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.StartScale                                = (Vector3)GetInt32(new IntPtr(p + 0x100)); // 0270D0D4F3A8 0x100 StartScale                  ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
