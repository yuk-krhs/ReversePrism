using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypeConstructor                          000186653E80 ModelClassType ITypeConstructor ITypeConstructor ITypeConstructor Pointer
    public partial class TypeConstructorVisitor
    {
        public ITypeConstructor?                        TypeConstructor                         { get; set; }

        public static TypeConstructorVisitor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeConstructorVisitor();

            value.TypeConstructor                           = GetObject<ITypeConstructor>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITypeConstructor.FromPointer); // 027006958430 0x10 TypeConstructor             ( 000186653E80 ModelClassType ITypeConstructor ITypeConstructor ITypeConstructor Pointer )

            return value;
        }
    }
}
