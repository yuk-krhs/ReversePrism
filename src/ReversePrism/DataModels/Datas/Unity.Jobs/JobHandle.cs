using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JobGroup                                 00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 Version                                  0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class JobHandle : DataModel
    {
        public ulong                                    JobGroup                                { get; set; }
        public int                                      Version                                 { get; set; }

        public static JobHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JobHandle() { Pointer= p0 };

            value.JobGroup                                  = GetUInt64(new IntPtr(p + 0x010)); // 0245A24543C8 0x10 JobGroup                    ( 00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x018)); // 0245A24543E8 0x18 Version                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
