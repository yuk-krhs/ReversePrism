using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 170 AmbientTemperature                       ModelClassType AxisControl AxisControl AxisControl Pointer
    // 000 <current>k__BackingField                 AmbientTemperatureSensor IL2CPP_TYPE_CLASS
    public partial class AmbientTemperatureSensor : DataModel
    {
        public AxisControl?                             AmbientTemperature                      { get; set; }

        public static AmbientTemperatureSensor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AmbientTemperatureSensor() { Pointer= p0 };

            value.AmbientTemperature                        = GetObject<AxisControl>(new IntPtr(p + 0x170), ReversePrism.DataModels.AxisControl.FromPointer); // 0x170 AmbientTemperature          ( ModelClassType AxisControl AxisControl AxisControl Pointer )

            return value;
        }
    }
}
