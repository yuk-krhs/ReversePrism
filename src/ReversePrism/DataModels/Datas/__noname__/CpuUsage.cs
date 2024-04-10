using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Last                                     000186666050 ModelPrimitiveType float float float Single
    // 014 Average                                  000186666050 ModelPrimitiveType float float float Single
    // 018 Peak                                     000186666050 ModelPrimitiveType float float float Single
    public partial class CpuUsage : DataModel
    {
        public float                                    Last                                    { get; set; }
        public float                                    Average                                 { get; set; }
        public float                                    Peak                                    { get; set; }

        public static CpuUsage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CpuUsage() { Pointer= p0 };

            value.Last                                      = GetSingle(new IntPtr(p + 0x010)); // 024660F850D0 0x10 Last                        ( 000186666050 ModelPrimitiveType float float float Single )
            value.Average                                   = GetSingle(new IntPtr(p + 0x014)); // 024660F850F0 0x14 Average                     ( 000186666050 ModelPrimitiveType float float float Single )
            value.Peak                                      = GetSingle(new IntPtr(p + 0x018)); // 024660F85110 0x18 Peak                        ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
