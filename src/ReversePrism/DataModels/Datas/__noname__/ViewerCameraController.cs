using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RotationObj                              0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class ViewerCameraController
    {
        public Transform?                               RotationObj                             { get; set; }

        public static ViewerCameraController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewerCameraController();

            value.RotationObj                               = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0270D4B1AD38 0x20 RotationObj                 ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
