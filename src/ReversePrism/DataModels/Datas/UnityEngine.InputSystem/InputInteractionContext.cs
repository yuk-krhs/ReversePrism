using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_State                                  0001866F7420 ModelClassType InputActionState InputActionState InputActionState Pointer
    // 018 M_Flags                                  000186633CB0 ModelEnumType Flags Flags Flags Int32
    // 01C M_TriggerState                           0001866F7830 ModelEnumType TriggerState TriggerState TriggerState Int32
    public partial class InputInteractionContext
    {
        public InputActionState?                        M_State                                 { get; set; }
        public Flags                                    M_Flags                                 { get; set; }
        public TriggerState                             M_TriggerState                          { get; set; }

        public static InputInteractionContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputInteractionContext();

            value.M_State                                   = GetObject<InputActionState>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputActionState.FromPointer); // 0270D7638548 0x10 M_State                     ( 0001866F7420 ModelClassType InputActionState InputActionState InputActionState Pointer )
            value.M_Flags                                   = (Flags)GetInt32(new IntPtr(p + 0x018)); // 0270D7638568 0x18 M_Flags                     ( 000186633CB0 ModelEnumType Flags Flags Flags Int32 )
            value.M_TriggerState                            = (TriggerState)GetInt32(new IntPtr(p + 0x01C)); // 0270D7638588 0x1C M_TriggerState              ( 0001866F7830 ModelEnumType TriggerState TriggerState TriggerState Int32 )

            return value;
        }
    }
}
