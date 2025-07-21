using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TargetCpu                                ModelEnumType BurstTargetCpu BurstTargetCpu BurstTargetCpu Int32
    public partial class BurstTargetCpuAttribute : DataModel
    {
        public BurstTargetCpu                           TargetCpu                               { get; set; }

        public static BurstTargetCpuAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BurstTargetCpuAttribute() { Pointer= p0 };

            value.TargetCpu                                 = (BurstTargetCpu)GetInt32(new IntPtr(p + 0x010)); // 0x10 TargetCpu                   ( ModelEnumType BurstTargetCpu BurstTargetCpu BurstTargetCpu Int32 )

            return value;
        }
    }
}
