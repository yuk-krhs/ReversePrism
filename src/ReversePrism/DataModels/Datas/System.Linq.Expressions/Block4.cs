using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _arg0                                    <object> IL2CPP_TYPE_OBJECT
    // 018 Arg1                                     ModelClassType Expression Expression Expression Pointer
    // 020 Arg2                                     ModelClassType Expression Expression Expression Pointer
    // 028 Arg3                                     ModelClassType Expression Expression Expression Pointer
    public partial class Block4 : DataModel
    {
        public Expression?                              Arg1                                    { get; set; }
        public Expression?                              Arg2                                    { get; set; }
        public Expression?                              Arg3                                    { get; set; }

        public static Block4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Block4() { Pointer= p0 };

            value.Arg1                                      = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0x18 Arg1                        ( ModelClassType Expression Expression Expression Pointer )
            value.Arg2                                      = GetObject<Expression>(new IntPtr(p + 0x020), ReversePrism.DataModels.Expression.FromPointer); // 0x20 Arg2                        ( ModelClassType Expression Expression Expression Pointer )
            value.Arg3                                      = GetObject<Expression>(new IntPtr(p + 0x028), ReversePrism.DataModels.Expression.FromPointer); // 0x28 Arg3                        ( ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
