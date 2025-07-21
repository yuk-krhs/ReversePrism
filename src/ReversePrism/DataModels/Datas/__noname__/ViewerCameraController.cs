using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RotationObj                              ModelClassType Transform Transform Transform Pointer
    public partial class ViewerCameraController : DataModel
    {
        public Transform?                               RotationObj                             { get; set; }

        public static ViewerCameraController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewerCameraController() { Pointer= p0 };

            value.RotationObj                               = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 RotationObj                 ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
