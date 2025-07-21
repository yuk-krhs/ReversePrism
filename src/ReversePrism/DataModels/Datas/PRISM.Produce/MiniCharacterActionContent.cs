using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ResultDisplayObject                      ModelClassType GameObject GameObject GameObject Pointer
    // 028 ResultDisplayAnimator                    ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 030 RenderMiniCharacterActionImage           ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 038 MiniCharacterActionAreaAnimator          ModelClassType Animator Animator Animator Pointer
    // 040 SuccessResultObject                      ModelClassType GameObject GameObject GameObject Pointer
    // 048 PerfectResultObject                      ModelClassType GameObject GameObject GameObject Pointer
    // 050 FailedResultObject                       ModelClassType GameObject GameObject GameObject Pointer
    // 058 MinicharaDisplayAreadRenderTexture       ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    public partial class MiniCharacterActionContent : DataModel
    {
        public GameObject?                              ResultDisplayObject                     { get; set; }
        public AnimatorWithEvent?                       ResultDisplayAnimator                   { get; set; }
        public UIRawImage?                              RenderMiniCharacterActionImage          { get; set; }
        public Animator?                                MiniCharacterActionAreaAnimator         { get; set; }
        public GameObject?                              SuccessResultObject                     { get; set; }
        public GameObject?                              PerfectResultObject                     { get; set; }
        public GameObject?                              FailedResultObject                      { get; set; }
        public RenderTexture?                           MinicharaDisplayAreadRenderTexture      { get; set; }

        public static MiniCharacterActionContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MiniCharacterActionContent() { Pointer= p0 };

            value.ResultDisplayObject                       = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 ResultDisplayObject         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ResultDisplayAnimator                     = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0x28 ResultDisplayAnimator       ( ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.RenderMiniCharacterActionImage            = GetObject<UIRawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x30 RenderMiniCharacterActionImage ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MiniCharacterActionAreaAnimator           = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 0x38 MiniCharacterActionAreaAnimator ( ModelClassType Animator Animator Animator Pointer )
            value.SuccessResultObject                       = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 SuccessResultObject         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PerfectResultObject                       = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 PerfectResultObject         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.FailedResultObject                        = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 FailedResultObject          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MinicharaDisplayAreadRenderTexture        = GetObject<RenderTexture>(new IntPtr(p + 0x058), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x58 MinicharaDisplayAreadRenderTexture ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )

            return value;
        }
    }
}
