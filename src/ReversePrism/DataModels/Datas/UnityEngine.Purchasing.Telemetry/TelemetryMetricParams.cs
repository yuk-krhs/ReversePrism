using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     00018662B8A0 ModelEnumType TelemetryMetricTypes TelemetryMetricTypes TelemetryMetricTypes Int32
    // 018 Name                                     000186671BA0 ModelPrimitiveType string string string String
    // 020 TimeSeconds                              0001865C2BA0 ModelPrimitiveType double double double Double
    public partial class TelemetryMetricParams
    {
        public TelemetryMetricTypes                     Type                                    { get; set; }
        public string                                   Name                                    { get; set; }
        public double                                   TimeSeconds                             { get; set; }

        public static TelemetryMetricParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TelemetryMetricParams();

            value.Type                                      = (TelemetryMetricTypes)GetInt32(new IntPtr(p + 0x010)); // 027006930638 0x10 Type                        ( 00018662B8A0 ModelEnumType TelemetryMetricTypes TelemetryMetricTypes TelemetryMetricTypes Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 027006930658 0x18 Name                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.TimeSeconds                               = GetDouble(new IntPtr(p + 0x020)); // 027006930678 0x20 TimeSeconds                 ( 0001865C2BA0 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
