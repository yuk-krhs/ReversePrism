using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_HashMapData                            IntPtr IL2CPP_TYPE_PTR
    // 018 M_Allocator                              000186699480 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32
    public partial class NativeHashMapDispose : DataModel
    {
        public AllocatorHandle                          M_Allocator                             { get; set; }

        public static NativeHashMapDispose? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeHashMapDispose() { Pointer= p0 };

            value.M_Allocator                               = (AllocatorHandle)GetInt32(new IntPtr(p + 0x018)); // 0245A3567658 0x18 M_Allocator                 ( 000186699480 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32 )

            return value;
        }
    }
}
