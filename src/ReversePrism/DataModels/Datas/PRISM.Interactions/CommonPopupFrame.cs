using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NO_HEADER_HEIGHT                         float IL2CPP_TYPE_R4
    // 000 HEADER_HEIGHT                            float IL2CPP_TYPE_R4
    // 000 NO_FOOTER_HEIGHT                         float IL2CPP_TYPE_R4
    // 000 FOOTER_HEIGHT                            float IL2CPP_TYPE_R4
    // 000 SIDE_SIZE                                float IL2CPP_TYPE_R4
    // 020 WindowObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 ContentObject                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 TitleText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 OutOfRangeButton                         000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 HeaderObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 InfoButton                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 MarkObjects                              000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 058 FooterObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 FooterButtons                            000185B9BC70 ModelClassListType PopupButton[] PopupButton[] List<PopupButton> Pointer
    // 068 EaseType                                 000186716C50 ModelEnumType Ease Ease Ease Int32
    // 06C DurationSecond                           0001866656B0 ModelPrimitiveType float float float Single
    // 070 StartScale                               0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 080 MButtonInfoList                          000185D27F88 ModelClassListType List`1<ButtonInfoParameter> List`1<ButtonInfoParameter> List<ButtonInfoParameter> Pointer
    // 088 HeaderHeight                             0001866656B0 ModelPrimitiveType float float float Single
    // 08C FooterHeght                              0001866656B0 ModelPrimitiveType float float float Single
    // 090 OpenSE                                   000186536200 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0A0 CloseSE                                  000186536200 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0B0 BackKeyObservable                        00018670D2F0 ModelClassType IBackKeyObservable IBackKeyObservable IBackKeyObservable Pointer
    // 0B8 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0C0 ContentName                              000186671910 ModelPrimitiveType string string string String
    public partial class CommonPopupFrame : DataModel
    {
        public GameObject?                              WindowObject                            { get; set; }
        public GameObject?                              ContentObject                           { get; set; }
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public ButtonBase?                              OutOfRangeButton                        { get; set; }
        public GameObject?                              HeaderObject                            { get; set; }
        public ButtonBase?                              InfoButton                              { get; set; }
        public List<GameObject>?                        MarkObjects                             { get; set; }
        public GameObject?                              FooterObject                            { get; set; }
        public List<PopupButton>?                       FooterButtons                           { get; set; }
        public Ease                                     EaseType                                { get; set; }
        public float                                    DurationSecond                          { get; set; }
        public Vector3                                  StartScale                              { get; set; }
        public List<ButtonInfoParameter>?               MButtonInfoList                         { get; set; }
        public float                                    HeaderHeight                            { get; set; }
        public float                                    FooterHeght                             { get; set; }
        public SoundKey                                 OpenSE                                  { get; set; }
        public SoundKey                                 CloseSE                                 { get; set; }
        public IBackKeyObservable?                      BackKeyObservable                       { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public string                                   ContentName                             { get; set; }

        public static CommonPopupFrame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonPopupFrame() { Pointer= p0 };

            value.WindowObject                              = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 02466B5F1138 0x20 WindowObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ContentObject                             = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466B5F1158 0x28 ContentObject               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B5F1178 0x30 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.OutOfRangeButton                          = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466B5F1198 0x38 OutOfRangeButton            ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.HeaderObject                              = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466B5F11B8 0x40 HeaderObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.InfoButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466B5F11D8 0x48 InfoButton                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.MarkObjects                               = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 02466B5F11F8 0x50 MarkObjects                 ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.FooterObject                              = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 02466B5F1218 0x58 FooterObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FooterButtons                             = GetObjectList<PopupButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.PopupButton.FromPointer); // 02466B5F1238 0x60 FooterButtons               ( 000185B9BC70 ModelClassListType PopupButton[] PopupButton[] List<PopupButton> Pointer )
            value.EaseType                                  = (Ease)GetInt32(new IntPtr(p + 0x068)); // 02466B5F1258 0x68 EaseType                    ( 000186716C50 ModelEnumType Ease Ease Ease Int32 )
            value.DurationSecond                            = GetSingle(new IntPtr(p + 0x06C)); // 02466B5F1278 0x6C DurationSecond              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.StartScale                                = (Vector3)GetInt32(new IntPtr(p + 0x070)); // 02466B5F1298 0x70 StartScale                  ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.MButtonInfoList                           = GetObjectList<ButtonInfoParameter>(new IntPtr(p + 0x080), ReversePrism.DataModels.ButtonInfoParameter.FromPointer); // 02466B5F12B8 0x80 MButtonInfoList             ( 000185D27F88 ModelClassListType List`1<ButtonInfoParameter> List`1<ButtonInfoParameter> List<ButtonInfoParameter> Pointer )
            value.HeaderHeight                              = GetSingle(new IntPtr(p + 0x088)); // 02466B5F12D8 0x88 HeaderHeight                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.FooterHeght                               = GetSingle(new IntPtr(p + 0x08C)); // 02466B5F12F8 0x8C FooterHeght                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.OpenSE                                    = (SoundKey)GetInt32(new IntPtr(p + 0x090)); // 02466B5F1318 0x90 OpenSE                      ( 000186536200 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.CloseSE                                   = (SoundKey)GetInt32(new IntPtr(p + 0x0A0)); // 02466B5F1338 0xA0 CloseSE                     ( 000186536200 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.BackKeyObservable                         = GetObject<IBackKeyObservable>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IBackKeyObservable.FromPointer); // 02466B5F1358 0xB0 BackKeyObservable           ( 00018670D2F0 ModelClassType IBackKeyObservable IBackKeyObservable IBackKeyObservable Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.IDisposable.FromPointer); // 02466B5F1378 0xB8 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ContentName                               = GetString(new IntPtr(p + 0x0C0)); // 02466B5F1398 0xC0 ContentName                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
