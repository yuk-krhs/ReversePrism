using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 values                                   IntPtr IL2CPP_TYPE_PTR
    // 018 keys                                     IntPtr IL2CPP_TYPE_PTR
    // 020 next                                     IntPtr IL2CPP_TYPE_PTR
    // 028 buckets                                  IntPtr IL2CPP_TYPE_PTR
    // 030 BucketCapacityMask                       0001865F4940 ModelPrimitiveType int int int Int32
    public partial class UnsafeParallelHashMapBucketData : DataModel
    {
        public int                                      BucketCapacityMask                      { get; set; }

        public static UnsafeParallelHashMapBucketData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeParallelHashMapBucketData() { Pointer= p0 };

            value.BucketCapacityMask                        = GetInt32(new IntPtr(p + 0x030)); // 024669B3A280 0x30 BucketCapacityMask          ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
