using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Right                                    0001865CF210 ModelClassType Expression Expression Expression Pointer
    // 018 Left                                     0001865CF210 ModelClassType Expression Expression Expression Pointer
    public partial class BinaryExpression
    {
        public Expression?                              Right                                   { get; set; }
        public Expression?                              Left                                    { get; set; }

        public static BinaryExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryExpression();

            value.Right                                     = GetObject<Expression>(new IntPtr(p + 0x010), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F163A8 0x10 Right                       ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )
            value.Left                                      = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F163C8 0x18 Left                        ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
