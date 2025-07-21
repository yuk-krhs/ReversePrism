using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BuilderType                              ModelClassType Type Type Type Pointer
    public partial class AsyncMethodBuilderAttribute : DataModel
    {
        public Type?                                    BuilderType                             { get; set; }

        public static AsyncMethodBuilderAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncMethodBuilderAttribute() { Pointer= p0 };

            value.BuilderType                               = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 BuilderType                 ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
