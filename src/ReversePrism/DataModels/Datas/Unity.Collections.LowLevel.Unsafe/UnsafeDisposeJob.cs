using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ptr                                      IntPtr IL2CPP_TYPE_PTR
    // 018 Allocator                                0001866996D0 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32
    public partial class UnsafeDisposeJob
    {
        public AllocatorHandle                          Allocator                               { get; set; }

        public static UnsafeDisposeJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeDisposeJob();

            value.Allocator                                 = (AllocatorHandle)GetInt32(new IntPtr(p + 0x018)); // 0270D0871088 0x18 Allocator                   ( 0001866996D0 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32 )

            return value;
        }
    }
}
