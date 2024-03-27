using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Expression                               0001865CF210 ModelClassType Expression Expression Expression Pointer
    public partial class MemberExpression
    {
        public Expression?                              Expression                              { get; set; }

        public static MemberExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemberExpression();

            value.Expression                                = GetObject<Expression>(new IntPtr(p + 0x010), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F33FB8 0x10 Expression                  ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
