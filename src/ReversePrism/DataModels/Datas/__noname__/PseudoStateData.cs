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
    public partial class PseudoStateData
    {
        public PseudoStates                             State                                   { get; set; }
        public bool                                     Negate                                  { get; set; }

        public static PseudoStateData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PseudoStateData();

            value.State                                     = (PseudoStates)GetInt32(new IntPtr(p + 0x010)); // 027006841270 0x10 State                       ( 0001865D8A70 ModelEnumType PseudoStates PseudoStates PseudoStates Int32 )
            value.Negate                                    = GetBool(new IntPtr(p + 0x014)); // 027006841290 0x14 Negate                      ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
