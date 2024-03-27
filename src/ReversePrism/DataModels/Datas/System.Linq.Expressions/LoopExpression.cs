using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Body                                     0001865CF210 ModelClassType Expression Expression Expression Pointer
    // 018 BreakLabel                               000186777830 ModelClassType LabelTarget LabelTarget LabelTarget Pointer
    // 020 ContinueLabel                            000186777830 ModelClassType LabelTarget LabelTarget LabelTarget Pointer
    public partial class LoopExpression
    {
        public Expression?                              Body                                    { get; set; }
        public LabelTarget?                             BreakLabel                              { get; set; }
        public LabelTarget?                             ContinueLabel                           { get; set; }

        public static LoopExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoopExpression();

            value.Body                                      = GetObject<Expression>(new IntPtr(p + 0x010), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F33AF8 0x10 Body                        ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )
            value.BreakLabel                                = GetObject<LabelTarget>(new IntPtr(p + 0x018), ReversePrism.DataModels.LabelTarget.FromPointer); // 0270D9F33B18 0x18 BreakLabel                  ( 000186777830 ModelClassType LabelTarget LabelTarget LabelTarget Pointer )
            value.ContinueLabel                             = GetObject<LabelTarget>(new IntPtr(p + 0x020), ReversePrism.DataModels.LabelTarget.FromPointer); // 0270D9F33B38 0x20 ContinueLabel               ( 000186777830 ModelClassType LabelTarget LabelTarget LabelTarget Pointer )

            return value;
        }
    }
}
