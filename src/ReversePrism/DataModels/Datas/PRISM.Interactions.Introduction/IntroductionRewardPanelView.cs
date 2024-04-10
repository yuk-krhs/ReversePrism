using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharacterLayout                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 ProducerLayout                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 CharacterRewardIcon                      000186729A80 ModelClassType IntroductionRewardItemIcon IntroductionRewardItemIcon IntroductionRewardItemIcon Pointer
    // 038 ProducerRewardIcon                       000186729A80 ModelClassType IntroductionRewardItemIcon IntroductionRewardItemIcon IntroductionRewardItemIcon Pointer
    // 040 CharacterRibbonImage                     000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 048 CharacterNameImage                       000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 050 CharacterBirthDayText                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
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

            value.CharacterLayout                           = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 02466BCDBAA0 0x20 CharacterLayout             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ProducerLayout                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466BCDBAC0 0x28 ProducerLayout              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CharacterRewardIcon                       = GetObject<IntroductionRewardItemIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.IntroductionRewardItemIcon.FromPointer); // 02466BCDBAE0 0x30 CharacterRewardIcon         ( 000186729A80 ModelClassType IntroductionRewardItemIcon IntroductionRewardItemIcon IntroductionRewardItemIcon Pointer )
            value.ProducerRewardIcon                        = GetObject<IntroductionRewardItemIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.IntroductionRewardItemIcon.FromPointer); // 02466BCDBB00 0x38 ProducerRewardIcon          ( 000186729A80 ModelClassType IntroductionRewardItemIcon IntroductionRewardItemIcon IntroductionRewardItemIcon Pointer )
            value.CharacterRibbonImage                      = GetObject<RawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.RawImage.FromPointer); // 02466BCDBB20 0x40 CharacterRibbonImage        ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.CharacterNameImage                        = GetObject<RawImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.RawImage.FromPointer); // 02466BCDBB40 0x48 CharacterNameImage          ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.CharacterBirthDayText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BCDBB60 0x50 CharacterBirthDayText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x058), ReversePrism.DataModels.Animator.FromPointer); // 02466BCDBB80 0x58 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}
