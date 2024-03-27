using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kMinAperture                             float IL2CPP_TYPE_R4
    // 000 kMaxAperture                             float IL2CPP_TYPE_R4
    // 000 kMinBladeCount                           int IL2CPP_TYPE_I4
    // 000 kMaxBladeCount                           int IL2CPP_TYPE_I4
    // 000 onPreCull                                CameraCallback IL2CPP_TYPE_CLASS
    // 008 onPreRender                              CameraCallback IL2CPP_TYPE_CLASS
    // 010 OnPostRender                             000186722250 ModelClassType CameraCallback CameraCallback CameraCallback Pointer
    public partial class Camera
    {
        public CameraCallback?                          OnPostRender                            { get; set; }

        public static Camera? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Camera();

            value.OnPostRender                              = GetObject<CameraCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.CameraCallback.FromPointer); // 02700233A9F8 0x10 OnPostRender                ( 000186722250 ModelClassType CameraCallback CameraCallback CameraCallback Pointer )

            return value;
        }
    }
}
