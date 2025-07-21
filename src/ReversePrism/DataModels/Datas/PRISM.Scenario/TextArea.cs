using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TextTemplate                             ModelClassType GameObject GameObject GameObject Pointer
    // 028 _TextArea                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 NameText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ArrowImage                               ModelClassType GameObject GameObject GameObject Pointer
    // 040 DisplayLengthPerSecond                   ModelPrimitiveType int int int Int32
    // 044 NewLineWaitTimePerCharacter              ModelPrimitiveType float float float Single
    // 048 ProducerSpeakDuration                    ModelPrimitiveType float float float Single
    // 04C CharacterNumPerLine                      ModelPrimitiveType float float float Single
    // 000 maxLine                                  int IL2CPP_TYPE_I4
    // 050 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 058 AreaFadeDuration                         ModelPrimitiveType float float float Single
    // 05C IsDisplay                                ModelPrimitiveType bool bool bool Bool
    // 060 areaFadeTween                            TweenerCore`3<float, float, FloatOptions> IL2CPP_TYPE_GENERICINST
    // 068 TextTexture                              ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 070 TextLine                                 ModelClassListType RawImage[] RawImage[] List<RawImage> Pointer
    // 078 CountCalculater                          ModelClassType CountCalculater CountCalculater CountCalculater Pointer
    // 080 Line                                     ModelPrimitiveType int int int Int32
    // 088 ProducerSpeaker                          ModelClassType ProducerSpeaker ProducerSpeaker ProducerSpeaker Pointer
    // 090 IsAutoPlay                               ModelPrimitiveType bool bool bool Bool
    // 094 CountFrame                               ModelPrimitiveType float float float Single
    // 098 Length                                   ModelPrimitiveType int int int Int32
    // 000 fontSize                                 float IL2CPP_TYPE_R4
    // 000 uvSpan                                   float IL2CPP_TYPE_R4
    // 000 lineSpan                                 float IL2CPP_TYPE_R4
    // 000 baseY                                    float IL2CPP_TYPE_R4
    public partial class TextArea : DataModel
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
            var value   = new TextArea() { Pointer= p0 };

            value.TextTemplate                              = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 TextTemplate                ( ModelClassType GameObject GameObject GameObject Pointer )
            value._TextArea                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 _TextArea                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NameText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 NameText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ArrowImage                                = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 ArrowImage                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DisplayLengthPerSecond                    = GetInt32(new IntPtr(p + 0x040)); // 0x40 DisplayLengthPerSecond      ( ModelPrimitiveType int int int Int32 )
            value.NewLineWaitTimePerCharacter               = GetSingle(new IntPtr(p + 0x044)); // 0x44 NewLineWaitTimePerCharacter ( ModelPrimitiveType float float float Single )
            value.ProducerSpeakDuration                     = GetSingle(new IntPtr(p + 0x048)); // 0x48 ProducerSpeakDuration       ( ModelPrimitiveType float float float Single )
            value.CharacterNumPerLine                       = GetSingle(new IntPtr(p + 0x04C)); // 0x4C CharacterNumPerLine         ( ModelPrimitiveType float float float Single )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x50 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.AreaFadeDuration                          = GetSingle(new IntPtr(p + 0x058)); // 0x58 AreaFadeDuration            ( ModelPrimitiveType float float float Single )
            value.IsDisplay                                 = GetBool(new IntPtr(p + 0x05C)); // 0x5C IsDisplay                   ( ModelPrimitiveType bool bool bool Bool )
            value.TextTexture                               = GetObject<RenderTexture>(new IntPtr(p + 0x068), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x68 TextTexture                 ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.TextLine                                  = GetObjectList<RawImage>(new IntPtr(p + 0x070), ReversePrism.DataModels.RawImage.FromPointer); // 0x70 TextLine                    ( ModelClassListType RawImage[] RawImage[] List<RawImage> Pointer )
            value.CountCalculater                           = GetObject<CountCalculater>(new IntPtr(p + 0x078), ReversePrism.DataModels.CountCalculater.FromPointer); // 0x78 CountCalculater             ( ModelClassType CountCalculater CountCalculater CountCalculater Pointer )
            value.Line                                      = GetInt32(new IntPtr(p + 0x080)); // 0x80 Line                        ( ModelPrimitiveType int int int Int32 )
            value.ProducerSpeaker                           = GetObject<ProducerSpeaker>(new IntPtr(p + 0x088), ReversePrism.DataModels.ProducerSpeaker.FromPointer); // 0x88 ProducerSpeaker             ( ModelClassType ProducerSpeaker ProducerSpeaker ProducerSpeaker Pointer )
            value.IsAutoPlay                                = GetBool(new IntPtr(p + 0x090)); // 0x90 IsAutoPlay                  ( ModelPrimitiveType bool bool bool Bool )
            value.CountFrame                                = GetSingle(new IntPtr(p + 0x094)); // 0x94 CountFrame                  ( ModelPrimitiveType float float float Single )
            value.Length                                    = GetInt32(new IntPtr(p + 0x098)); // 0x98 Length                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
