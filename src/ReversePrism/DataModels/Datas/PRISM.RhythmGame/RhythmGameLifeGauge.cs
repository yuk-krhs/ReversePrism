using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 GaugeImage                               0001866CCDB0 ModelClassType Image Image Image Pointer
    // 050 CurrentScoreText                         0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 058 NormalGaugeSprite                        00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 060 CautionGaugeSprite                       00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 068 FrameImage                               0001866CCDB0 ModelClassType Image Image Image Pointer
    // 070 NormalFrameSprite                        00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 078 CautionFrameSprite                       00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 080 BeforeLife                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 084 AnimationStartLife                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 AnimationRenderLife                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 08C AnimationTargetLife                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 090 AnimationTime                            0001866656B0 ModelPrimitiveType float float float Single
    // 094 CurrentLerpTime                          0001866656B0 ModelPrimitiveType float float float Single
    // 098 NegativeAnimationSpeed                   000186666CB0 ModelPrimitiveType float float float Single
    // 09C PositiveAnimationSpeed                   000186666CB0 ModelPrimitiveType float float float Single
    // 0A0 IsInitialized                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A8 EasingFunction                           000186719D80 ModelClassType EasingFunction EasingFunction EasingFunction Pointer
    public partial class RhythmGameLifeGauge
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
            var value   = new RhythmGameLifeGauge();

            value.GaugeImage                                = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 0270D5054788 0x48 GaugeImage                  ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.CurrentScoreText                          = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D50547A8 0x50 CurrentScoreText            ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.NormalGaugeSprite                         = GetObject<Sprite>(new IntPtr(p + 0x058), ReversePrism.DataModels.Sprite.FromPointer); // 0270D50547C8 0x58 NormalGaugeSprite           ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.CautionGaugeSprite                        = GetObject<Sprite>(new IntPtr(p + 0x060), ReversePrism.DataModels.Sprite.FromPointer); // 0270D50547E8 0x60 CautionGaugeSprite          ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.FrameImage                                = GetObject<Image>(new IntPtr(p + 0x068), ReversePrism.DataModels.Image.FromPointer); // 0270D5054808 0x68 FrameImage                  ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.NormalFrameSprite                         = GetObject<Sprite>(new IntPtr(p + 0x070), ReversePrism.DataModels.Sprite.FromPointer); // 0270D5054828 0x70 NormalFrameSprite           ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.CautionFrameSprite                        = GetObject<Sprite>(new IntPtr(p + 0x078), ReversePrism.DataModels.Sprite.FromPointer); // 0270D5054848 0x78 CautionFrameSprite          ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.BeforeLife                                = GetInt32(new IntPtr(p + 0x080)); // 0270D5054868 0x80 BeforeLife                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AnimationStartLife                        = GetInt32(new IntPtr(p + 0x084)); // 0270D5054888 0x84 AnimationStartLife          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AnimationRenderLife                       = GetInt32(new IntPtr(p + 0x088)); // 0270D50548A8 0x88 AnimationRenderLife         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AnimationTargetLife                       = GetInt32(new IntPtr(p + 0x08C)); // 0270D50548C8 0x8C AnimationTargetLife         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AnimationTime                             = GetSingle(new IntPtr(p + 0x090)); // 0270D50548E8 0x90 AnimationTime               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CurrentLerpTime                           = GetSingle(new IntPtr(p + 0x094)); // 0270D5054908 0x94 CurrentLerpTime             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NegativeAnimationSpeed                    = GetSingle(new IntPtr(p + 0x098)); // 0270D5054928 0x98 NegativeAnimationSpeed      ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.PositiveAnimationSpeed                    = GetSingle(new IntPtr(p + 0x09C)); // 0270D5054948 0x9C PositiveAnimationSpeed      ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x0A0)); // 0270D5054968 0xA0 IsInitialized               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EasingFunction                            = GetObject<EasingFunction>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.EasingFunction.FromPointer); // 0270D5054988 0xA8 EasingFunction              ( 000186719D80 ModelClassType EasingFunction EasingFunction EasingFunction Pointer )

            return value;
        }
    }
}
