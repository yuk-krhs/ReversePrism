using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Test                                     0001865CF210 ModelClassType Expression Expression Expression Pointer
    // 018 IfTrue                                   0001865CF210 ModelClassType Expression Expression Expression Pointer
    public partial class ConditionalExpression : DataModel
    {
        public Expression?                              Test                                    { get; set; }
        public Expression?                              IfTrue                                  { get; set; }

        public static ConditionalExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConditionalExpression() { Pointer= p0 };

            value.Test                                      = GetObject<Expression>(new IntPtr(p + 0x010), ReversePrism.DataModels.Expression.FromPointer); // 02466879FC20 0x10 Test                        ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )
            value.IfTrue                                    = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 02466879FC40 0x18 IfTrue                      ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
