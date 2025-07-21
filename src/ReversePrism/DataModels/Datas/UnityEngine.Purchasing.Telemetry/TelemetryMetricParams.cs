using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelEnumType TelemetryMetricTypes TelemetryMetricTypes TelemetryMetricTypes Int32
    // 018 Name                                     ModelPrimitiveType string string string String
    // 020 TimeSeconds                              ModelPrimitiveType double double double Double
    public partial class TelemetryMetricParams : DataModel
    {
        public TelemetryMetricTypes                     Type                                    { get; set; }
        public string                                   Name                                    { get; set; }
        public double                                   TimeSeconds                             { get; set; }

        public static TelemetryMetricParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TelemetryMetricParams() { Pointer= p0 };

            value.Type                                      = (TelemetryMetricTypes)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType TelemetryMetricTypes TelemetryMetricTypes TelemetryMetricTypes Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.TimeSeconds                               = GetDouble(new IntPtr(p + 0x020)); // 0x20 TimeSeconds                 ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
