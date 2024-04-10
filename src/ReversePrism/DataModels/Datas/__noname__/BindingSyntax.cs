using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ActionMap                              0001866F5E10 ModelClassType InputActionMap InputActionMap InputActionMap Pointer
    // 018 M_Action                                 0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer
    // 020 M_BindingIndexInMap                      0001865F44E0 ModelPrimitiveType int int int Int32
    public partial class BindingSyntax : DataModel
    {
        public InputActionMap?                          M_ActionMap                             { get; set; }
        public InputAction?                             M_Action                                { get; set; }
        public int                                      M_BindingIndexInMap                     { get; set; }

        public static BindingSyntax? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BindingSyntax() { Pointer= p0 };

            value.M_ActionMap                               = GetObject<InputActionMap>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputActionMap.FromPointer); // 0246676D8818 0x10 M_ActionMap                 ( 0001866F5E10 ModelClassType InputActionMap InputActionMap InputActionMap Pointer )
            value.M_Action                                  = GetObject<InputAction>(new IntPtr(p + 0x018), ReversePrism.DataModels.InputAction.FromPointer); // 0246676D8838 0x18 M_Action                    ( 0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_BindingIndexInMap                       = GetInt32(new IntPtr(p + 0x020)); // 0246676D8858 0x20 M_BindingIndexInMap         ( 0001865F44E0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
