using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 _arg0                                    <object> IL2CPP_TYPE_OBJECT
    // 028 Arg1                                     0001865CF210 ModelClassType Expression Expression Expression Pointer
    public partial class InstanceMethodCallExpression2
    {
        public Expression?                              Arg1                                    { get; set; }

        public static InstanceMethodCallExpression2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InstanceMethodCallExpression2();

            value.Arg1                                      = GetObject<Expression>(new IntPtr(p + 0x028), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F7B830 0x28 Arg1                        ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
