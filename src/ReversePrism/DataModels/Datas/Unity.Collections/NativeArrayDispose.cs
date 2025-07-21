using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Buffer                                 IntPtr IL2CPP_TYPE_PTR
    // 018 M_AllocatorLabel                         ModelEnumType Allocator Allocator Allocator Int32
    public partial class NativeArrayDispose : DataModel
    {
        public Allocator                                M_AllocatorLabel                        { get; set; }

        public static NativeArrayDispose? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeArrayDispose() { Pointer= p0 };

            value.M_AllocatorLabel                          = (Allocator)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_AllocatorLabel            ( ModelEnumType Allocator Allocator Allocator Int32 )

            return value;
        }
    }
}
