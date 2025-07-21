using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 GaugeImage                               ModelClassType Image Image Image Pointer
    // 050 CurrentScoreText                         ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 058 NormalGaugeSprite                        ModelClassType Sprite Sprite Sprite Pointer
    // 060 CautionGaugeSprite                       ModelClassType Sprite Sprite Sprite Pointer
    // 068 FrameImage                               ModelClassType Image Image Image Pointer
    // 070 NormalFrameSprite                        ModelClassType Sprite Sprite Sprite Pointer
    // 078 CautionFrameSprite                       ModelClassType Sprite Sprite Sprite Pointer
    // 080 BeforeLife                               ModelPrimitiveType int int int Int32
    // 084 AnimationStartLife                       ModelPrimitiveType int int int Int32
    // 088 AnimationRenderLife                      ModelPrimitiveType int int int Int32
    // 08C AnimationTargetLife                      ModelPrimitiveType int int int Int32
    // 090 AnimationTime                            ModelPrimitiveType float float float Single
    // 094 CurrentLerpTime                          ModelPrimitiveType float float float Single
    // 098 NegativeAnimationSpeed                   ModelPrimitiveType float float float Single
    // 09C PositiveAnimationSpeed                   ModelPrimitiveType float float float Single
    // 0A0 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    // 0A8 EasingFunction                           ModelClassType EasingFunction EasingFunction EasingFunction Pointer
    public partial class RhythmGameLifeGauge : DataModel
    {
        public Image?                                   GaugeImage                              { get; set; }
        public TextMeshProUGUI?                         CurrentScoreText                        { get; set; }
        public Sprite?                                  NormalGaugeSprite                       { get; set; }
        public Sprite?                                  CautionGaugeSprite                      { get; set; }
        public Image?                                   FrameImage                              { get; set; }
        public Sprite?                                  NormalFrameSprite                       { get; set; }
        public Sprite?                                  CautionFrameSprite                      { get; set; }
        public int                                      BeforeLife                              { get; set; }
        public int                                      AnimationStartLife                      { get; set; }
        public int                                      AnimationRenderLife                     { get; set; }
        public int                                      AnimationTargetLife                     { get; set; }
        public float                                    AnimationTime                           { get; set; }
        public float                                    CurrentLerpTime                         { get; set; }
        public float                                    NegativeAnimationSpeed                  { get; set; }
        public float                                    PositiveAnimationSpeed                  { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public EasingFunction?                          EasingFunction                          { get; set; }

        public static RhythmGameLifeGauge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameLifeGauge() { Pointer= p0 };

            value.GaugeImage                                = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 0x48 GaugeImage                  ( ModelClassType Image Image Image Pointer )
            value.CurrentScoreText                          = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x50 CurrentScoreText            ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.NormalGaugeSprite                         = GetObject<Sprite>(new IntPtr(p + 0x058), ReversePrism.DataModels.Sprite.FromPointer); // 0x58 NormalGaugeSprite           ( ModelClassType Sprite Sprite Sprite Pointer )
            value.CautionGaugeSprite                        = GetObject<Sprite>(new IntPtr(p + 0x060), ReversePrism.DataModels.Sprite.FromPointer); // 0x60 CautionGaugeSprite          ( ModelClassType Sprite Sprite Sprite Pointer )
            value.FrameImage                                = GetObject<Image>(new IntPtr(p + 0x068), ReversePrism.DataModels.Image.FromPointer); // 0x68 FrameImage                  ( ModelClassType Image Image Image Pointer )
            value.NormalFrameSprite                         = GetObject<Sprite>(new IntPtr(p + 0x070), ReversePrism.DataModels.Sprite.FromPointer); // 0x70 NormalFrameSprite           ( ModelClassType Sprite Sprite Sprite Pointer )
            value.CautionFrameSprite                        = GetObject<Sprite>(new IntPtr(p + 0x078), ReversePrism.DataModels.Sprite.FromPointer); // 0x78 CautionFrameSprite          ( ModelClassType Sprite Sprite Sprite Pointer )
            value.BeforeLife                                = GetInt32(new IntPtr(p + 0x080)); // 0x80 BeforeLife                  ( ModelPrimitiveType int int int Int32 )
            value.AnimationStartLife                        = GetInt32(new IntPtr(p + 0x084)); // 0x84 AnimationStartLife          ( ModelPrimitiveType int int int Int32 )
            value.AnimationRenderLife                       = GetInt32(new IntPtr(p + 0x088)); // 0x88 AnimationRenderLife         ( ModelPrimitiveType int int int Int32 )
            value.AnimationTargetLife                       = GetInt32(new IntPtr(p + 0x08C)); // 0x8C AnimationTargetLife         ( ModelPrimitiveType int int int Int32 )
            value.AnimationTime                             = GetSingle(new IntPtr(p + 0x090)); // 0x90 AnimationTime               ( ModelPrimitiveType float float float Single )
            value.CurrentLerpTime                           = GetSingle(new IntPtr(p + 0x094)); // 0x94 CurrentLerpTime             ( ModelPrimitiveType float float float Single )
            value.NegativeAnimationSpeed                    = GetSingle(new IntPtr(p + 0x098)); // 0x98 NegativeAnimationSpeed      ( ModelPrimitiveType float float float Single )
            value.PositiveAnimationSpeed                    = GetSingle(new IntPtr(p + 0x09C)); // 0x9C PositiveAnimationSpeed      ( ModelPrimitiveType float float float Single )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )
            value.EasingFunction                            = GetObject<EasingFunction>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.EasingFunction.FromPointer); // 0xA8 EasingFunction              ( ModelClassType EasingFunction EasingFunction EasingFunction Pointer )

            return value;
        }
    }
}
