using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharacterLayout                          ModelClassType GameObject GameObject GameObject Pointer
    // 028 ProducerLayout                           ModelClassType GameObject GameObject GameObject Pointer
    // 030 CharacterRewardIcon                      ModelClassType IntroductionRewardItemIcon IntroductionRewardItemIcon IntroductionRewardItemIcon Pointer
    // 038 ProducerRewardIcon                       ModelClassType IntroductionRewardItemIcon IntroductionRewardItemIcon IntroductionRewardItemIcon Pointer
    // 040 CharacterRibbonImage                     ModelClassType RawImage RawImage RawImage Pointer
    // 048 CharacterNameImage                       ModelClassType RawImage RawImage RawImage Pointer
    // 050 CharacterBirthDayText                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 Animator                                 ModelClassType Animator Animator Animator Pointer
    public partial class IntroductionRewardPanelView : DataModel
    {
        public GameObject?                              CharacterLayout                         { get; set; }
        public GameObject?                              ProducerLayout                          { get; set; }
        public IntroductionRewardItemIcon?              CharacterRewardIcon                     { get; set; }
        public IntroductionRewardItemIcon?              ProducerRewardIcon                      { get; set; }
        public RawImage?                                CharacterRibbonImage                    { get; set; }
        public RawImage?                                CharacterNameImage                      { get; set; }
        public UITextMeshProUGUI?                       CharacterBirthDayText                   { get; set; }
        public Animator?                                Animator                                { get; set; }

        public static IntroductionRewardPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionRewardPanelView() { Pointer= p0 };

            value.CharacterLayout                           = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 CharacterLayout             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ProducerLayout                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 ProducerLayout              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CharacterRewardIcon                       = GetObject<IntroductionRewardItemIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.IntroductionRewardItemIcon.FromPointer); // 0x30 CharacterRewardIcon         ( ModelClassType IntroductionRewardItemIcon IntroductionRewardItemIcon IntroductionRewardItemIcon Pointer )
            value.ProducerRewardIcon                        = GetObject<IntroductionRewardItemIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.IntroductionRewardItemIcon.FromPointer); // 0x38 ProducerRewardIcon          ( ModelClassType IntroductionRewardItemIcon IntroductionRewardItemIcon IntroductionRewardItemIcon Pointer )
            value.CharacterRibbonImage                      = GetObject<RawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.RawImage.FromPointer); // 0x40 CharacterRibbonImage        ( ModelClassType RawImage RawImage RawImage Pointer )
            value.CharacterNameImage                        = GetObject<RawImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.RawImage.FromPointer); // 0x48 CharacterNameImage          ( ModelClassType RawImage RawImage RawImage Pointer )
            value.CharacterBirthDayText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 CharacterBirthDayText       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x058), ReversePrism.DataModels.Animator.FromPointer); // 0x58 Animator                    ( ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}
