using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 170 TrackingState                            000186715740 ModelClassType IntegerControl IntegerControl IntegerControl Pointer
    // 178 IsTracked                                0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 180 DevicePosition                           000186777340 ModelClassType Vector3Control Vector3Control Vector3Control Pointer
    // 188 DeviceRotation                           0001865FB7A0 ModelClassType QuaternionControl QuaternionControl QuaternionControl Pointer
    public partial class TrackedDevice
    {
        public IntegerControl?                          TrackingState                           { get; set; }
        public ButtonControl?                           IsTracked                               { get; set; }
        public Vector3Control?                          DevicePosition                          { get; set; }
        public QuaternionControl?                       DeviceRotation                          { get; set; }

        public static TrackedDevice? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TrackedDevice();

            value.TrackingState                             = GetObject<IntegerControl>(new IntPtr(p + 0x170), ReversePrism.DataModels.IntegerControl.FromPointer); // 0270033B2CB0 0x170 TrackingState               ( 000186715740 ModelClassType IntegerControl IntegerControl IntegerControl Pointer )
            value.IsTracked                                 = GetObject<ButtonControl>(new IntPtr(p + 0x178), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033B2CD0 0x178 IsTracked                   ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.DevicePosition                            = GetObject<Vector3Control>(new IntPtr(p + 0x180), ReversePrism.DataModels.Vector3Control.FromPointer); // 0270033B2CF0 0x180 DevicePosition              ( 000186777340 ModelClassType Vector3Control Vector3Control Vector3Control Pointer )
            value.DeviceRotation                            = GetObject<QuaternionControl>(new IntPtr(p + 0x188), ReversePrism.DataModels.QuaternionControl.FromPointer); // 0270033B2D10 0x188 DeviceRotation              ( 0001865FB7A0 ModelClassType QuaternionControl QuaternionControl QuaternionControl Pointer )

            return value;
        }
    }
}
