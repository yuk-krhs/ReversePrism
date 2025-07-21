using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Last                                     ModelPrimitiveType float float float Single
    // 014 Average                                  ModelPrimitiveType float float float Single
    // 018 Peak                                     ModelPrimitiveType float float float Single
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

            value.Last                                      = GetSingle(new IntPtr(p + 0x010)); // 0x10 Last                        ( ModelPrimitiveType float float float Single )
            value.Average                                   = GetSingle(new IntPtr(p + 0x014)); // 0x14 Average                     ( ModelPrimitiveType float float float Single )
            value.Peak                                      = GetSingle(new IntPtr(p + 0x018)); // 0x18 Peak                        ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
