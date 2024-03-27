using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 028 TxtMessage                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class MovieP7
    {
        public Animator?                                Animator                                { get; set; }
        public UITextMeshProUGUI?                       TxtMessage                              { get; set; }

        public static MovieP7? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MovieP7();

            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0270DA26E838 0x20 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.TxtMessage                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA26E858 0x28 TxtMessage                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
