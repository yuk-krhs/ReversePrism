using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Operand                                  0001865CF210 ModelClassType Expression Expression Expression Pointer
    // 018 _hoistedVariables                        Dictionary`2<ParameterExpression, LocalVariable> IL2CPP_TYPE_GENERICINST
    public partial class QuoteInstruction
    {
        public Expression?                              Operand                                 { get; set; }

        public static QuoteInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QuoteInstruction();

            value.Operand                                   = GetObject<Expression>(new IntPtr(p + 0x010), ReversePrism.DataModels.Expression.FromPointer); // 0270DA03CC20 0x10 Operand                     ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
