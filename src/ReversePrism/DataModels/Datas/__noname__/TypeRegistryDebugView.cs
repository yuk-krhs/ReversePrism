using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 List                                     ModelClassType TypeRegistry TypeRegistry TypeRegistry Pointer
    public partial class TypeRegistryDebugView : DataModel
    {
        public TypeRegistry?                            List                                    { get; set; }

        public static TypeRegistryDebugView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeRegistryDebugView() { Pointer= p0 };

            value.List                                      = GetObject<TypeRegistry>(new IntPtr(p + 0x010), ReversePrism.DataModels.TypeRegistry.FromPointer); // 0x10 List                        ( ModelClassType TypeRegistry TypeRegistry TypeRegistry Pointer )

            return value;
        }
    }
}
