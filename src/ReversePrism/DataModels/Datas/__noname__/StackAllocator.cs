using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_handle                                 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32
    // 018 M_storage                                ModelEnumType Block Block Block Int32
    // 038 M_top                                    ModelPrimitiveType long long long Int64
    public partial class StackAllocator : DataModel
    {
        public AllocatorHandle                          M_handle                                { get; set; }
        public Block                                    M_storage                               { get; set; }
        public long                                     M_top                                   { get; set; }

        public static StackAllocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StackAllocator() { Pointer= p0 };

            value.M_handle                                  = (AllocatorHandle)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_handle                    ( ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32 )
            value.M_storage                                 = (Block)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_storage                   ( ModelEnumType Block Block Block Int32 )
            value.M_top                                     = GetInt64(new IntPtr(p + 0x038)); // 0x38 M_top                       ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
