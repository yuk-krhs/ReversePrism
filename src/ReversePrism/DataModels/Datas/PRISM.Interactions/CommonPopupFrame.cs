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
    // 020 WindowObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 028 ContentObject                            ModelClassType GameObject GameObject GameObject Pointer
    // 030 TitleText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 OutOfRangeButton                         ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 HeaderObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 048 InfoButton                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 MarkObjects                              ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 058 FooterObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 060 FooterButtons                            ModelClassListType PopupButton[] PopupButton[] List<PopupButton> Pointer
    // 068 EaseType                                 ModelEnumType Ease Ease Ease Int32
    // 06C DurationSecond                           ModelPrimitiveType float float float Single
    // 070 StartScale                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 080 MButtonInfoList                          ModelClassListType List`1<ButtonInfoParameter> List`1<ButtonInfoParameter> List<ButtonInfoParameter> Pointer
    // 088 HeaderHeight                             ModelPrimitiveType float float float Single
    // 08C FooterHeght                              ModelPrimitiveType float float float Single
    // 090 OpenSE                                   ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0A0 CloseSE                                  ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0B0 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0B8 ContentName                              ModelPrimitiveType string string string String
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
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public string                                   ContentName                             { get; set; }

        public static CommonPopupFrame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonPopupFrame() { Pointer= p0 };

            value.WindowObject                              = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 WindowObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ContentObject                             = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 ContentObject               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TitleText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.OutOfRangeButton                          = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x38 OutOfRangeButton            ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.HeaderObject                              = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 HeaderObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.InfoButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x48 InfoButton                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.MarkObjects                               = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 MarkObjects                 ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.FooterObject                              = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 FooterObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.FooterButtons                             = GetObjectList<PopupButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.PopupButton.FromPointer); // 0x60 FooterButtons               ( ModelClassListType PopupButton[] PopupButton[] List<PopupButton> Pointer )
            value.EaseType                                  = (Ease)GetInt32(new IntPtr(p + 0x068)); // 0x68 EaseType                    ( ModelEnumType Ease Ease Ease Int32 )
            value.DurationSecond                            = GetSingle(new IntPtr(p + 0x06C)); // 0x6C DurationSecond              ( ModelPrimitiveType float float float Single )
            value.StartScale                                = (Vector3)GetInt32(new IntPtr(p + 0x070)); // 0x70 StartScale                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.MButtonInfoList                           = GetObjectList<ButtonInfoParameter>(new IntPtr(p + 0x080), ReversePrism.DataModels.ButtonInfoParameter.FromPointer); // 0x80 MButtonInfoList             ( ModelClassListType List`1<ButtonInfoParameter> List`1<ButtonInfoParameter> List<ButtonInfoParameter> Pointer )
            value.HeaderHeight                              = GetSingle(new IntPtr(p + 0x088)); // 0x88 HeaderHeight                ( ModelPrimitiveType float float float Single )
            value.FooterHeght                               = GetSingle(new IntPtr(p + 0x08C)); // 0x8C FooterHeght                 ( ModelPrimitiveType float float float Single )
            value.OpenSE                                    = (SoundKey)GetInt32(new IntPtr(p + 0x090)); // 0x90 OpenSE                      ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.CloseSE                                   = (SoundKey)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 CloseSE                     ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IDisposable.FromPointer); // 0xB0 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ContentName                               = GetString(new IntPtr(p + 0x0B8)); // 0xB8 ContentName                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
