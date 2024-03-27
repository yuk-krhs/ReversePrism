using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   000186777830 ModelClassType LabelTarget LabelTarget LabelTarget Pointer
    // 018 DefaultValue                             0001865CF210 ModelClassType Expression Expression Expression Pointer
    public partial class LabelExpression
    {
        public LabelTarget?                             Target                                  { get; set; }
        public Expression?                              DefaultValue                            { get; set; }

        public static LabelExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LabelExpression();

            value.Target                                    = GetObject<LabelTarget>(new IntPtr(p + 0x010), ReversePrism.DataModels.LabelTarget.FromPointer); // 0270D9F31F20 0x10 Target                      ( 000186777830 ModelClassType LabelTarget LabelTarget LabelTarget Pointer )
            value.DefaultValue                              = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F31F40 0x18 DefaultValue                ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
