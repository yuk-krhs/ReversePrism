using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CardImage                                ModelClassType Image Image Image Pointer
    // 028 CostText                                 ModelClassType Text Text Text Pointer
    // 030 RankIconObjects                          ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 SkillCardButton                          ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 DescriptionText                          ModelClassType Text Text Text Pointer
    // 048 ActiveImage                              ModelClassType Image Image Image Pointer
    public partial class SkillCardContent : DataModel
    {
        public Image?                                   CardImage                               { get; set; }
        public Text?                                    CostText                                { get; set; }
        public List<GameObject>?                        RankIconObjects                         { get; set; }
        public ButtonBase?                              SkillCardButton                         { get; set; }
        public Text?                                    DescriptionText                         { get; set; }
        public Image?                                   ActiveImage                             { get; set; }

        public static SkillCardContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkillCardContent() { Pointer= p0 };

            value.CardImage                                 = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0x20 CardImage                   ( ModelClassType Image Image Image Pointer )
            value.CostText                                  = GetObject<Text>(new IntPtr(p + 0x028), ReversePrism.DataModels.Text.FromPointer); // 0x28 CostText                    ( ModelClassType Text Text Text Pointer )
            value.RankIconObjects                           = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 RankIconObjects             ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.SkillCardButton                           = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x38 SkillCardButton             ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.DescriptionText                           = GetObject<Text>(new IntPtr(p + 0x040), ReversePrism.DataModels.Text.FromPointer); // 0x40 DescriptionText             ( ModelClassType Text Text Text Pointer )
            value.ActiveImage                               = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 0x48 ActiveImage                 ( ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
