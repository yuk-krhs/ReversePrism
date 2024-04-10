using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 State                                    0001865D8A70 ModelEnumType PseudoStates PseudoStates PseudoStates Int32
    // 014 Negate                                   000186596AF0 ModelPrimitiveType bool bool bool Bool
    public partial class PseudoStateData : DataModel
    {
        public PseudoStates                             State                                   { get; set; }
        public bool                                     Negate                                  { get; set; }

        public static PseudoStateData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PseudoStateData() { Pointer= p0 };

            value.State                                     = (PseudoStates)GetInt32(new IntPtr(p + 0x010)); // 0245A6803050 0x10 State                       ( 0001865D8A70 ModelEnumType PseudoStates PseudoStates PseudoStates Int32 )
            value.Negate                                    = GetBool(new IntPtr(p + 0x014)); // 0245A6803070 0x14 Negate                      ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
