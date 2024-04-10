using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Asset                                  0001866F4E30 ModelClassType InputActionAsset InputActionAsset InputActionAsset Pointer
    // 020 M_ActionId                               000186671BA0 ModelPrimitiveType string string string String
    // 028 M_Action                                 0001865E8580 ModelClassType InputAction InputAction InputAction Pointer
    public partial class InputActionReference : DataModel
    {
        public InputActionAsset?                        M_Asset                                 { get; set; }
        public string                                   M_ActionId                              { get; set; }
        public InputAction?                             M_Action                                { get; set; }

        public static InputActionReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputActionReference() { Pointer= p0 };

            value.M_Asset                                   = GetObject<InputActionAsset>(new IntPtr(p + 0x018), ReversePrism.DataModels.InputActionAsset.FromPointer); // 0246676D80C8 0x18 M_Asset                     ( 0001866F4E30 ModelClassType InputActionAsset InputActionAsset InputActionAsset Pointer )
            value.M_ActionId                                = GetString(new IntPtr(p + 0x020)); // 0246676D80E8 0x20 M_ActionId                  ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_Action                                  = GetObject<InputAction>(new IntPtr(p + 0x028), ReversePrism.DataModels.InputAction.FromPointer); // 0246676D8108 0x28 M_Action                    ( 0001865E8580 ModelClassType InputAction InputAction InputAction Pointer )

            return value;
        }
    }
}
