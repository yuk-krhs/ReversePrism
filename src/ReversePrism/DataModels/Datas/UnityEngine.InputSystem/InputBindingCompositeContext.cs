using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_State                                  0001866F7420 ModelClassType InputActionState InputActionState InputActionState Pointer
    // 018 M_BindingIndex                           0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class InputBindingCompositeContext
    {
        public InputActionState?                        M_State                                 { get; set; }
        public int                                      M_BindingIndex                          { get; set; }

        public static InputBindingCompositeContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputBindingCompositeContext();

            value.M_State                                   = GetObject<InputActionState>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputActionState.FromPointer); // 0270D7691538 0x10 M_State                     ( 0001866F7420 ModelClassType InputActionState InputActionState InputActionState Pointer )
            value.M_BindingIndex                            = GetInt32(new IntPtr(p + 0x018)); // 0270D7691558 0x18 M_BindingIndex              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
