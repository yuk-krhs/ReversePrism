using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_handle                                 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32
    // 018 Storage                                  ModelEnumType Block Block Block Int32
    // 038 Log2SlabSizeInBytes                      ModelPrimitiveType int int int Int32
    // 040 Occupied                                 FixedList4096Bytes`1<int> IL2CPP_TYPE_GENERICINST
    // 1040 BudgetInBytes                            ModelPrimitiveType long long long Int64
    // 1048 AllocatedBytes                           ModelPrimitiveType long long long Int64
    public partial class SlabAllocator : DataModel
    {
        public AllocatorHandle                          M_handle                                { get; set; }
        public Block                                    Storage                                 { get; set; }
        public int                                      Log2SlabSizeInBytes                     { get; set; }
        public long                                     BudgetInBytes                           { get; set; }
        public long                                     AllocatedBytes                          { get; set; }

        public static SlabAllocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SlabAllocator() { Pointer= p0 };

            value.M_handle                                  = (AllocatorHandle)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_handle                    ( ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32 )
            value.Storage                                   = (Block)GetInt32(new IntPtr(p + 0x018)); // 0x18 Storage                     ( ModelEnumType Block Block Block Int32 )
            value.Log2SlabSizeInBytes                       = GetInt32(new IntPtr(p + 0x038)); // 0x38 Log2SlabSizeInBytes         ( ModelPrimitiveType int int int Int32 )
            value.BudgetInBytes                             = GetInt64(new IntPtr(p + 0x1040)); // 0x1040 BudgetInBytes               ( ModelPrimitiveType long long long Int64 )
            value.AllocatedBytes                            = GetInt64(new IntPtr(p + 0x1048)); // 0x1048 AllocatedBytes              ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
