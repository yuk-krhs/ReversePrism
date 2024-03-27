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
    // 030 KeyCapacity                              0001865F2F90 ModelPrimitiveType int int int Int32
    // 034 BucketCapacityMask                       0001865F2F90 ModelPrimitiveType int int int Int32
    // 038 AllocatedIndexLength                     0001865F2F90 ModelPrimitiveType int int int Int32
    // 000 kFirstFreeTLSOffset                      int IL2CPP_TYPE_I4
    // 000 IntsPerCacheLine                         int IL2CPP_TYPE_I4
    public partial class UnsafeParallelHashMapData
    {
        public int                                      KeyCapacity                             { get; set; }
        public int                                      BucketCapacityMask                      { get; set; }
        public int                                      AllocatedIndexLength                    { get; set; }

        public static UnsafeParallelHashMapData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeParallelHashMapData();

            value.KeyCapacity                               = GetInt32(new IntPtr(p + 0x030)); // 0270D9CDD140 0x30 KeyCapacity                 ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.BucketCapacityMask                        = GetInt32(new IntPtr(p + 0x034)); // 0270D9CDD160 0x34 BucketCapacityMask          ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.AllocatedIndexLength                      = GetInt32(new IntPtr(p + 0x038)); // 0270D9CDD180 0x38 AllocatedIndexLength        ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
