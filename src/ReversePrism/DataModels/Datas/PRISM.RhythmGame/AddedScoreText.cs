using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EffectRoot                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 030 Clip                                     0001866B2300 ModelClassType AnimationClip AnimationClip AnimationClip Pointer
    // 038 Texts                                    000185CAAC78 ModelClassListType TextMeshProUGUI[] TextMeshProUGUI[] List<TextMeshProUGUI> Pointer
    // 040 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 PositiveAnimationStateIndex              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C NegativeAnimationStateIndex              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 PositiveStateName                        000186671910 ModelPrimitiveType string string string String
    // 058 NegativeStateName                        000186671910 ModelPrimitiveType string string string String
    // 000 fadeAlpha                                float IL2CPP_TYPE_R4
    public partial class AddedScoreText : DataModel
    {
        public GameObject?                              EffectRoot                              { get; set; }
        public Animator?                                Animator                                { get; set; }
        public AnimationClip?                           Clip                                    { get; set; }
        public List<TextMeshProUGUI>?                   Texts                                   { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public int                                      PositiveAnimationStateIndex             { get; set; }
        public int                                      NegativeAnimationStateIndex             { get; set; }
        public string                                   PositiveStateName                       { get; set; }
        public string                                   NegativeStateName                       { get; set; }

        public static AddedScoreText? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AddedScoreText() { Pointer= p0 };

            value.EffectRoot                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 02466509B040 0x20 EffectRoot                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 02466509B060 0x28 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.Clip                                      = GetObject<AnimationClip>(new IntPtr(p + 0x030), ReversePrism.DataModels.AnimationClip.FromPointer); // 02466509B080 0x30 Clip                        ( 0001866B2300 ModelClassType AnimationClip AnimationClip AnimationClip Pointer )
            value.Texts                                     = GetObjectList<TextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 02466509B0A0 0x38 Texts                       ( 000185CAAC78 ModelClassListType TextMeshProUGUI[] TextMeshProUGUI[] List<TextMeshProUGUI> Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466509B0C0 0x40 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.PositiveAnimationStateIndex               = GetInt32(new IntPtr(p + 0x048)); // 02466509B0E0 0x48 PositiveAnimationStateIndex ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NegativeAnimationStateIndex               = GetInt32(new IntPtr(p + 0x04C)); // 02466509B100 0x4C NegativeAnimationStateIndex ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PositiveStateName                         = GetString(new IntPtr(p + 0x050)); // 02466509B120 0x50 PositiveStateName           ( 000186671910 ModelPrimitiveType string string string String )
            value.NegativeStateName                         = GetString(new IntPtr(p + 0x058)); // 02466509B140 0x58 NegativeStateName           ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
