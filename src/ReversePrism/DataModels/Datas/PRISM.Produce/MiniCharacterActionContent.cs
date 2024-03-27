using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ResultDisplayObject                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 ResultDisplayAnimator                    0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 030 RenderMiniCharacterActionImage           0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 038 MiniCharacterActionAreaAnimator          0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 040 SuccessResultObject                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 PerfectResultObject                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 FailedResultObject                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 MinicharaDisplayAreadRenderTexture       000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    public partial class MiniCharacterActionContent
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
            var value   = new MiniCharacterActionContent();

            value.ResultDisplayObject                       = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5D20140 0x20 ResultDisplayObject         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ResultDisplayAnimator                     = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0270D5D20160 0x28 ResultDisplayAnimator       ( 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.RenderMiniCharacterActionImage            = GetObject<UIRawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D5D20180 0x30 RenderMiniCharacterActionImage ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MiniCharacterActionAreaAnimator           = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 0270D5D201A0 0x38 MiniCharacterActionAreaAnimator ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.SuccessResultObject                       = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5D201C0 0x40 SuccessResultObject         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PerfectResultObject                       = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5D201E0 0x48 PerfectResultObject         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FailedResultObject                        = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5D20200 0x50 FailedResultObject          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MinicharaDisplayAreadRenderTexture        = GetObject<RenderTexture>(new IntPtr(p + 0x058), ReversePrism.DataModels.RenderTexture.FromPointer); // 0270D5D20220 0x58 MinicharaDisplayAreadRenderTexture ( 000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )

            return value;
        }
    }
}
