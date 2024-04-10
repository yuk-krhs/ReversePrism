using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 018 StateMachinePathHash                     0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class OnStateMachineInfo : DataModel
    {
        public Animator?                                Animator                                { get; set; }
        public int                                      StateMachinePathHash                    { get; set; }

        public static OnStateMachineInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OnStateMachineInfo() { Pointer= p0 };

            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x010), ReversePrism.DataModels.Animator.FromPointer); // 024669699210 0x10 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.StateMachinePathHash                      = GetInt32(new IntPtr(p + 0x018)); // 024669699230 0x18 StateMachinePathHash        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
