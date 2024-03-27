using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _variables                               Dictionary`2<ParameterExpression, LocalVariable> IL2CPP_TYPE_GENERICINST
    // 018 Frame                                    000186721110 ModelClassType InterpretedFrame InterpretedFrame InterpretedFrame Pointer
    // 020 _shadowedVars                            Stack`1<HashSet`1<ParameterExpression>> IL2CPP_TYPE_GENERICINST
    public partial class ExpressionQuoter
    {
        public InterpretedFrame?                        Frame                                   { get; set; }

        public static ExpressionQuoter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExpressionQuoter();

            value.Frame                                     = GetObject<InterpretedFrame>(new IntPtr(p + 0x018), ReversePrism.DataModels.InterpretedFrame.FromPointer); // 0270DA03A710 0x18 Frame                       ( 000186721110 ModelClassType InterpretedFrame InterpretedFrame InterpretedFrame Pointer )

            return value;
        }
    }
}
