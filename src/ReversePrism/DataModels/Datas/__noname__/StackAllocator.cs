using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_handle                                 000186699480 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32
    // 018 M_storage                                0001866CD820 ModelEnumType Block Block Block Int32
    // 038 M_top                                    0001865F79C0 ModelPrimitiveType long long long Int64
    public partial class StackAllocator
    {
        public AllocatorHandle                          M_handle                                { get; set; }
        public Block                                    M_storage                               { get; set; }
        public long                                     M_top                                   { get; set; }

        public static StackAllocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StackAllocator();

            value.M_handle                                  = (AllocatorHandle)GetInt32(new IntPtr(p + 0x010)); // 0270034D5A60 0x10 M_handle                    ( 000186699480 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32 )
            value.M_storage                                 = (Block)GetInt32(new IntPtr(p + 0x018)); // 0270034D5A80 0x18 M_storage                   ( 0001866CD820 ModelEnumType Block Block Block Int32 )
            value.M_top                                     = GetInt64(new IntPtr(p + 0x038)); // 0270034D5AA0 0x38 M_top                       ( 0001865F79C0 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
