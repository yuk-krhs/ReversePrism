using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 170 Acceleration                             000186777340 ModelClassType Vector3Control Vector3Control Vector3Control Pointer
    // 000 <current>k__BackingField                 LinearAccelerationSensor IL2CPP_TYPE_CLASS
    public partial class LinearAccelerationSensor : DataModel
    {
        public Vector3Control?                          Acceleration                            { get; set; }

        public static LinearAccelerationSensor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LinearAccelerationSensor() { Pointer= p0 };

            value.Acceleration                              = GetObject<Vector3Control>(new IntPtr(p + 0x170), ReversePrism.DataModels.Vector3Control.FromPointer); // 0245A33B1190 0x170 Acceleration                ( 000186777340 ModelClassType Vector3Control Vector3Control Vector3Control Pointer )

            return value;
        }
    }
}
