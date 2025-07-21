using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JobGroup                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 Version                                  ModelPrimitiveType int int int Int32
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

            value.JobGroup                                  = GetUInt64(new IntPtr(p + 0x010)); // 0x10 JobGroup                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 Version                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
