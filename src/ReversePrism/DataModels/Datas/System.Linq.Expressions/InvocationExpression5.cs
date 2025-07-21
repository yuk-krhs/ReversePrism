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
    // 030 Arg2                                     ModelClassType Expression Expression Expression Pointer
    // 038 Arg3                                     ModelClassType Expression Expression Expression Pointer
    // 040 Arg4                                     ModelClassType Expression Expression Expression Pointer
    public partial class InvocationExpression5 : DataModel
    {
        public Expression?                              Arg1                                    { get; set; }
        public Expression?                              Arg2                                    { get; set; }
        public Expression?                              Arg3                                    { get; set; }
        public Expression?                              Arg4                                    { get; set; }

        public static InvocationExpression5? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InvocationExpression5() { Pointer= p0 };

            value.Arg1                                      = GetObject<Expression>(new IntPtr(p + 0x028), ReversePrism.DataModels.Expression.FromPointer); // 0x28 Arg1                        ( ModelClassType Expression Expression Expression Pointer )
            value.Arg2                                      = GetObject<Expression>(new IntPtr(p + 0x030), ReversePrism.DataModels.Expression.FromPointer); // 0x30 Arg2                        ( ModelClassType Expression Expression Expression Pointer )
            value.Arg3                                      = GetObject<Expression>(new IntPtr(p + 0x038), ReversePrism.DataModels.Expression.FromPointer); // 0x38 Arg3                        ( ModelClassType Expression Expression Expression Pointer )
            value.Arg4                                      = GetObject<Expression>(new IntPtr(p + 0x040), ReversePrism.DataModels.Expression.FromPointer); // 0x40 Arg4                        ( ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
