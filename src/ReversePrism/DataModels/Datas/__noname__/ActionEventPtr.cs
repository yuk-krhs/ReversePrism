using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_State                                  0001866F7420 ModelClassType InputActionState InputActionState InputActionState Pointer
    // 018 m_Ptr                                    IntPtr IL2CPP_TYPE_PTR
    public partial class ActionEventPtr
    {
        public InputActionState?                        M_State                                 { get; set; }

        public static ActionEventPtr? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ActionEventPtr();

            value.M_State                                   = GetObject<InputActionState>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputActionState.FromPointer); // 0270D787B170 0x10 M_State                     ( 0001866F7420 ModelClassType InputActionState InputActionState InputActionState Pointer )

            return value;
        }
    }
}
