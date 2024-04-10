using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AniMessage                               0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 028 TxtMessage                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class GashaCutSceneP7 : DataModel
    {
        public Animator?                                AniMessage                              { get; set; }
        public UITextMeshProUGUI?                       TxtMessage                              { get; set; }

        public static GashaCutSceneP7? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaCutSceneP7() { Pointer= p0 };

            value.AniMessage                                = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0246653737C8 0x20 AniMessage                  ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.TxtMessage                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246653737E8 0x28 TxtMessage                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
