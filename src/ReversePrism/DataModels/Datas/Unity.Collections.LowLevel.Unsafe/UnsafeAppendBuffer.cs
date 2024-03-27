using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ptr                                      IntPtr IL2CPP_TYPE_PTR
    // 018 Length                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Capacity                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Allocator                                0001866996D0 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32
    // 024 Alignment                                0001865F4940 ModelPrimitiveType int int int Int32
    public partial class UnsafeAppendBuffer
    {
        public int                                      Length                                  { get; set; }
        public int                                      Capacity                                { get; set; }
        public AllocatorHandle                          Allocator                               { get; set; }
        public int                                      Alignment                               { get; set; }

        public static UnsafeAppendBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeAppendBuffer();

            value.Length                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D9C84638 0x18 Length                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Capacity                                  = GetInt32(new IntPtr(p + 0x01C)); // 0270D9C84658 0x1C Capacity                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Allocator                                 = (AllocatorHandle)GetInt32(new IntPtr(p + 0x020)); // 0270D9C84678 0x20 Allocator                   ( 0001866996D0 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32 )
            value.Alignment                                 = GetInt32(new IntPtr(p + 0x024)); // 0270D9C84698 0x24 Alignment                   ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
