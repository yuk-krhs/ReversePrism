using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TextTemplate                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 _TextArea                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 NameText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ArrowImage                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 DisplayLengthPerSecond                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 NewLineWaitTimePerCharacter              0001866656B0 ModelPrimitiveType float float float Single
    // 048 ProducerSpeakDuration                    0001866656B0 ModelPrimitiveType float float float Single
    // 04C CharacterNumPerLine                      0001866656B0 ModelPrimitiveType float float float Single
    // 000 maxLine                                  int IL2CPP_TYPE_I4
    // 050 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 058 AreaFadeDuration                         0001866656B0 ModelPrimitiveType float float float Single
    // 05C IsDisplay                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 areaFadeTween                            TweenerCore`3<float, float, FloatOptions> IL2CPP_TYPE_GENERICINST
    // 068 TextTexture                              000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 070 TextLine                                 000185C9FC28 ModelClassListType RawImage[] RawImage[] List<RawImage> Pointer
    // 078 CountCalculater                          0001865F6720 ModelClassType CountCalculater CountCalculater CountCalculater Pointer
    // 080 Line                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 ProducerSpeaker                          00018659DB70 ModelClassType ProducerSpeaker ProducerSpeaker ProducerSpeaker Pointer
    // 090 IsAutoPlay                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 094 CountFrame                               0001866656B0 ModelPrimitiveType float float float Single
    // 098 Length                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 fontSize                                 float IL2CPP_TYPE_R4
    // 000 uvSpan                                   float IL2CPP_TYPE_R4
    // 000 lineSpan                                 float IL2CPP_TYPE_R4
    // 000 baseY                                    float IL2CPP_TYPE_R4
    public partial class TextArea
    {
        public GameObject?                              TextTemplate                            { get; set; }
        public UITextMeshProUGUI?                       _TextArea                               { get; set; }
        public UITextMeshProUGUI?                       NameText                                { get; set; }
        public GameObject?                              ArrowImage                              { get; set; }
        public int                                      DisplayLengthPerSecond                  { get; set; }
        public float                                    NewLineWaitTimePerCharacter             { get; set; }
        public float                                    ProducerSpeakDuration                   { get; set; }
        public float                                    CharacterNumPerLine                     { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public float                                    AreaFadeDuration                        { get; set; }
        public bool                                     IsDisplay                               { get; set; }
        public RenderTexture?                           TextTexture                             { get; set; }
        public List<RawImage>?                          TextLine                                { get; set; }
        public CountCalculater?                         CountCalculater                         { get; set; }
        public int                                      Line                                    { get; set; }
        public ProducerSpeaker?                         ProducerSpeaker                         { get; set; }
        public bool                                     IsAutoPlay                              { get; set; }
        public float                                    CountFrame                              { get; set; }
        public int                                      Length                                  { get; set; }

        public static TextArea? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextArea();

            value.TextTemplate                              = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270069916B8 0x20 TextTemplate                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value._TextArea                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270069916D8 0x28 _TextArea                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NameText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270069916F8 0x30 NameText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ArrowImage                                = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 027006991718 0x38 ArrowImage                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.DisplayLengthPerSecond                    = GetInt32(new IntPtr(p + 0x040)); // 027006991738 0x40 DisplayLengthPerSecond      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NewLineWaitTimePerCharacter               = GetSingle(new IntPtr(p + 0x044)); // 027006991758 0x44 NewLineWaitTimePerCharacter ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ProducerSpeakDuration                     = GetSingle(new IntPtr(p + 0x048)); // 027006991778 0x48 ProducerSpeakDuration       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CharacterNumPerLine                       = GetSingle(new IntPtr(p + 0x04C)); // 027006991798 0x4C CharacterNumPerLine         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270069917D8 0x50 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.AreaFadeDuration                          = GetSingle(new IntPtr(p + 0x058)); // 0270069917F8 0x58 AreaFadeDuration            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsDisplay                                 = GetBool(new IntPtr(p + 0x05C)); // 027006991818 0x5C IsDisplay                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TextTexture                               = GetObject<RenderTexture>(new IntPtr(p + 0x068), ReversePrism.DataModels.RenderTexture.FromPointer); // 027006991858 0x68 TextTexture                 ( 000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.TextLine                                  = GetObjectList<RawImage>(new IntPtr(p + 0x070), ReversePrism.DataModels.RawImage.FromPointer); // 027006991878 0x70 TextLine                    ( 000185C9FC28 ModelClassListType RawImage[] RawImage[] List<RawImage> Pointer )
            value.CountCalculater                           = GetObject<CountCalculater>(new IntPtr(p + 0x078), ReversePrism.DataModels.CountCalculater.FromPointer); // 027006991898 0x78 CountCalculater             ( 0001865F6720 ModelClassType CountCalculater CountCalculater CountCalculater Pointer )
            value.Line                                      = GetInt32(new IntPtr(p + 0x080)); // 0270069918B8 0x80 Line                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProducerSpeaker                           = GetObject<ProducerSpeaker>(new IntPtr(p + 0x088), ReversePrism.DataModels.ProducerSpeaker.FromPointer); // 0270069918D8 0x88 ProducerSpeaker             ( 00018659DB70 ModelClassType ProducerSpeaker ProducerSpeaker ProducerSpeaker Pointer )
            value.IsAutoPlay                                = GetBool(new IntPtr(p + 0x090)); // 0270069918F8 0x90 IsAutoPlay                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CountFrame                                = GetSingle(new IntPtr(p + 0x094)); // 027006991918 0x94 CountFrame                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Length                                    = GetInt32(new IntPtr(p + 0x098)); // 027006991938 0x98 Length                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
