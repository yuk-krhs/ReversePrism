using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Value                                    0001865C2E50 ModelPrimitiveType double double double Double
    // 020 Type                                     000186614AA0 ModelEnumType MetricType MetricType MetricType Int32
    // 028 Tags                                     IDictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class Metric : DataModel
    {
        public string                                   Name                                    { get; set; }
        public double                                   Value                                   { get; set; }
        public MetricType                               Type                                    { get; set; }

        public static Metric? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Metric() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0245A6676800 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Value                                     = GetDouble(new IntPtr(p + 0x018)); // 0245A6676820 0x18 Value                       ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.Type                                      = (MetricType)GetInt32(new IntPtr(p + 0x020)); // 0245A6676840 0x20 Type                        ( 000186614AA0 ModelEnumType MetricType MetricType MetricType Int32 )

            return value;
        }
    }
}
