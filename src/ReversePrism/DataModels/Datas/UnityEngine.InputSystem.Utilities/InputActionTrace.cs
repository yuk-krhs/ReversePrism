using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_SubscribedToAll                        ModelPrimitiveType bool bool bool Bool
    // 011 M_OnActionChangeHooked                   ModelPrimitiveType bool bool bool Bool
    // 018 m_SubscribedActions                      InlinedArray`1<InputAction> IL2CPP_TYPE_GENERICINST
    // 030 m_SubscribedActionMaps                   InlinedArray`1<InputActionMap> IL2CPP_TYPE_GENERICINST
    // 048 M_EventBuffer                            ModelEnumType InputEventBuffer InputEventBuffer InputEventBuffer Int32
    // 068 m_ActionMapStates                        InlinedArray`1<InputActionState> IL2CPP_TYPE_GENERICINST
    // 080 m_ActionMapStateClones                   InlinedArray`1<InputActionState> IL2CPP_TYPE_GENERICINST
    // 098 m_CallbackDelegate                       Action`1<CallbackContext> IL2CPP_TYPE_GENERICINST
    // 0A0 m_ActionChangeDelegate                   Action`2<<object>, InputActionChange> IL2CPP_TYPE_GENERICINST
    public partial class InputActionTrace : DataModel
    {
        public bool                                     M_SubscribedToAll                       { get; set; }
        public bool                                     M_OnActionChangeHooked                  { get; set; }
        public InputEventBuffer                         M_EventBuffer                           { get; set; }

        public static InputActionTrace? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputActionTrace() { Pointer= p0 };

            value.M_SubscribedToAll                         = GetBool(new IntPtr(p + 0x010)); // 0x10 M_SubscribedToAll           ( ModelPrimitiveType bool bool bool Bool )
            value.M_OnActionChangeHooked                    = GetBool(new IntPtr(p + 0x011)); // 0x11 M_OnActionChangeHooked      ( ModelPrimitiveType bool bool bool Bool )
            value.M_EventBuffer                             = (InputEventBuffer)GetInt32(new IntPtr(p + 0x048)); // 0x48 M_EventBuffer               ( ModelEnumType InputEventBuffer InputEventBuffer InputEventBuffer Int32 )

            return value;
        }
    }
}
