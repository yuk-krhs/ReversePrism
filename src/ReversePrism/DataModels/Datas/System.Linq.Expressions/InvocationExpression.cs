using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelClassType Type Type Type Pointer
    // 018 Expression                               ModelClassType Expression Expression Expression Pointer
    public partial class InvocationExpression : DataModel
    {
        public Type?                                    Type                                    { get; set; }
        public Expression?                              Expression                              { get; set; }

        public static InvocationExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InvocationExpression() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Type                        ( ModelClassType Type Type Type Pointer )
            value.Expression                                = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0x18 Expression                  ( ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
