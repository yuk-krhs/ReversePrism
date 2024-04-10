using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WarningLevel                             000186545580 ModelEnumType WarningLevel WarningLevel WarningLevel Int32
    // 014 TemperatureLevel                         0001866656B0 ModelPrimitiveType float float float Single
    // 018 TemperatureTrend                         0001866656B0 ModelPrimitiveType float float float Single
    public partial class ThermalMetrics : DataModel
    {
        public WarningLevel                             WarningLevel                            { get; set; }
        public float                                    TemperatureLevel                        { get; set; }
        public float                                    TemperatureTrend                        { get; set; }

        public static ThermalMetrics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThermalMetrics() { Pointer= p0 };

            value.WarningLevel                              = (WarningLevel)GetInt32(new IntPtr(p + 0x010)); // 02466090A308 0x10 WarningLevel                ( 000186545580 ModelEnumType WarningLevel WarningLevel WarningLevel Int32 )
            value.TemperatureLevel                          = GetSingle(new IntPtr(p + 0x014)); // 02466090A328 0x14 TemperatureLevel            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TemperatureTrend                          = GetSingle(new IntPtr(p + 0x018)); // 02466090A348 0x18 TemperatureTrend            ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
