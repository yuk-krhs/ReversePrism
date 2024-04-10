using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 170 Acceleration                             000186777340 ModelClassType Vector3Control Vector3Control Vector3Control Pointer
    // 000 <current>k__BackingField                 Accelerometer IL2CPP_TYPE_CLASS
    public partial class Accelerometer : DataModel
    {
        public Vector3Control?                          Acceleration                            { get; set; }

        public static Accelerometer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Accelerometer() { Pointer= p0 };

            value.Acceleration                              = GetObject<Vector3Control>(new IntPtr(p + 0x170), ReversePrism.DataModels.Vector3Control.FromPointer); // 0245A33B0270 0x170 Acceleration                ( 000186777340 ModelClassType Vector3Control Vector3Control Vector3Control Pointer )

            return value;
        }
    }
}
