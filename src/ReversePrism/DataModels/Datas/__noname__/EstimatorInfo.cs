using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   00018654D570 ModelEnumType Status Status Status Int32
    // 014 Estimated_latency                        0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class EstimatorInfo
    {
        public Status                                   Status                                  { get; set; }
        public uint                                     Estimated_latency                       { get; set; }

        public static EstimatorInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EstimatorInfo();

            value.Status                                    = (Status)GetInt32(new IntPtr(p + 0x010)); // 0270DAC6EC48 0x10 Status                      ( 00018654D570 ModelEnumType Status Status Status Int32 )
            value.Estimated_latency                         = GetUInt32(new IntPtr(p + 0x014)); // 0270DAC6EC68 0x14 Estimated_latency           ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
