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
    // 030 KeyCapacity                              ModelPrimitiveType int int int Int32
    // 034 BucketCapacityMask                       ModelPrimitiveType int int int Int32
    // 038 AllocatedIndexLength                     ModelPrimitiveType int int int Int32
    // 000 kFirstFreeTLSOffset                      int IL2CPP_TYPE_I4
    // 000 IntsPerCacheLine                         int IL2CPP_TYPE_I4
    public partial class UnsafeParallelHashMapData : DataModel
    {
        public int                                      KeyCapacity                             { get; set; }
        public int                                      BucketCapacityMask                      { get; set; }
        public int                                      AllocatedIndexLength                    { get; set; }

        public static UnsafeParallelHashMapData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeParallelHashMapData() { Pointer= p0 };

            value.KeyCapacity                               = GetInt32(new IntPtr(p + 0x030)); // 0x30 KeyCapacity                 ( ModelPrimitiveType int int int Int32 )
            value.BucketCapacityMask                        = GetInt32(new IntPtr(p + 0x034)); // 0x34 BucketCapacityMask          ( ModelPrimitiveType int int int Int32 )
            value.AllocatedIndexLength                      = GetInt32(new IntPtr(p + 0x038)); // 0x38 AllocatedIndexLength        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
