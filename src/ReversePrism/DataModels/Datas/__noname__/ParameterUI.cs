using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Text                                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 018 ReleaseEffectAnimator                    0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    public partial class ParameterUI
    {
        public UITextMeshProUGUI?                       Text                                    { get; set; }
        public Animator?                                ReleaseEffectAnimator                   { get; set; }

        public static ParameterUI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParameterUI();

            value.Text                                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x010), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5BC5ED8 0x10 Text                        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ReleaseEffectAnimator                     = GetObject<Animator>(new IntPtr(p + 0x018), ReversePrism.DataModels.Animator.FromPointer); // 0270D5BC5EF8 0x18 ReleaseEffectAnimator       ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}
