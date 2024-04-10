using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BatchSize                                0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 NumJobs                                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 TotalIterationCount                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 StartEndIndex                            <int> IL2CPP_TYPE_I
    public partial class JobRanges : DataModel
    {
        public int                                      BatchSize                               { get; set; }
        public int                                      NumJobs                                 { get; set; }
        public int                                      TotalIterationCount                     { get; set; }

        public static JobRanges? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JobRanges() { Pointer= p0 };

            value.BatchSize                                 = GetInt32(new IntPtr(p + 0x010)); // 0245A6865040 0x10 BatchSize                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.NumJobs                                   = GetInt32(new IntPtr(p + 0x014)); // 0245A6865060 0x14 NumJobs                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.TotalIterationCount                       = GetInt32(new IntPtr(p + 0x018)); // 0245A6865080 0x18 TotalIterationCount         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
