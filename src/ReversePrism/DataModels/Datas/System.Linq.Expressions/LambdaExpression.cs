using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Body                                     0001865CF210 ModelClassType Expression Expression Expression Pointer
    public partial class LambdaExpression
    {
        public Expression?                              Body                                    { get; set; }

        public static LambdaExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LambdaExpression();

            value.Body                                      = GetObject<Expression>(new IntPtr(p + 0x010), ReversePrism.DataModels.Expression.FromPointer); // 0270D766D2A0 0x10 Body                        ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
