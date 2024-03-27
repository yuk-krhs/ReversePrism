using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 018 StateInfo                                000186587ED0 ModelEnumType AnimatorStateInfo AnimatorStateInfo AnimatorStateInfo Int32
    // 03C LayerIndex                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class OnStateInfo
    {
        public Animator?                                Animator                                { get; set; }
        public AnimatorStateInfo                        StateInfo                               { get; set; }
        public int                                      LayerIndex                              { get; set; }

        public static OnStateInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OnStateInfo();

            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x010), ReversePrism.DataModels.Animator.FromPointer); // 0270D963B538 0x10 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.StateInfo                                 = (AnimatorStateInfo)GetInt32(new IntPtr(p + 0x018)); // 0270D963B558 0x18 StateInfo                   ( 000186587ED0 ModelEnumType AnimatorStateInfo AnimatorStateInfo AnimatorStateInfo Int32 )
            value.LayerIndex                                = GetInt32(new IntPtr(p + 0x03C)); // 0270D963B578 0x3C LayerIndex                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
