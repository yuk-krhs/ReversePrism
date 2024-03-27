using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GraphicsManager                          GraphicsManager IL2CPP_TYPE_CLASS
    // 008 EffectManager                            EffectManager IL2CPP_TYPE_CLASS
    // 010 CameraCaptureManager                     000186535A20 ModelClassType CameraCaptureManager CameraCaptureManager CameraCaptureManager Pointer
    public partial class GraphicsLocator
    {
        public CameraCaptureManager?                    CameraCaptureManager                    { get; set; }

        public static GraphicsLocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GraphicsLocator();

            value.CameraCaptureManager                      = GetObject<CameraCaptureManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.CameraCaptureManager.FromPointer); // 0270D0E624F0 0x10 CameraCaptureManager        ( 000186535A20 ModelClassType CameraCaptureManager CameraCaptureManager CameraCaptureManager Pointer )

            return value;
        }
    }
}
