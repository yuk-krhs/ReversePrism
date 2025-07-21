using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AllocationSize                           int IL2CPP_TYPE_I4
    // 010 Allocator                                ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32
    // 018 Blocks                                   IntPtr IL2CPP_TYPE_PTR
    // 020 BlockCount                               ModelPrimitiveType int int int Int32
    // 028 Ranges                                   ModelEnumType Block Block Block Int32
    // 048 RangeCount                               ModelPrimitiveType int int int Int32
    public partial class UnsafeStreamBlockData : DataModel
    {
        public AllocatorHandle                          Allocator                               { get; set; }
        public int                                      BlockCount                              { get; set; }
        public Block                                    Ranges                                  { get; set; }
        public int                                      RangeCount                              { get; set; }

        public static UnsafeStreamBlockData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeStreamBlockData() { Pointer= p0 };

            value.Allocator                                 = (AllocatorHandle)GetInt32(new IntPtr(p + 0x010)); // 0x10 Allocator                   ( ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32 )
            value.BlockCount                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 BlockCount                  ( ModelPrimitiveType int int int Int32 )
            value.Ranges                                    = (Block)GetInt32(new IntPtr(p + 0x028)); // 0x28 Ranges                      ( ModelEnumType Block Block Block Int32 )
            value.RangeCount                                = GetInt32(new IntPtr(p + 0x048)); // 0x48 RangeCount                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
