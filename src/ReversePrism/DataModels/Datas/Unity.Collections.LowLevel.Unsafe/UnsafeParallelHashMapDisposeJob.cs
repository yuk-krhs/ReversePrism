using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     IntPtr IL2CPP_TYPE_PTR
    // 018 Allocator                                ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32
    public partial class UnsafeParallelHashMapDisposeJob : DataModel
    {
        public AllocatorHandle                          Allocator                               { get; set; }

        public static UnsafeParallelHashMapDisposeJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeParallelHashMapDisposeJob() { Pointer= p0 };

            value.Allocator                                 = (AllocatorHandle)GetInt32(new IntPtr(p + 0x018)); // 0x18 Allocator                   ( ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32 )

            return value;
        }
    }
}
