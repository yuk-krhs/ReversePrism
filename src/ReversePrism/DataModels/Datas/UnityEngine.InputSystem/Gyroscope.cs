using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 170 AngularVelocity                          000186777340 ModelClassType Vector3Control Vector3Control Vector3Control Pointer
    // 000 <current>k__BackingField                 Gyroscope IL2CPP_TYPE_CLASS
    public partial class Gyroscope
    {
        public Vector3Control?                          AngularVelocity                         { get; set; }

        public static Gyroscope? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Gyroscope();

            value.AngularVelocity                           = GetObject<Vector3Control>(new IntPtr(p + 0x170), ReversePrism.DataModels.Vector3Control.FromPointer); // 0270033B0638 0x170 AngularVelocity             ( 000186777340 ModelClassType Vector3Control Vector3Control Vector3Control Pointer )

            return value;
        }
    }
}
