using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TargetUrl                                0001866722E0 ModelPrimitiveType string string string String
    // 018 ServicePath                              0001866722E0 ModelPrimitiveType string string string String
    // 020 PayloadExpirationSeconds                 0001865C2E50 ModelPrimitiveType double double double Double
    // 028 PayloadSendingMaxIntervalSeconds         0001865C2E50 ModelPrimitiveType double double double Double
    // 030 SafetyPersistenceIntervalSeconds         0001865C2E50 ModelPrimitiveType double double double Double
    // 038 MaxMetricCountPerPayload                 0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class TelemetryConfig : DataModel
    {
        public string                                   TargetUrl                               { get; set; }
        public string                                   ServicePath                             { get; set; }
        public double                                   PayloadExpirationSeconds                { get; set; }
        public double                                   PayloadSendingMaxIntervalSeconds        { get; set; }
        public double                                   SafetyPersistenceIntervalSeconds        { get; set; }
        public int                                      MaxMetricCountPerPayload                { get; set; }

        public static TelemetryConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TelemetryConfig() { Pointer= p0 };

            value.TargetUrl                                 = GetString(new IntPtr(p + 0x010)); // 0245A663EA58 0x10 TargetUrl                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ServicePath                               = GetString(new IntPtr(p + 0x018)); // 0245A663EA78 0x18 ServicePath                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.PayloadExpirationSeconds                  = GetDouble(new IntPtr(p + 0x020)); // 0245A663EA98 0x20 PayloadExpirationSeconds    ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.PayloadSendingMaxIntervalSeconds          = GetDouble(new IntPtr(p + 0x028)); // 0245A663EAB8 0x28 PayloadSendingMaxIntervalSeconds ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.SafetyPersistenceIntervalSeconds          = GetDouble(new IntPtr(p + 0x030)); // 0245A663EAD8 0x30 SafetyPersistenceIntervalSeconds ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.MaxMetricCountPerPayload                  = GetInt32(new IntPtr(p + 0x038)); // 0245A663EAF8 0x38 MaxMetricCountPerPayload    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
