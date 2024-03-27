using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_UseReference                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 M_Action                                 0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer
    // 020 M_Reference                              0001865E9A50 ModelClassType InputActionReference InputActionReference InputActionReference Pointer
    public partial class InputActionProperty
    {
        public bool                                     M_UseReference                          { get; set; }
        public InputAction?                             M_Action                                { get; set; }
        public InputActionReference?                    M_Reference                             { get; set; }

        public static InputActionProperty? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputActionProperty();

            value.M_UseReference                            = GetBool(new IntPtr(p + 0x010)); // 0270D7670068 0x10 M_UseReference              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Action                                  = GetObject<InputAction>(new IntPtr(p + 0x018), ReversePrism.DataModels.InputAction.FromPointer); // 0270D7670088 0x18 M_Action                    ( 0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_Reference                               = GetObject<InputActionReference>(new IntPtr(p + 0x020), ReversePrism.DataModels.InputActionReference.FromPointer); // 0270D76700A8 0x20 M_Reference                 ( 0001865E9A50 ModelClassType InputActionReference InputActionReference InputActionReference Pointer )

            return value;
        }
    }
}
