using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_State                                  ModelClassType InputActionState InputActionState InputActionState Pointer
    // 018 M_Flags                                  ModelEnumType Flags Flags Flags Int32
    // 01C M_TriggerState                           ModelEnumType TriggerState TriggerState TriggerState Int32
    public partial class InputInteractionContext : DataModel
    {
        public InputActionState?                        M_State                                 { get; set; }
        public Flags                                    M_Flags                                 { get; set; }
        public TriggerState                             M_TriggerState                          { get; set; }

        public static InputInteractionContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputInteractionContext() { Pointer= p0 };

            value.M_State                                   = GetObject<InputActionState>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputActionState.FromPointer); // 0x10 M_State                     ( ModelClassType InputActionState InputActionState InputActionState Pointer )
            value.M_Flags                                   = (Flags)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Flags                     ( ModelEnumType Flags Flags Flags Int32 )
            value.M_TriggerState                            = (TriggerState)GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_TriggerState              ( ModelEnumType TriggerState TriggerState TriggerState Int32 )

            return value;
        }
    }
}
