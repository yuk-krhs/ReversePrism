using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Variable                                 00018671C880 ModelClassType ParameterExpression ParameterExpression ParameterExpression Pointer
    // 018 Test                                     0001866936B0 ModelClassType Type Type Type Pointer
    // 020 Body                                     0001865CF210 ModelClassType Expression Expression Expression Pointer
    // 028 Filter                                   0001865CF210 ModelClassType Expression Expression Expression Pointer
    public partial class CatchBlock : DataModel
    {
        public ParameterExpression?                     Variable                                { get; set; }
        public Type?                                    Test                                    { get; set; }
        public Expression?                              Body                                    { get; set; }
        public Expression?                              Filter                                  { get; set; }

        public static CatchBlock? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CatchBlock() { Pointer= p0 };

            value.Variable                                  = GetObject<ParameterExpression>(new IntPtr(p + 0x010), ReversePrism.DataModels.ParameterExpression.FromPointer); // 024669F7D688 0x10 Variable                    ( 00018671C880 ModelClassType ParameterExpression ParameterExpression ParameterExpression Pointer )
            value.Test                                      = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 024669F7D6A8 0x18 Test                        ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.Body                                      = GetObject<Expression>(new IntPtr(p + 0x020), ReversePrism.DataModels.Expression.FromPointer); // 024669F7D6C8 0x20 Body                        ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )
            value.Filter                                    = GetObject<Expression>(new IntPtr(p + 0x028), ReversePrism.DataModels.Expression.FromPointer); // 024669F7D6E8 0x28 Filter                      ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
