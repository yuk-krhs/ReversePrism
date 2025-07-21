using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 170 AtmosphericPressure                      ModelClassType AxisControl AxisControl AxisControl Pointer
    // 000 <current>k__BackingField                 PressureSensor IL2CPP_TYPE_CLASS
    public partial class PressureSensor : DataModel
    {
        public AxisControl?                             AtmosphericPressure                     { get; set; }

        public static PressureSensor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PressureSensor() { Pointer= p0 };

            value.AtmosphericPressure                       = GetObject<AxisControl>(new IntPtr(p + 0x170), ReversePrism.DataModels.AxisControl.FromPointer); // 0x170 AtmosphericPressure         ( ModelClassType AxisControl AxisControl AxisControl Pointer )

            return value;
        }
    }
}
