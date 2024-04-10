using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Digits                                   int IL2CPP_TYPE_I4
    // 048 Image                                    0001866CCDB0 ModelClassType Image Image Image Pointer
    // 050 SkillEffectObjects                       000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 058 CurrentScoreText                         0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 060 GaugeSprites                             000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 068 CurrentScore                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 ScoreTextFormats                         000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class RhythmGameScoreGauge : DataModel
    {
        public Image?                                   Image                                   { get; set; }
        public List<GameObject>?                        SkillEffectObjects                      { get; set; }
        public TextMeshProUGUI?                         CurrentScoreText                        { get; set; }
        public List<Sprite>?                            GaugeSprites                            { get; set; }
        public int                                      CurrentScore                            { get; set; }
        public List<string>?                            ScoreTextFormats                        { get; set; }

        public static RhythmGameScoreGauge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameScoreGauge() { Pointer= p0 };

            value.Image                                     = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 0246650BFC40 0x48 Image                       ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.SkillEffectObjects                        = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0246650BFC60 0x50 SkillEffectObjects          ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CurrentScoreText                          = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0246650BFC80 0x58 CurrentScoreText            ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.GaugeSprites                              = GetObjectList<Sprite>(new IntPtr(p + 0x060), ReversePrism.DataModels.Sprite.FromPointer); // 0246650BFCA0 0x60 GaugeSprites                ( 000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.CurrentScore                              = GetInt32(new IntPtr(p + 0x068)); // 0246650BFCC0 0x68 CurrentScore                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScoreTextFormats                          = GetStringList(new IntPtr(p + 0x070)); // 0246650BFCE0 0x70 ScoreTextFormats            ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
