using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 170 LightLevel                               000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
    // 000 <current>k__BackingField                 LightSensor IL2CPP_TYPE_CLASS
    public partial class LightSensor
    {
        public AxisControl?                             LightLevel                              { get; set; }

        public static LightSensor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightSensor();

            value.LightLevel                                = GetObject<AxisControl>(new IntPtr(p + 0x170), ReversePrism.DataModels.AxisControl.FromPointer); // 0270033B1920 0x170 LightLevel                  ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )

            return value;
        }
    }
}
