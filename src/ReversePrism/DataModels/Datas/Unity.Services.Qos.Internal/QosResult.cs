using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Region                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 AverageLatencyMs                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C PacketLossPercent                        000186666050 ModelPrimitiveType float float float Single
    public partial class QosResult : DataModel
    {
        public string                                   Region                                  { get; set; }
        public int                                      AverageLatencyMs                        { get; set; }
        public float                                    PacketLossPercent                       { get; set; }

        public static QosResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QosResult() { Pointer= p0 };

            value.Region                                    = GetString(new IntPtr(p + 0x010)); // 02466BADD648 0x10 Region                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AverageLatencyMs                          = GetInt32(new IntPtr(p + 0x018)); // 02466BADD668 0x18 AverageLatencyMs            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PacketLossPercent                         = GetSingle(new IntPtr(p + 0x01C)); // 02466BADD688 0x1C PacketLossPercent           ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
