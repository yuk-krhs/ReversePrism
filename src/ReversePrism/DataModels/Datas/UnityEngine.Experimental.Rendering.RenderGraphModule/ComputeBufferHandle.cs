using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_NullHandle                             ComputeBufferHandle IL2CPP_TYPE_VALUETYPE
    // 010 Handle                                   ModelEnumType ResourceHandle ResourceHandle ResourceHandle Int32
    public partial class ComputeBufferHandle : DataModel
    {
        public ResourceHandle                           Handle                                  { get; set; }

        public static ComputeBufferHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ComputeBufferHandle() { Pointer= p0 };

            value.Handle                                    = (ResourceHandle)GetInt32(new IntPtr(p + 0x010)); // 0x10 Handle                      ( ModelEnumType ResourceHandle ResourceHandle ResourceHandle Int32 )

            return value;
        }
    }
}
