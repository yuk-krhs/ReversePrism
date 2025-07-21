using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 False                                    ModelClassType Expression Expression Expression Pointer
    public partial class FullConditionalExpression : DataModel
    {
        public Expression?                              False                                   { get; set; }

        public static FullConditionalExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FullConditionalExpression() { Pointer= p0 };

            value.False                                     = GetObject<Expression>(new IntPtr(p + 0x020), ReversePrism.DataModels.Expression.FromPointer); // 0x20 False                       ( ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
