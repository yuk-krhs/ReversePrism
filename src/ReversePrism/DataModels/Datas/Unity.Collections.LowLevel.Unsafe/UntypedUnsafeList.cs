using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ptr                                      IntPtr IL2CPP_TYPE_PTR
    // 018 M_length                                 ModelPrimitiveType int int int Int32
    // 01C M_capacity                               ModelPrimitiveType int int int Int32
    // 020 Allocator                                ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32
    // 024 Padding                                  ModelPrimitiveType int int int Int32
    public partial class UntypedUnsafeList : DataModel
    {
        public int                                      M_length                                { get; set; }
        public int                                      M_capacity                              { get; set; }
        public AllocatorHandle                          Allocator                               { get; set; }
        public int                                      Padding                                 { get; set; }

        public static UntypedUnsafeList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UntypedUnsafeList() { Pointer= p0 };

            value.M_length                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_length                    ( ModelPrimitiveType int int int Int32 )
            value.M_capacity                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_capacity                  ( ModelPrimitiveType int int int Int32 )
            value.Allocator                                 = (AllocatorHandle)GetInt32(new IntPtr(p + 0x020)); // 0x20 Allocator                   ( ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32 )
            value.Padding                                   = GetInt32(new IntPtr(p + 0x024)); // 0x24 Padding                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
