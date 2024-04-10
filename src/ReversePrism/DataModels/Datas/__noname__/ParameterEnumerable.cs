using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_State                                  0001866F71F0 ModelClassType InputActionState InputActionState InputActionState Pointer
    // 018 M_Parameter                              000186620EB0 ModelEnumType ParameterOverride ParameterOverride ParameterOverride Int32
    // 090 M_MapIndex                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ParameterEnumerable : DataModel
    {
        public InputActionState?                        M_State                                 { get; set; }
        public ParameterOverride                        M_Parameter                             { get; set; }
        public int                                      M_MapIndex                              { get; set; }

        public static ParameterEnumerable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParameterEnumerable() { Pointer= p0 };

            value.M_State                                   = GetObject<InputActionState>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputActionState.FromPointer); // 0246676BFD58 0x10 M_State                     ( 0001866F71F0 ModelClassType InputActionState InputActionState InputActionState Pointer )
            value.M_Parameter                               = (ParameterOverride)GetInt32(new IntPtr(p + 0x018)); // 0246676BFD78 0x18 M_Parameter                 ( 000186620EB0 ModelEnumType ParameterOverride ParameterOverride ParameterOverride Int32 )
            value.M_MapIndex                                = GetInt32(new IntPtr(p + 0x090)); // 0246676BFD98 0x90 M_MapIndex                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
