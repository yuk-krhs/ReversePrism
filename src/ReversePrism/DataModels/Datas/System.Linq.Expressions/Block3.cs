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
    public partial class Block3
    {
        public Expression?                              Arg1                                    { get; set; }
        public Expression?                              Arg2                                    { get; set; }

        public static Block3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Block3();

            value.Arg1                                      = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F383E8 0x18 Arg1                        ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )
            value.Arg2                                      = GetObject<Expression>(new IntPtr(p + 0x020), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F38408 0x20 Arg2                        ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
