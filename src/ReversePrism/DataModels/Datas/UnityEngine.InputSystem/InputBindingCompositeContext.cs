using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_State                                  ModelClassType InputActionState InputActionState InputActionState Pointer
    // 018 M_BindingIndex                           ModelPrimitiveType int int int Int32
    public partial class InputBindingCompositeContext : DataModel
    {
        public InputActionState?                        M_State                                 { get; set; }
        public int                                      M_BindingIndex                          { get; set; }

        public static InputBindingCompositeContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputBindingCompositeContext() { Pointer= p0 };

            value.M_State                                   = GetObject<InputActionState>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputActionState.FromPointer); // 0x10 M_State                     ( ModelClassType InputActionState InputActionState InputActionState Pointer )
            value.M_BindingIndex                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_BindingIndex              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
