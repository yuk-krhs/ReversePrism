using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _arg0                                    <object> IL2CPP_TYPE_OBJECT
    // 018 Arg1                                     0001865CF210 ModelClassType Expression Expression Expression Pointer
    // 020 Arg2                                     0001865CF210 ModelClassType Expression Expression Expression Pointer
    // 028 Arg3                                     0001865CF210 ModelClassType Expression Expression Expression Pointer
    // 030 Arg4                                     0001865CF210 ModelClassType Expression Expression Expression Pointer
    public partial class Block5
    {
        public Expression?                              Arg1                                    { get; set; }
        public Expression?                              Arg2                                    { get; set; }
        public Expression?                              Arg3                                    { get; set; }
        public Expression?                              Arg4                                    { get; set; }

        public static Block5? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Block5();

            value.Arg1                                      = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F38940 0x18 Arg1                        ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )
            value.Arg2                                      = GetObject<Expression>(new IntPtr(p + 0x020), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F38960 0x20 Arg2                        ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )
            value.Arg3                                      = GetObject<Expression>(new IntPtr(p + 0x028), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F38980 0x28 Arg3                        ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )
            value.Arg4                                      = GetObject<Expression>(new IntPtr(p + 0x030), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F389A0 0x30 Arg4                        ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
