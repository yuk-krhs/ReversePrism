using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Body                                     ModelClassType Expression Expression Expression Pointer
    // 018 BreakLabel                               ModelClassType LabelTarget LabelTarget LabelTarget Pointer
    // 020 ContinueLabel                            ModelClassType LabelTarget LabelTarget LabelTarget Pointer
    public partial class LoopExpression : DataModel
    {
        public Expression?                              Body                                    { get; set; }
        public LabelTarget?                             BreakLabel                              { get; set; }
        public LabelTarget?                             ContinueLabel                           { get; set; }

        public static LoopExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoopExpression() { Pointer= p0 };

            value.Body                                      = GetObject<Expression>(new IntPtr(p + 0x010), ReversePrism.DataModels.Expression.FromPointer); // 0x10 Body                        ( ModelClassType Expression Expression Expression Pointer )
            value.BreakLabel                                = GetObject<LabelTarget>(new IntPtr(p + 0x018), ReversePrism.DataModels.LabelTarget.FromPointer); // 0x18 BreakLabel                  ( ModelClassType LabelTarget LabelTarget LabelTarget Pointer )
            value.ContinueLabel                             = GetObject<LabelTarget>(new IntPtr(p + 0x020), ReversePrism.DataModels.LabelTarget.FromPointer); // 0x20 ContinueLabel               ( ModelClassType LabelTarget LabelTarget LabelTarget Pointer )

            return value;
        }
    }
}
