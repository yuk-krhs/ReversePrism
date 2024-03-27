using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Success                                  000186596AF0 ModelPrimitiveType bool bool bool Bool
    // 014 TriggerPseudoMask                        0001865D8A70 ModelEnumType PseudoStates PseudoStates PseudoStates Int32
    // 018 DependencyPseudoMask                     0001865D8A70 ModelEnumType PseudoStates PseudoStates PseudoStates Int32
    public partial class MatchResultInfo
    {
        public bool                                     Success                                 { get; set; }
        public PseudoStates                             TriggerPseudoMask                       { get; set; }
        public PseudoStates                             DependencyPseudoMask                    { get; set; }

        public static MatchResultInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MatchResultInfo();

            value.Success                                   = GetBool(new IntPtr(p + 0x010)); // 0270068864C8 0x10 Success                     ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )
            value.TriggerPseudoMask                         = (PseudoStates)GetInt32(new IntPtr(p + 0x014)); // 0270068864E8 0x14 TriggerPseudoMask           ( 0001865D8A70 ModelEnumType PseudoStates PseudoStates PseudoStates Int32 )
            value.DependencyPseudoMask                      = (PseudoStates)GetInt32(new IntPtr(p + 0x018)); // 027006886508 0x18 DependencyPseudoMask        ( 0001865D8A70 ModelEnumType PseudoStates PseudoStates PseudoStates Int32 )

            return value;
        }
    }
}
