using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Text                                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 018 ReleaseEffectAnimator                    ModelClassType Animator Animator Animator Pointer
    public partial class ParameterUI : DataModel
    {
        public UITextMeshProUGUI?                       Text                                    { get; set; }
        public Animator?                                ReleaseEffectAnimator                   { get; set; }

        public static ParameterUI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParameterUI() { Pointer= p0 };

            value.Text                                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x010), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x10 Text                        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ReleaseEffectAnimator                     = GetObject<Animator>(new IntPtr(p + 0x018), ReversePrism.DataModels.Animator.FromPointer); // 0x18 ReleaseEffectAnimator       ( ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}
