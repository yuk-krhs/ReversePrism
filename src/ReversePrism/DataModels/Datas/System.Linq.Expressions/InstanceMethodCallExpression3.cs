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
    // 030 Arg2                                     0001865CF210 ModelClassType Expression Expression Expression Pointer
    public partial class InstanceMethodCallExpression3
    {
        public Expression?                              Arg1                                    { get; set; }
        public Expression?                              Arg2                                    { get; set; }

        public static InstanceMethodCallExpression3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InstanceMethodCallExpression3();

            value.Arg1                                      = GetObject<Expression>(new IntPtr(p + 0x028), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F7BAB0 0x28 Arg1                        ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )
            value.Arg2                                      = GetObject<Expression>(new IntPtr(p + 0x030), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F7BAD0 0x30 Arg2                        ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
