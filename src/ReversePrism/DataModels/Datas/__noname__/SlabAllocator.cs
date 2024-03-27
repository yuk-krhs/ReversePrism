using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_handle                                 000186699480 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32
    // 018 Storage                                  0001866CD820 ModelEnumType Block Block Block Int32
    // 038 Log2SlabSizeInBytes                      0001865F2F90 ModelPrimitiveType int int int Int32
    // 040 Occupied                                 FixedList4096Bytes`1<int> IL2CPP_TYPE_GENERICINST
    // 1040 BudgetInBytes                            0001865F79C0 ModelPrimitiveType long long long Int64
    // 1048 AllocatedBytes                           0001865F79C0 ModelPrimitiveType long long long Int64
    public partial class SlabAllocator
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
            var value   = new SlabAllocator();

            value.M_handle                                  = (AllocatorHandle)GetInt32(new IntPtr(p + 0x010)); // 0270034D7BA0 0x10 M_handle                    ( 000186699480 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32 )
            value.Storage                                   = (Block)GetInt32(new IntPtr(p + 0x018)); // 0270034D7BC0 0x18 Storage                     ( 0001866CD820 ModelEnumType Block Block Block Int32 )
            value.Log2SlabSizeInBytes                       = GetInt32(new IntPtr(p + 0x038)); // 0270034D7BE0 0x38 Log2SlabSizeInBytes         ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.BudgetInBytes                             = GetInt64(new IntPtr(p + 0x1040)); // 0270034D7C20 0x1040 BudgetInBytes               ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.AllocatedBytes                            = GetInt64(new IntPtr(p + 0x1048)); // 0270034D7C40 0x1048 AllocatedBytes              ( 0001865F79C0 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
