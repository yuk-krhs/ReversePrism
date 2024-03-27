using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 _arg0                                    <object> IL2CPP_TYPE_OBJECT
    // 020 Arg1                                     0001865CF210 ModelClassType Expression Expression Expression Pointer
    public partial class MethodCallExpression2
    {
        public Expression?                              Arg1                                    { get; set; }

        public static MethodCallExpression2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MethodCallExpression2();

            value.Arg1                                      = GetObject<Expression>(new IntPtr(p + 0x020), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F7A8D8 0x20 Arg1                        ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
