using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Digits                                   int IL2CPP_TYPE_I4
    // 048 Image                                    ModelClassType Image Image Image Pointer
    // 050 SkillEffectObjects                       ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 058 CurrentScoreText                         ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 060 GaugeSprites                             ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 068 CurrentScore                             ModelPrimitiveType int int int Int32
    // 070 ScoreTextFormats                         ModelPrimitiveListType string[] string[] List<string> Pointer
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

            value.Image                                     = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 0x48 Image                       ( ModelClassType Image Image Image Pointer )
            value.SkillEffectObjects                        = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 SkillEffectObjects          ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CurrentScoreText                          = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x58 CurrentScoreText            ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.GaugeSprites                              = GetObjectList<Sprite>(new IntPtr(p + 0x060), ReversePrism.DataModels.Sprite.FromPointer); // 0x60 GaugeSprites                ( ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.CurrentScore                              = GetInt32(new IntPtr(p + 0x068)); // 0x68 CurrentScore                ( ModelPrimitiveType int int int Int32 )
            value.ScoreTextFormats                          = GetStringList(new IntPtr(p + 0x070)); // 0x70 ScoreTextFormats            ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
