using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Instance                                 0001865CF210 ModelClassType Expression Expression Expression Pointer
    public partial class InstanceMethodCallExpression
    {
        public Expression?                              Instance                                { get; set; }

        public static InstanceMethodCallExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InstanceMethodCallExpression();

            value.Instance                                  = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F79EA8 0x18 Instance                    ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
