using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypeConstructor                          ModelClassType ITypeConstructor ITypeConstructor ITypeConstructor Pointer
    public partial class TypeConstructorVisitor : DataModel
    {
        public ITypeConstructor?                        TypeConstructor                         { get; set; }

        public static TypeConstructorVisitor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeConstructorVisitor() { Pointer= p0 };

            value.TypeConstructor                           = GetObject<ITypeConstructor>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITypeConstructor.FromPointer); // 0x10 TypeConstructor             ( ModelClassType ITypeConstructor ITypeConstructor ITypeConstructor Pointer )

            return value;
        }
    }
}
