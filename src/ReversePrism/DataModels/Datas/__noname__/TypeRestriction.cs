using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Expression                               0001865CF210 ModelClassType Expression Expression Expression Pointer
    // 018 Type                                     0001866936B0 ModelClassType Type Type Type Pointer
    public partial class TypeRestriction
    {
        public Expression?                              Expression                              { get; set; }
        public Type?                                    Type                                    { get; set; }

        public static TypeRestriction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeRestriction();

            value.Expression                                = GetObject<Expression>(new IntPtr(p + 0x010), ReversePrism.DataModels.Expression.FromPointer); // 0270DA06C740 0x10 Expression                  ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0270DA06C760 0x18 Type                        ( 0001866936B0 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
