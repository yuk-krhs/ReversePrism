using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BuilderType                              0001866936B0 ModelClassType Type Type Type Pointer
    public partial class AsyncMethodBuilderAttribute
    {
        public Type?                                    BuilderType                             { get; set; }

        public static AsyncMethodBuilderAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncMethodBuilderAttribute();

            value.BuilderType                               = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270D8B6E938 0x10 BuilderType                 ( 0001866936B0 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
