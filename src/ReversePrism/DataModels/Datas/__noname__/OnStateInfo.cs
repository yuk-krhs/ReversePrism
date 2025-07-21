using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Animator                                 ModelClassType Animator Animator Animator Pointer
    // 018 StateInfo                                ModelEnumType AnimatorStateInfo AnimatorStateInfo AnimatorStateInfo Int32
    // 03C LayerIndex                               ModelPrimitiveType int int int Int32
    public partial class OnStateInfo : DataModel
    {
        public Animator?                                Animator                                { get; set; }
        public AnimatorStateInfo                        StateInfo                               { get; set; }
        public int                                      LayerIndex                              { get; set; }

        public static OnStateInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OnStateInfo() { Pointer= p0 };

            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x010), ReversePrism.DataModels.Animator.FromPointer); // 0x10 Animator                    ( ModelClassType Animator Animator Animator Pointer )
            value.StateInfo                                 = (AnimatorStateInfo)GetInt32(new IntPtr(p + 0x018)); // 0x18 StateInfo                   ( ModelEnumType AnimatorStateInfo AnimatorStateInfo AnimatorStateInfo Int32 )
            value.LayerIndex                                = GetInt32(new IntPtr(p + 0x03C)); // 0x3C LayerIndex                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
