using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 170 MagneticField                            000186777340 ModelClassType Vector3Control Vector3Control Vector3Control Pointer
    // 000 <current>k__BackingField                 MagneticFieldSensor IL2CPP_TYPE_CLASS
    public partial class MagneticFieldSensor
    {
        public Vector3Control?                          MagneticField                           { get; set; }

        public static MagneticFieldSensor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MagneticFieldSensor();

            value.MagneticField                             = GetObject<Vector3Control>(new IntPtr(p + 0x170), ReversePrism.DataModels.Vector3Control.FromPointer); // 0270033B1558 0x170 MagneticField               ( 000186777340 ModelClassType Vector3Control Vector3Control Vector3Control Pointer )

            return value;
        }
    }
}
