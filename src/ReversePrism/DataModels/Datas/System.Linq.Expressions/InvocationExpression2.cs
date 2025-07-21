using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 _arg0                                    <object> IL2CPP_TYPE_OBJECT
    // 028 Arg1                                     ModelClassType Expression Expression Expression Pointer
    public partial class InvocationExpression2 : DataModel
    {
        public Expression?                              Arg1                                    { get; set; }

        public static InvocationExpression2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InvocationExpression2() { Pointer= p0 };

            value.Arg1                                      = GetObject<Expression>(new IntPtr(p + 0x028), ReversePrism.DataModels.Expression.FromPointer); // 0x28 Arg1                        ( ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
