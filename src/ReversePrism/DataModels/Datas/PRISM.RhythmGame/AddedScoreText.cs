using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EffectRoot                               ModelClassType GameObject GameObject GameObject Pointer
    // 028 Animator                                 ModelClassType Animator Animator Animator Pointer
    // 030 Clip                                     ModelClassType AnimationClip AnimationClip AnimationClip Pointer
    // 038 Texts                                    ModelClassListType TextMeshProUGUI[] TextMeshProUGUI[] List<TextMeshProUGUI> Pointer
    // 040 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 PositiveAnimationStateIndex              ModelPrimitiveType int int int Int32
    // 04C NegativeAnimationStateIndex              ModelPrimitiveType int int int Int32
    // 050 PositiveStateName                        ModelPrimitiveType string string string String
    // 058 NegativeStateName                        ModelPrimitiveType string string string String
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

            value.EffectRoot                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 EffectRoot                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 0x28 Animator                    ( ModelClassType Animator Animator Animator Pointer )
            value.Clip                                      = GetObject<AnimationClip>(new IntPtr(p + 0x030), ReversePrism.DataModels.AnimationClip.FromPointer); // 0x30 Clip                        ( ModelClassType AnimationClip AnimationClip AnimationClip Pointer )
            value.Texts                                     = GetObjectList<TextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x38 Texts                       ( ModelClassListType TextMeshProUGUI[] TextMeshProUGUI[] List<TextMeshProUGUI> Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x40 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.PositiveAnimationStateIndex               = GetInt32(new IntPtr(p + 0x048)); // 0x48 PositiveAnimationStateIndex ( ModelPrimitiveType int int int Int32 )
            value.NegativeAnimationStateIndex               = GetInt32(new IntPtr(p + 0x04C)); // 0x4C NegativeAnimationStateIndex ( ModelPrimitiveType int int int Int32 )
            value.PositiveStateName                         = GetString(new IntPtr(p + 0x050)); // 0x50 PositiveStateName           ( ModelPrimitiveType string string string String )
            value.NegativeStateName                         = GetString(new IntPtr(p + 0x058)); // 0x58 NegativeStateName           ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
