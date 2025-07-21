using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     ModelEnumType UnsafeParallelHashMapDataDispose UnsafeParallelHashMapDataDispose UnsafeParallelHashMapDataDispose Int32
    public partial class UnsafeParallelHashMapDataDisposeJob : DataModel
    {
        public UnsafeParallelHashMapDataDispose         Data                                    { get; set; }

        public static UnsafeParallelHashMapDataDisposeJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeParallelHashMapDataDisposeJob() { Pointer= p0 };

            value.Data                                      = (UnsafeParallelHashMapDataDispose)GetInt32(new IntPtr(p + 0x010)); // 0x10 Data                        ( ModelEnumType UnsafeParallelHashMapDataDispose UnsafeParallelHashMapDataDispose UnsafeParallelHashMapDataDispose Int32 )

            return value;
        }
    }
}
